using System;

public abstract class Goal
{
    // Attributes common to all goals
    protected string _shortName;
    protected string _description;
    protected string _points;

    // Constructor to initialize the common attributes; must be implemented by derived classes
    public Goal(string name, string description, string points)
    {        
        _shortName = name;
        _description = description;
        _points = points;
    }
    // Getter and Setters methods
    public string GetName()
    {
        return _shortName;
    }
    public void SetName(string shortName)
    {
        _shortName = shortName;
    }
    public string GetDescription()
    {
        return _description;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public string GetPoints()
    {
        return _points;
    }
    public void SetPoints(string points)
    {
        _points = points;
    }
    
    // Abstract method to record an event
    public abstract int RecordEvent();

    // Abstract method to check if the goal is completed
    public abstract bool IsComplete();

    // Virtual method to get details string; can be overridden by derived classes
    public virtual string GetDetailString()
    {
        string status = IsComplete() ? "[X]" : "[ ]"; // Ternary operator
        return $"{status} {_shortName} ({_description})";
    }
    
    // Abstract method to provide all the details of a goal to save to a file
    public abstract string GetStringRepresentation();
}