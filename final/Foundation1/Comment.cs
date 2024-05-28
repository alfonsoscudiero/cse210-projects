using System;

public class Comment 
{
    public string _personName { get; set;}
    public string _text { get; set; }

    // Constructor Method
    public Comment(string personName, string text)
    {
        _personName = personName;
        _text = text;
    }
    
    // Method to display commenter's name and text
    public void Display()
    {
        Console.WriteLine($"'{_text}' by {_personName}.");
    }
}