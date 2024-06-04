using System;

public class Running : Activity
{
    private double _distance { get; set; } // in miles

    // Constructor
    public Running(DateTime date, int duration, double distance) : base(date, duration)
    {
        _distance = distance;
    }

    // Method to get distance
    public override double GetDistance()
    {
        return _distance;
    }

    // Method to compute and return the speed in mph
    public override double GetSpeed()
    {
        return (_distance / GetDuration() * 60);
    }

    // Method to compute and return the pace in minutes per mile
    public override double GetPace()
    {
        return (GetDuration() / _distance);
    }
}