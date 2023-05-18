using System;

public class Fraction
{
    private int _topNumber;
    private int _bottomNumber;

    public Fraction()
    {
        _topNumber = 1;
        _bottomNumber = 1;
        
    }

    public Fraction(int wholeNumber)
    {
        _topNumber = wholeNumber;
        _bottomNumber = 1;

    }

    public Fraction(int top, int bottom)
    {
        _topNumber = top;
        _bottomNumber = bottom;
    }

    public int GetTopNumber()
    {
        return _topNumber;
    }

    public int SetTopNumber(int SetTop)
    {
        _topNumber = SetTop;

        return SetTop;
    }

    public int GetBottomNumber()
    {
        return _bottomNumber;
    }

    public int SetBottomNumber(int SetBottom)
    {
        _bottomNumber = SetBottom;

        return SetBottom;
    }

    public string GetFractionString()
    {
        string fractionString = $"{_topNumber}/{_bottomNumber}";
        return fractionString;
    }

    public double GetDecimalValue()
    {
        return (double)_topNumber / (double)_bottomNumber;
    }

}