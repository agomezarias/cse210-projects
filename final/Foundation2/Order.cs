using System;
using System.Collections.Generic;

public class Order
{
    private Customer _customerInfo;
    private List<Product> _products = new List<Product>();
    private string _packingLabel = "";
    private double _totalWithShipping = 0;
    DateTime localDate = DateTime.Now;

    public Order(Customer customerInfo, List<Product> products)
    {
        _customerInfo = customerInfo;
        _products = products;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public void GetPackingLabel()
    {
        Console.WriteLine();
        Console.WriteLine("----------------Packing Label-------------");
        Console.WriteLine();

        foreach (Product product in _products)
        {
            _packingLabel += $"ProductName:{product.GetProductName()}, ID:{product.GetProductID()}\n";
        }
        
        Console.WriteLine(_packingLabel);
        // return _packingLabel;
    }
    

    public double TotalPlusSHipping()
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

    //TODO Finish making the receipt display and test it. 
    public void DisplayOrderReceipt()
    {
        
    }

}