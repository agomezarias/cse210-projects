using System;

public class Product
{
    private string _productName;
    private string _productID;
    private double _price;
    private int _quantity;

    public Product(string productName, string productID, double price, int quantity)
    {
        _productName = productName;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    public string GetProductName()
    {
        return _productName;
    }


    public string GetProductID()
    {
        return _productID;
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