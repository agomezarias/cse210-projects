using System;

public class OutdoorGathering : Event
{
    private string _weatherForecast;


    public OutdoorGathering(string title, string description, string date, string time, Address address, 
    string weatherForecast) : base(title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }

    public override string GetFullDetails()
    {
        //You get ° from the keyboard as ALT + 0176 on the numeric keypad.

        return $"{base.GetFullDetails()} \nForcasted Weather: {_weatherForecast}°F";
    }

}