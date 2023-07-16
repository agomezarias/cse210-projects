using System;
using System.Globalization;

public class Product
{
    private string _productName;
    private string _productID;
    private double _price;
    private int _quantity;
    TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;


    public Product(string productName, string productID, double price, int quantity)
    {
        _productName = productName;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    public string GetProductName()
    {
        return textInfo.ToTitleCase(_productName);
    }

    public string GetProductID()
    {
        
        return _productID.ToUpper();
    }

    public double GetPrice()
    {
        return _price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public double ProductPriceTotal()
    {
        return  _price * _quantity;
    }
}