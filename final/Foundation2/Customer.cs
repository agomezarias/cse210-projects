using System;

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

    public string GetCustomerInfo()
    {
        _shippingLabel = $"{_customerName}\n{_customerAddress.GetAddressString()}";

        return _shippingLabel;
    }   
}