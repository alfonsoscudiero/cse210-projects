using System;

public class Reception : Event
{
    private string _rsvpEmail;

    // Constructor
    public Reception(string title, string description, DateTime date, string time, Address address, string rsvpEmail) : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    // Override the Get Full Details of the event
    public override string GetFullDetails()
    {
        return GetStandardDetails() + $"\nEvent type: Reception\nEmail: {_rsvpEmail}";
    }
}