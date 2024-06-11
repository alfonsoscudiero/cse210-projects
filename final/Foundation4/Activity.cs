using System;
using System.Collections.Generic;

public abstract class Activity
{
    private DateTime _date { get; set; }
    private int _duration { get; set; } // in minutes

    // Constructor
    public Activity(DateTime date, int duration)
    {
        _date = date;
        _duration = duration;  
    }

    // Method to get distance of the activity
    public abstract double GetDistance();

    // Method to get speed of the activity
    public abstract double GetSpeed();

    // Method to Get Pace of the activity
    public abstract double GetPace();

    // Method to get summary information of the activity
    public string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} {GetType().Name} ({_duration} min) - Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per miles";
    }
    
    // Method to provide access to '_duration' variable within the derived classes
    protected int GetDuration()
    {
        return _duration;
    }
}