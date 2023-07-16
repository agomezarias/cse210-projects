using System;
using System.Globalization;

public class Customer
{
    private string _customerName;
    private Address _customerAddress;
    // private string _shippingLabel = "";
    TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;


    public Customer(string customerName, Address customerAddress)
    {
        _customerName = customerName;
        _customerAddress = customerAddress;
    }

    public string GetCustomerName()
    {
        return textInfo.ToTitleCase(_customerName);
    }

    public bool IsAddressUSA()
    {
        return _customerAddress.IsAddressUSA();
    }

    public string GetCustomerAddress()
    {
        return textInfo.ToTitleCase(_customerAddress.GetAddressString());
    }
}

    //MOVED SHIPPING LABEL TO ORDER CLASS TO BE ABLE TO ITERATE THROUGH ORDERS.

    // public string GetShippingLabel() 
    // {
    //     _shippingLabel = "\n----------------Shipping Label-------------\n";

    //     _shippingLabel += $"Order For:\n{_customerName}\n{_customerAddress.GetAddressString()}";

    //     _shippingLabel += "\n-------------------------------------------";

    //     return _shippingLabel;
    // }   