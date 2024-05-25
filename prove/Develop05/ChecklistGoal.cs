using System;
using System.Reflection.Metadata;

public class ChecklistGoal : Goal
{
    private int _target;
    private int _bonus;
    public int _amountCompleted { get; set;}
    public bool _isComplete;

    // Call constructor from base
    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0; // Initialize the amount completed
        _isComplete = false;
    }
    // Method to Record an event (Is eternal and never completes)
    public override int RecordEvent()
    {
        _amountCompleted++; // Increment the count of completed checklist items
        int pointsEarned = int.Parse(_points);

        if (_amountCompleted == _target)
        {
            _isComplete = true; // Mark the goal as complete
            return int.Parse(_points) + _bonus; // Return points plus bonus points
        }
        else if (_amountCompleted > _target)
        {
            return pointsEarned; // Add regular points if target is exceeded
        }
        return pointsEarned; // Return points for this checklist item
    }

    // Method to check if the goal is complete
    public override bool IsComplete()
    {
        return _isComplete;
    }   

    // Method to get the detail string for the goal
    public override string GetDetailString()
    {
        string status = IsComplete() ? "[X]" : "[ ]"; // Ternary operator
        return $"{status} {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }
    
    // Method to get a string of the goal for saving to a text file
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal, {_shortName}, {_description}, {_points}, {_bonus}, {_target}, {_amountCompleted}";
    }
}