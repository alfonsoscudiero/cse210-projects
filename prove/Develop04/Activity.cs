using System;
using System.Collections.Generic;
using System.Threading;

public class Activity
{
    // Private fields
    protected string _name;
    protected string _description;
    protected int _duration;
    // Constructor
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    public int GetDuration()
    {
        return _duration;
    }
    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    // Method to display starting message
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(4);
    }
    // Method to display ending message
    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!!");
        ShowSpinner(3);
    }
    // Method to display a spinner animation
    public void ShowSpinner(int seconds)
    {
        var animationString = new List<string>()
        {
            "|",
            "/",
            "-",
            "\\",
            "|",
            "/",
            "-",
            "\\"
        };
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationString[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            if (i >= animationString.Count)
            {
                i = 0;
            }
        }
    }
    // Method to display countdown
    public void CountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000); // Wait for 1 seconds
            Console.Write("\b \b"); // Remove the character
        }
    }
}