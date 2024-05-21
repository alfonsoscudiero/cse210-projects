using System;

public class Square : Shape
{
    // Private field to store the side of the square
    private double _side;
    
    // Call a constructor from base
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    // Compute the area of the square
    public override double GetArea()
    {
        return _side * _side;
    }
}
