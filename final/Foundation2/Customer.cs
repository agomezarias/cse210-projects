using System;
using System.Globalization;

public class Customer
{
    private string _customerName;
    private Address _customerAddress;
    private string _shippingLabel = "";

    public Customer(string customerName, Address customerAddress)
    {
        _customerName = customerName;
        _customerAddress = customerAddress;
    }

    public string GetCustomerName()
    {
        return _customerName;
    }

    public bool IsAddressUSA()
    {
        return _customerAddress.IsAddressUSA();
    }

    public string GetShippingLabel() 
    {
        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;


        _shippingLabel = "\n----------------Shipping Label-------------\n";

        _shippingLabel += $"Order For:\n{textInfo.ToTitleCase(_customerName)}\n{_customerAddress.GetAddressString()}";

        _shippingLabel += "\n-------------------------------------------";

        return _shippingLabel;
    }   
}