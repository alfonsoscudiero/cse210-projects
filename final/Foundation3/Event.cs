using System;

public abstract class Event
{   
    private string _title;
    private string _description;
    private DateTime _date;
    private string _time;
    private Address _address;
    private string _eventType;

    // Constructor to initialize the Event object
    public Event(string title, string description, DateTime date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    // Method to get standard details of the event
    public string GetStandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date.ToShortDateString()}\nTime: {_time}\nAddress: {_address.GetFullAddress()}";
    }

    // Abstract Method to force each derived class to provide its specific implementation
    public abstract string GetFullDetails();

    // Method to get short description of the event
    public string GetShortDescription()
    {
        return $"Type: {this.GetType().Name}\nTitle: {_title}\nDate: {_date.ToShortDateString()}";
    }
}