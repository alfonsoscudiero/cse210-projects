using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;

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
                    CreateGoal();
                }
                else if (choice == 2)
                {
                    ListGoalDetails();
                }
                else if (choice == 3)
                {
                    SaveGoals("goals.txt");
                }
                else if (choice == 4)
                {
                    LoadGoals("goals.txt");
                }
                else if (choice == 5)
                {
                    ListGoalNames(); // Display the list of goal names for user to choose from
                    RecordEvent();
                }
                else if (choice == 6)
                {
                    Console.WriteLine("Exiting the program");
                    break; // Exit the loop and terminate the program
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }

    // Method to display player's current score
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    // Method to list the names of each goal
    public void ListGoalNames()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }
    }   
   
    // Method to list the details and properties of each goal
    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailString()}");
        }
    }
   
    // Method to create a new goal
    public void CreateGoal()
    {
        Console.WriteLine("\nThe types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");

        int goalType;
        if (int.TryParse(Console.ReadLine(), out goalType))
        {
            Goal newGoal = null;

            Console.Write("\nWhat is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();

            if (goalType == 1)
            {
                newGoal = new SimpleGoal(name, description, points);
            }   

            else if (goalType == 2)
            {
                newGoal = new EternalGoal(name, description, points);
            }

            else if (goalType == 3)
            {
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());

                newGoal = new ChecklistGoal(name, description, points, target, bonus);
            }
            else
            {
                Console.WriteLine("Invalid goal type");
                return;
            }

            _goals.Add(newGoal); // Add the created goal to the list of goal
            Console.WriteLine("Goal created successfully");
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
    
    // Method to record an event for a specific goal
    public void RecordEvent()
    {
        Console.Write("Which goal did you accomplish? ");
        
        int goalIndex;
        if (int.TryParse(Console.ReadLine(), out goalIndex) && goalIndex >= 1 && goalIndex <= _goals.Count)
        {
            Goal goal = _goals[goalIndex - 1];
            int pointsEarned = goal.RecordEvent(); // Record the event and get points
            _score += pointsEarned; // Add points to the users's score

            Console.WriteLine($"Congratulations! You have earned {pointsEarned} points");
            Console.WriteLine($"You now have {_score}");

            if (goal is SimpleGoal && goal.IsComplete())
            {
                Console.WriteLine("You have completed the goal");
            }
            else if (goal is ChecklistGoal checklistGoal && checklistGoal.IsComplete())
            {
                Console.WriteLine("Kudos! You have completed the Checklist Goal and earned bonus points!");
                DisplayStars(); 
            }
        else
        {
            Console.WriteLine("Invalid goal selection");
        }
        }
    }
    
    // Method to display stars
    private void DisplayStars()
    {
        Console.WriteLine("\n*** TERRIFIC! ***");
        Console.WriteLine("*** YOU'VE COMPLETED ***");
        Console.WriteLine("*** THE CHECKLIST GOAL ***");
        Console.WriteLine("*************************");
    }

    // Method to save the list of goals to a file
    public void SaveGoals(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine(_score); // Save the player's score
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved to file");
    }   
    
    // Method to load the list of a goals from a file
    public void LoadGoals(string filePath)
    {
        _goals.Clear(); // Clear existing goal before loading from file

        string[] lines = File.ReadAllLines(filePath);

        if (lines.Length > 0)
        {
            _score = int.Parse(lines[0]); // Read the player's score from the first line

            // Process each subsequent line
            for (int i = 1; i < lines.Length; i++)
            {
                // Split each line by the '%%' separator
                string[] parts = lines[i].Split(',');

                // Extract the goal type and properties
                string goalType = parts[0].Trim();
                string name = parts[1].Trim();
                string description = parts[2].Trim();
                string points = parts[3].Trim();

                Goal newGoal = null;

                // Create an instance accordingly the type of goal
                if (goalType == "SimpleGoal")
                {
                    bool isComplete = bool.Parse(parts[4].Trim());
                    newGoal = new SimpleGoal(name, description, points); 
                    (newGoal as SimpleGoal).SetComplete(isComplete);
                }
                else if (goalType == "EternalGoal")
                {
                    int totalPointEarned = int.Parse(parts[4].Trim());
                    newGoal = new EternalGoal(name, description, points);
                    (newGoal as EternalGoal).SetTotalPointsEarned(totalPointEarned);
                }
                else if (goalType == "ChecklistGoal")
                {
                    int bonus = int.Parse(parts[4].Trim());
                    int target = int.Parse(parts[5].Trim());
                    int amountCompleted = int.Parse(parts[6].Trim());
                    newGoal = new ChecklistGoal(name, description, points, target, bonus);
                    (newGoal as ChecklistGoal)._amountCompleted = amountCompleted;
                    (newGoal as ChecklistGoal)._isComplete = amountCompleted >= target;
                }

                // Add created goal to the list of goals
                _goals.Add(newGoal);
            }
            Console.WriteLine("Goals loaded from file");
        }
    }
}