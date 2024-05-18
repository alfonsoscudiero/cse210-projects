using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("\nWelcome to the Mindfulness App!\n");

        bool running = true;
        while (running)
        {

            // Display the Menu
            DisplayMenu();

            // Read user input for menu choice
            string choice = Console.ReadLine();

            // Process user choice
            if (choice == "1")
            {
                // Create the BreathingActivity object
                BreathingActivity breathingActivity = new BreathingActivity();
                
                // Run the breathing activity
                breathingActivity.Run();

                // Clear the console and display the menu again
                Console.Clear();
                continue;  
            }

            else if (choice == "2")
            {
                // Crate a ReflectingActivity
                ReflectingActivity reflectingActivity = new ReflectingActivity();

                // Run the reflecting activity
                reflectingActivity.Run();

                // Clear the console and display the menu again
                Console.Clear();
                continue;
            }

            else if (choice == "3")
            {
                // Create a ListingActivity object
                ListingActivity listingActivity = new ListingActivity();

                // Run the listing activity
                listingActivity.Run();

                // Clear the console and display the menu again
                Console.Clear();
                continue;

            }



            else if (choice == "4")
            {
                // Exit the program
                Console.WriteLine("\nExiting the app. Visit us again!\n");
                running = false;
            }   

            else
            {
                // Invalid choice
                Console.WriteLine("Invalid choice. Please select a valid choice from the menu.");
                Thread.Sleep(2000);
                Console.Clear();
                continue;  // 
            }
        }
    } 
    static void DisplayMenu()
    {
        // Display the Menu options
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Start breathing activity");
        Console.WriteLine("  2. Start reflecting activity");
        Console.WriteLine("  3. Start listing activity");
        Console.WriteLine("  4. Quit");
        Console.Write("Select a choice from the menu (1, 2, 3, 4): ");
    }
}