using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?: ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

        string letter = "";

        if (grade >= 90)
        {
            // Console.WriteLine("You got an A");
            letter = "A";
        }
        else if (grade >= 80)
        {
            // Console.WriteLine("You got a B");
            letter = "B";
        }
        else if (grade >= 70)
        {
            // Console.WriteLine("You got a C");
            letter = "C";
        }
        else if (grade >= 60)
        {
            // Console.WriteLine("You got a D");
            letter = "D";
        }
        else
        {
            // Console.WriteLine("You got an F");
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (letter == "D" || letter == "F")
        {
            Console.WriteLine("You failed the course.");            
        }
        else
        {
            Console.WriteLine("You passed the course.");
        }


    }
}