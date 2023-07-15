using System;
using System.Collections.Generic;

public class Order
{
    private Customer _customerInfo;
    private List<Product> _products = new List<Product>();
    private string _packingLabel = "";
    private string _shippingCost = "";
    private double _totalWithShipping = 0;
    private double _subtotalPlusTax;
    private string _receipt;
    DateTime _localDate = DateTime.Now;

    public Order(Customer customerInfo, List<Product> products)
    {
        _customerInfo = customerInfo;
        _products = products;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public string GetPackingLabel()
    {
        _packingLabel += "\n----------------Packing Label--------------\n\n";
        

        foreach (Product product in _products)
        {
            _packingLabel += $"Product Name: {product.GetProductName().PadRight(15)} ID: {product.GetProductID()}\n";
        }

        _packingLabel += $"\n                Total Items: {_products.Count()}";

        _packingLabel += "\n-------------------------------------------";
        
        // Console.WriteLine(_packingLabel);
        return _packingLabel;
    }

    public string GetShippingCost()
    {
        if (_customerInfo.IsAddressUSA())
        {
            _shippingCost = $"$5.00";
        }
        else
        {
            _shippingCost = $"$35.00";
        }

        return _shippingCost;
    }
    

    public double TotalPlusShipping()
    {
        foreach (Product product in _products)
        {
            _totalWithShipping += product.ProductPriceTotal();
        }

        if (_customerInfo.IsAddressUSA())
        {
            _totalWithShipping = _totalWithShipping + 5;
        }
        else
        {
            _totalWithShipping = _totalWithShipping + 35;
        }
    

        return _totalWithShipping;
    }

    public double AddTax()
    {
        _subtotalPlusTax = _totalWithShipping * .08;
        return _subtotalPlusTax;
    }

    public double TotalSalesPrice()
    {
        return AddTax() + _totalWithShipping;
    }

    public string DisplayOrderReceipt()
    {
        _receipt =  $"\n-------------------------------------------\n";
        _receipt += $"                SALES RECEIPT";
        _receipt += $"\n-------------------------------------------";
        _receipt += $"\n\n    !!THANK YOU FOR SHOPPING WITH US!!";
        _receipt += $"\n\n           {_localDate}";
        _receipt += $"\n\n-------------------------------------------\n";
        _receipt += $"QTY     ITEM                    PRICE\n";
        _receipt += $"-------------------------------------------";

        foreach (Product product in _products)
        {
            _receipt += $"\n{product.GetQuantity()}       {product.GetProductName().PadRight(23)} ${product.GetPrice()}";
        }
        
        _receipt += $"\n\nShipping & Handling:            {GetShippingCost()}";
        _receipt += $"\n\nSubtotal:                       ${TotalPlusShipping():0.00}";
        _receipt += $"\nTax: (8%)                       ${AddTax():0.00}";
        _receipt += $"\nTotal:                          ${TotalSalesPrice():0.00}";
        _receipt += $"\n-------------------------------------------\n";
        _receipt += $"          !!HAVE A BLESSED DAY!!\n";
        _receipt += $"-------------------------------------------";

        return _receipt; 
    }

}