using System;

public class Rectangle : Shape
{
    // Private field to store the side of the rectangle
    private double _length;
    private double _width;
    
    // Call constructor from base
    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }
    public override double GetArea()
    {
        return _length * _width;
    }
}
