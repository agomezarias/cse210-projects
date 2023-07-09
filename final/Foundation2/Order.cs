using System;
using System.Collections.Generic;

public class Order
{
    private Customer _customerInfo;
    private List<Product> _products = new List<Product>();
    
    private double _totalWithShipping = 0;

    public Order(Customer customerInfo)
    {
        _customerInfo = customerInfo;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public void GetPackingLabel()
    {
        foreach (Product product in _products)
        {
            string _packingLabel = "";
            _packingLabel += $"ProductName:{product.GetProductName()}, ID:{product.GetProductID()}";
        }
    }

    public double TotalPlusSHipping()
    {
        foreach (Product product in _products)
        {
            _totalWithShipping += product.ProductPriceTotal();
        }

        if (_customerInfo.GetCountry())
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

}