using System;

public class EternalGoal : Goal
{
    // Call constructor from base
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {
        // No additional attributes to initialize
    }
    // Method to Record an event (Is eternal and never completes)
    public override void RecordEvent()
    {
    }
    // Method to check if the goal is complete
    public override bool IsComplete()
    {
        return false; // Always return false since EternalGoal is eternal
    }
    // Method to get a string of the goal for saving to a text file
    public override string GetStringRepresentation()
    {
        return $"EternalGoal: %% {_shortName}, %% {_description}, %% {_points}";
    }
}