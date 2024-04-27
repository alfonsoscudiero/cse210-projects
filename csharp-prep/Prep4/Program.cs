using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();

        int userInput = -1;
        while (userInput != 0)
        {
            Console.Write("Enter number: ");
            userInput = int.Parse(Console.ReadLine());
            numbers.Add(userInput);
        }
        
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        Console.WriteLine($"The sum is: {sum}");
        int listLength = numbers.Count -1;
        double average = (double)sum / (double)listLength;
        Console.WriteLine($"The average is: {average}");

        int maxNum = 0;
        foreach (int num in numbers)
        {
            if (num > maxNum)
            {
                maxNum = num;
            }
        }
        Console.WriteLine($"The largest number is: {maxNum}");
    }
}