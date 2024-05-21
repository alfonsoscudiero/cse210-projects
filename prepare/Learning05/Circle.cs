using System;

public class Circle : Shape
{
    // Private field to store the radius of the circle
    private double _radius;
    
    // Constructor from base
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }
    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}
