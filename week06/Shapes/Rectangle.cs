using System;
public class Rectangle : Shape
{
    private double _side;
    private double _width;

    public Rectangle(string color, double side, double width) : base(color)
    {
        _width = width;
        _side = side;
    }

    public override double GetArea()
    {
        return _width * _side;
    }
}