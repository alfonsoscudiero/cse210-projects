using System;

public class SimpleGoal : Goal
{
    // Variable to track
    private bool _isComplete;

    // Call constructor from base
    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
        _isComplete = false; // By default, a SimpleGoal is not complete
    }
    // Method to Record an event
    public override void RecordEvent()
    {
        _isComplete = true; // Mark the goal as complete
    }
    // Method to check if the goal is complete
    public override bool IsComplete()
    {
        return _isComplete;
    }
    // Method to get a string of the goal for saving to a text file
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal: %% {_shortName}, %% {_description}, %% {_points}, %% {_isComplete}";
    }

}