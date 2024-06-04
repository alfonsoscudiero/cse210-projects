using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Springville City", "NC", "84123");
        Address address2 = new Address("789 Circle Rd", "Bountiful", "UT", "81258");

        Lecture lecture1 = new Lecture("Future of AI", "Discussion on AI trends", new DateTime(2024, 7, 5), "6:00 PM", address1, "Bill Gates", 100);
        Lecture lecture2 = new Lecture("Continuing Education InspirED", "A talk on the latest int tech education", new DateTime(2024, 6, 17), "11:30 AM", address2, "Joseph Kerry", 50);

        Reception reception1 = new Reception("Wedding Reception", "Celebration of Marriage", new DateTime(2024, 5, 25), "7:00 PM", address2, "rsvp@messenger.com");
        Reception reception2 = new Reception("Company Gala", "Annual company gathering", new DateTime(2024, 7, 24), "7:00 PM", address1, "rsvp@icloud.com");

        OutdoorGathering outdoor1 = new OutdoorGathering("Musical Festival", "Outdoor music event", new DateTime(2024, 6, 24), "5:00 PM", address1, "Sunny");
        OutdoorGathering outdoor2 = new OutdoorGathering("Community Picnic", "Neighborhood picnic", new DateTime (2024, 7, 4), "11:00 AM", address2, "Partly Cloudy");

        var events = new List<Event>
        {
            lecture1,
            lecture2,
            reception1,
            reception2,
            outdoor1,
            outdoor2,
        };

        foreach (var ev in events)
        {
            Console.WriteLine("\nStandard Details:");
            Console.WriteLine(ev.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine("Full Details:");
            Console.WriteLine(ev.GetFullDetails());
            Console.WriteLine();
            Console.WriteLine("Short Description:");
            Console.WriteLine(ev.GetShortDescription());
            Console.WriteLine();
            Console.WriteLine("============================");
        }
    }
}