using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    // Constructor
    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<string>
        {
            "-- Who are people that you appreciate? --",
            "-- What are personal strengths of yours? --",
            "-- Who are people that you have helped this week? --",
            "-- When have you felt the Holy Ghost this month? --",
            "-- Who are some of your personal heroes? --",
        };
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

        // Display a random prompt and instruct the user
        Console.WriteLine("\nList as many responses you can to the following prompt:");
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.Write("You may begin in: ");
        CountDown(5);
        Console.WriteLine();

        // Collect user responses
        List<string> userList = GetListFromUser();

        // Display the number of items listed
        Console.WriteLine($"You listed {userList.Count} items!");

        // Display Ending Message
        DisplayEndingMessage();
        Console.WriteLine($"\nYou have completed another {GetDuration()} seconds of the {_name}.");
        ShowSpinner(4);
    }

    // Method to get a random prompt
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    // Method to get list from user
    public List<string> GetListFromUser()
    {
       // Initialize an empty List<string> to store user responses 
       List<string> userList = new List<string>();

       // Calculate the end time based on the duration
       DateTime startTime = DateTime.Now;
       DateTime endTime = startTime.AddSeconds(GetDuration());

       while (DateTime.Now < endTime) // User input until the end time is reached
       {
        Console.Write("> ");
        string item = Console.ReadLine();
        if (!string.IsNullOrEmpty(item))
        {
            userList.Add(item);
        }
       }
        return userList;
    }
}