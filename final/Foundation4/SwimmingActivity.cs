using System;

public class Swimming : Activity
{
    private int _laps;


    public Swimming(DateTime date, int length, int laps) : base(date, length)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000;
    }

    public override double GetSpeed()
    {
        return GetDistance() / _length * 60;
    }

    public override double GetPace()
    {
        return _length / GetDistance();
    }

    public override string GetActivitySummary()
    {
        return $"{base.GetActivitySummary()} - Distance: {GetDistance():0.00} kilometers, Speed: {GetSpeed():0.00} kph, Pace: {GetPace():0.00} min/km";
    }
}