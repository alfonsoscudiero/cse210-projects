using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of activities
        var activities = new List<Activity>
        {
            new Running(new DateTime(2024, 05, 04), 280, 26.2),
            new Cycling(new DateTime(2024, 06, 9), 720, 28.0),
            new Swimming(new DateTime(2024, 07, 24), 45, 50),
        };

        Console.WriteLine();
        // Iterate through the list and print the summary
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
        Console.WriteLine();
    }
}