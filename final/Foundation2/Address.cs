using System;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _zipCode;
    private string _country;
    private bool _isInUSA;

    public Address(string street, string city, string state, string zipcode, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _zipCode = zipcode;
        _country = country;
    }

    public string GetAddressString()
    {
        return $"{_street}\n {_city}, {_state} {_zipCode}\n {_country.ToUpper()}";
    }

    public bool GetCountry()
    {
        if (_country == "USA" || _country == "US" || _country == "United States")
        {
            _isInUSA = true;
        }

        else
        {
            _isInUSA = false;
        }

        return _isInUSA;
    }
}