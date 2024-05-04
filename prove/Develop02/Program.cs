using System;


class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();

        Console.WriteLine("Welcome to My Journal App!");

        bool quit = false;
        while (!quit)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1")
            {
                PromptGenerator promptGenerator = new PromptGenerator();
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"Prompt: {prompt}");
                Console.Write("> ");
                string newRecord = Console.ReadLine();

                // Create a new entry and add it to the journal
                Entry anEntry = new Entry();
                anEntry._date = DateTime.Now.ToShortDateString();
                anEntry._promptText = prompt;
                anEntry._entryText = newRecord;
                theJournal.AddEntry(anEntry);
            }
            else if (choice == "2")
            {
                theJournal.DisplayAll();
            }
            else if (choice == "3")
            {
                theJournal.LoadFromFile();
            }
            else if (choice == "4")
            {
                theJournal.SaveToFile(theJournal.filename);
            }
            else if (choice == "5")
            {
                quit = true;
                Console.WriteLine("Exiting the program.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Invalid choice. Try again.");
            }
        }
    }
}