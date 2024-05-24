using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    // List to store goals
    private List<Goal> _goals;
    
    // Player's score
    private int _score;
    
    // Constructor to initiate the app
    public GoalManager()
    {
        _goals = new List<Goal>(); // Initialize the list of goals
        _score = 0; // Initialize the player's score to 0

    }
    // Method to start the GoalManager app
    public void Start()
    {
        while (true)
        {
            Console.WriteLine();
            DisplayPlayerInfo();
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit\n");
            Console.Write("Select a choice from the menu: ");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                if (choice == 1)
                {
                    ListGoalNames();
                    CreateGoal();
                }
                else if (choice == 2)
                {
                    ListGoalDetails();
                }
                else if (choice == 3)
                {
                    SaveGoals();
                }
                else if (choice == 4)
                {
                    LoadGoals();
                }
                else if (choice == 5)
                {
                    RecordEvent();
                }
                else if (choice == 6)
                {
                    Console.WriteLine("Exiting the program");
                    break; // Exit the loop and terminate the program
                }
                else
                {
                    Console.WriteLine("Invalid choice. Try again.");
                    Console.Clear();
                    return;
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine("You have {_score} points.");
    }
    public void ListGoalNames()
    {
     Console.WriteLine("\nThe types of goals are:");
     Console.WriteLine("1. Simple Goal");
     Console.WriteLine("2. Eternal Goal");
     Console.WriteLine("3. Checklist Goal");
    }   
    public void ListGoalDetails()
    {}
    public void CreateGoal()
    {
        Console.Write("Which type of goal would you like to create? ");

        int goalType;
        if (int.TryParse(Console.ReadLine(), out goalType))
        {
            Console.Write("\nWhat is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();

            Goal newGoal = null;

            if (goalType == 1)
            {
                newGoal = new SimpleGoal(name, description, points);
            }   

            else if (goalType == 2)
            {
                newGoal = new EternalGoal(name, description, points);
            }

            // else if (goalType == 3)
            // {
            //     newGoal = new ChecklistGoal(name, description, points);
            // }
            else
            {
                Console.WriteLine("Invalid goal");
                return;
            }

            _goals.Add(newGoal); // Add the created goal to the list of goal
            Console.WriteLine("Goal created successfully");
        }
        else
        {
            Console.WriteLine("Invalid input");
            Start();
        }
    }
    public void RecordEvent()
    {}
    public void SaveGoals()
    {}
    public void LoadGoals()
    {}
}