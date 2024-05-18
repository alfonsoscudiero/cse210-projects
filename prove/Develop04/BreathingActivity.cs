using System;

public class BreathingActivity : Activity
{
    // Constructor
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }
    // Method to run the activity
    public void Run()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine(_description);
        Console.WriteLine();

        // Get duration from the user
        GetAndSetDuration();

        // Display Starting Message
        DisplayStartingMessage();

        // Perform the breathing activity
        DateTime startTime = DateTime.Now;  // Retrieve the current time
        DateTime endTime = startTime.AddSeconds(GetDuration());  // Calculate the end time
        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in...");
            CountDown(3);
            Console.Write("\nNow breathe out...");
            CountDown(3);
            Console.WriteLine();
        }

        // Display Ending Message
        DisplayEndingMessage();
        Console.WriteLine($"\nYou have completed another {GetDuration()} seconds of the {_name}.");
        ShowSpinner(4);
    }
}