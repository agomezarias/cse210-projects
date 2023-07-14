using System;

public class Event
{
    private string _titile;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _titile = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetStandardDetails()
    {
        return $"Title: {_titile} \n Description: {_description} \n Date: {_date} \n Time: {_time} \n Address: {_address}";
    }


    // public string GetFullDetails()
    // {
    //     return $"{GetStandardDetails()} \n Event Type: {}"
    // }

}