using System;


public abstract class Shape
{
    private string _color;

    public Shape(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    // public virtual Double GetArea()
    // {
    //     return 0;
    // }

    //No Body.. Abstract instead
    public abstract double GetArea();

}