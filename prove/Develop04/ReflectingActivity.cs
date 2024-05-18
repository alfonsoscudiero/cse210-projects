using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    // Constructor
    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompts = new List<string>
        {
            "-- Think of a time when you stood up for someone else. --",
            "-- Think of a time when you did something really difficult. --",
            "-- Think of a time when you helped someone in need. --",
            "-- Think of a time when you did something truly selfless. --"
        };
        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }
    // Method to run the activity
    public void Run()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine(_description);
        Console.WriteLine();

        // Get Duration from the user
        GetAndSetDuration();

        // Display Starting Message
        DisplayStartingMessage();

        // Display a random prompt 
        DisplayPrompt();

        // Display random questions
        DisplayQuestions();

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
        string prompt = _prompts[index];
        _prompts.RemoveAt(index);
        return prompt;
    }
    // Method to get a random question
    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        string question = _questions[index];
        _questions.RemoveAt(index); // Remove the random question from the list during the same session
        return question;
    }
    public void DisplayPrompt()
    {
        Console.WriteLine("\nConsider the following prompt:\n");
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine(); // Code here will be run after they press enter
    }
    public void DisplayQuestions()
    {
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        
        // Provide some time for the user to prepare
        Console.Write("You may begin in: ");
        CountDown(5);
        Console.Clear(); // Clear the console before displaying the questions

        // Calculate the briefly pause after each question
        int halfDuration = GetDuration() / 2;

        // Display the fist question and pause briefly
        Console.Write($"> {GetRandomQuestion()} ");
        ShowSpinner(halfDuration);

        // Display the second question and pause briefly
        Console.Write($"\n> {GetRandomQuestion()} ");
        ShowSpinner(halfDuration);
        Console.WriteLine();
    }
}