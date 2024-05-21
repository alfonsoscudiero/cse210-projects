using System;

public abstract class Shape
{
    // Private field to store the color of the shape
    private string _color;

    // Constructor
    public Shape(string color)
    {
        _color = color;
    }

    // Getters and Setters
    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string color)
    {
        _color = color;
    }
    
    // Virtual Method for compute area
    public abstract double GetArea();
}