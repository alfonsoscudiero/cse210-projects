using System;

class Program
{
    static void Main(string[] args)
    {
        // Display the welcome message
        Console.WriteLine();
        Console.WriteLine("Welcome to the Scripture Memorizer App!");
        Console.WriteLine();

        // Define book, chapter, verse, and scripture text
        string book = "Proverbs";
        int chapter = 3;
        int startVerse = 5;
        int endVerse = 6;
        string scriptureText = "Trust in the LORD with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.";

        // Create a reference
        Reference reference = new Reference(book, chapter, startVerse, endVerse);

        // Create a scripture object
        Scripture scripture = new Scripture(reference, scriptureText);

        // Display the full scripture
        Console.WriteLine(scripture.GetDisplayText());

        // Prompt the user to choose the difficulty level
        Console.WriteLine("\nChoose the difficulty level:");
        Console.WriteLine("1. Easy");
        Console.WriteLine("2. Difficult");
        Console.Write("Enter your choice (1 or 2): ");

        // Read the user's choice
        int choice;
        if (!int.TryParse(Console.ReadLine(), out choice) || (choice != 1 && choice != 2))
        {
            Console.WriteLine("Invalid choice. Exiting the program.");
            return;
        }

        // Determine the number of words to hide based on the user's choice
        int numberToHide = (choice == 1) ? 3 : 6;

        // Hide words based on the chosen difficulty level
        scripture.HideRandomWords(numberToHide);

        // Clear the console
        Console.Clear();

        // Display the updated scripture with underscores
        Console.WriteLine(scripture.GetDisplayText());

        // Wait for the user to press Enter to continue or type 'quit' to exit
        while (true)
        {
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
            var input = Console.ReadLine().Trim().ToLower();

            if (input == "quit")
            {
                Console.WriteLine("Exiting the program...");
                return;
            }

            // Hide words based on the chosen difficulty level
            scripture.HideRandomWords(numberToHide);

            // Clear the console
            Console.Clear();

            // Display the updated scripture with underscores
            Console.WriteLine(scripture.GetDisplayText());

            // Check if all words are replaced by underscores
            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("\nThank you for using the Scripture Memorizer App. Please try again!");
                return;
            }
        }
    }
}
