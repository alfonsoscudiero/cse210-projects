using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome(); // Call the DisplayWelcome method

        string userName = PromptUserName();
        int favNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(favNumber);
        DisplayResult(userName, squaredNumber);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name; // Add a return statement to return the name
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number; // Add a return statement to return the number
    }
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square; // Add a return statement to return the square
    }
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }

}