using System;

public class Activity
{
    private DateTime _date;
    protected int _length; //In minutes

    public Activity(DateTime date, int length)
    {
        _date = date;
        _length = length;
    }

    public virtual double GetDistance() //kilometers
    {
        return 0;
    }

    public virtual double GetSpeed() //kilometers per hour
    {
        return 0;
    }

    public virtual double GetPace() //minutes(length) per kilometer
    {
        return 0;
    }

    public virtual string GetActivitySummary()
    {
        return $"{_date:d MMM yyyy} {GetType()} ({_length} min)"; //format day Month year- 05 Dec 1991
    }
}