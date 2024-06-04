using System;

public class Cycling : Activity
{
    private double _speed { get; set; }

    // Constructor
    public Cycling(DateTime date, int duration, double speed) : base(date, duration)
    {
        _speed = speed; // in mph
    }

    // Method to compute and return the distance in miles
    public override double GetDistance()
    {
        return (_speed * GetDuration() / 60);
    }

    // Method to get speed
    public override double GetSpeed()
    {
        return _speed;
    }

    // Method to compute and return the pace in minutes per mile
    public override double GetPace()
    {
        return 60 / _speed;
    }
}