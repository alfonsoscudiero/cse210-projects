using System;

public class OutdoorGathering : Event
{
    private string _weatherForecast;

    // Constructor
    public OutdoorGathering(string title, string description, DateTime date, string time, Address address, string weatherForecast) : base(title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }

    // Override the Get Full Details of the event
    public override string GetFullDetails()
    {
        return GetStandardDetails() + $"\nEvent type: Outdoor gathering\nWeather: {_weatherForecast}";
    }
}