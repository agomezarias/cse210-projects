using System;
using System.Globalization;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _zipCode;
    private string _country;
    private bool _isInUSA;
    TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;


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
        return $"{textInfo.ToTitleCase(_street)}\n{textInfo.ToTitleCase(_city)}, {_state.ToUpper()} {_zipCode}\n{_country.ToUpper()}";
    }

    public bool IsAddressUSA()
    {
        if (_country.ToUpper() == "USA" || _country.ToUpper() == "US" || _country.ToUpper() == "United States")
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