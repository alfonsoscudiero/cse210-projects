using System;
using System.Dynamic;

class Fraction
{
    // Member variables (attributes)
    private int _top;
    private int _bottom;
    
    // Constructor that initializes to 1/1
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    // Constructor that initializes to whole number/1
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    // Constructor that initializes to custom fraction
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    // Getter and setter methods for top and bottom attributes
    // public int GetTop()
    // {
    //     return _top;
    // }
    // public void SetTop(int top)
    // {
    //     _top = top;
    // }
    // public int GetBottom()
    // {
    //     return _bottom;
    // }
    // public void SetBottom(int bottom)
    // {
    //     _bottom = bottom;
    // }
    // Create methods to return the representations
    public string GetFractionString()
    {
        return $"{_top} / {_bottom}";
    }
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}

