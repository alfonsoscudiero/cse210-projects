using System;

public class BreathingActivity : Activity
{
    // Constructor
    public BreathingActivity(string name, string description) : base(name, description)
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
        int duration;
        do
        {
            Console.Write("How long, in seconds, would you like for your session? ");
        }
        // test the parsing operation. If it fails (the expression 
        // evaluates to 'true'), the loop continues to prompt the user
        while (!int.TryParse(Console.ReadLine(), out duration) || duration <= 0);

        SetDuration(duration);

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
        ShowSpinner(3);
    }
}