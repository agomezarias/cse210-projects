using System;

public class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int length, double distance) : base(date, length)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / _length) * 60;
    }

    public override double GetPace()
    {
        return _length / _distance;
    }

    public override string GetActivitySummary()
    {
        return $"{base.GetActivitySummary()} - Distance: {GetDistance():0.00} kilometers, Speed: {GetSpeed():0.00} kph, Pace: {GetPace():0.00} min/km";
    }
}