using System;

public class Swimming : Activity
{
    private int _laps { get; set; } // lap pool is 50 meters

    // Constructor
    public Swimming(DateTime date, int duration, int laps) : base(date, duration)
    {
        _laps = laps;
    }

    // Method to compute and return the distance in miles
    public override double GetDistance()
    {
        return (_laps * 50) / (1000 * 0.62);  // Convert meters to miles 
    }

    // Method to compute and return the speed in mph
    public override double GetSpeed()
    {
        return (GetDistance() / GetDuration()) * 60;
    }

    // Method to compute and return the pace in minutes per mile
    public override double GetPace()
    {
        return GetDuration() / GetDistance();
    }
}