using System;

public class EternalGoal : Goal
{
    private int _totalPointEarned;

    // Call constructor from base
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {
        _totalPointEarned = 0;
    }
    // Method to Record an event (Is eternal and never completes)
    public override int RecordEvent()
    {
        int points = int.Parse(_points);
        _totalPointEarned += points;
        return points; // Eternal goals just return points
    }
    // Method to check if the goal is complete
    public override bool IsComplete()
    {
        return false; // Always return false since EternalGoal is eternal
    }
    // Method to get a string of the goal for saving to a text file
    public override string GetStringRepresentation()
    {
        return $"EternalGoal, {_shortName}, {_description}, {_points}, {_totalPointEarned}";
    }

    // Method to set total points earned when loading goals
    public void SetTotalPointsEarned(int points)
    {
        _totalPointEarned = points;
    }
}