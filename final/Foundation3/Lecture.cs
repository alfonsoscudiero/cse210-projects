using System;

public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    // Constructor
    public Lecture(string title, string description, DateTime date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    // Override the Get Full Details of the event
    public override string GetFullDetails()
    {
        return GetStandardDetails() + $"\nEvent type: Lecture\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }
}