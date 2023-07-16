using System;
using System.Globalization;


public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _zipCode;
    private string _country;
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
        return $"{textInfo.ToTitleCase(_street)}, {textInfo.ToTitleCase(_city)}, {_state.ToUpper()} {_zipCode}, {_country.ToUpper()}";
    }
}