using System;
using System.Collections.Generic;
using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    
    // Define the filename as a class-level field
    public string filename = "my_journal.csv";
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries in the journal.");
            return;
        }
        
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"Date: {entry._date} - Prompt: {entry._promptText}");
            Console.WriteLine($"{entry._entryText}");
            Console.WriteLine();
        }
    }
    public void SaveToFile(string file)
    {
        // Class used for writing text to a file
        using (StreamWriter outputFile = new StreamWriter (file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}#{entry._promptText}#{entry._entryText}");
            }
        }
        Console.WriteLine("Entries saved to file successfully.");
        Console.WriteLine();
    }
    public void LoadFromFile()
    {
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            // Splits each line into parts based on the separator (#) 
            // and stores them in an array
            string[] parts = line.Split("#");

            // Extract the data from the parts array
            string date = parts[0];
            string prompt = parts[1];
            string entry = parts[2];

            // Create a new instance of the Entry class
            // and set the properties of the 'newEntry' object
            Entry newEntry = new Entry();
            newEntry._date = date;
            newEntry._promptText = prompt;
            newEntry._entryText = entry;

            // Add the 'newEntry' object to the '_entries' list
           _entries.Add(newEntry);
        }
        // return filename;
        Console.WriteLine("File loaded successfully.");    
        Console.WriteLine();
    }
}