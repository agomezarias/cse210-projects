using System;

public class Customer
{
    private string _customerName;
    private Address _customerAddress;


    public Customer(string customerName, Address customerAddress)
    {
        _customerName = customerName;
        _customerAddress = customerAddress;
    }

    public string GetCustomerName()
    {
        return _customerName;
    }

    public bool GetCountry()
    {
        return _customerAddress.GetCountry();
    }

    public void GetShippingLabel()
    {
        Console.WriteLine($"{_customerName}\n {_customerAddress.GetAddressString()}");
    }   
}