using System;

public class Cycling : Activity
{
    private double _speed;


    public Cycling(DateTime date, int length, double speed) : base(date, length)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed * _length) / 60;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

    public override string GetActivitySummary()
    {
        return $"{base.GetActivitySummary()} - Distance: {GetDistance():0.00} kilometers, Speed: {GetSpeed():0.00} kph, Pace: {GetPace():0.00} min/km";
    }
}