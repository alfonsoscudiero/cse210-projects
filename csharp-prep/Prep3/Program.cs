using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number?: ");
        // string magicNumber = Console.ReadLine();
        // int number = int.Parse(magicNumber);

        // Part 3, use a random number
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,101);

        int guess = 0;

        while (guess != number)
        {
            Console.Write("What is your guess?: ");
            guess = int.Parse(Console.ReadLine());

            if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}