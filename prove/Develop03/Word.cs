using System;

public class Word
{
    // Private fields
    private string _text;
    private bool _hidden;

    // Constructor
    public Word(string text)
    {
        // 'this._text' refers to the instance
        // variable '_text' of the 'Word' class
        //'text' refers to the parameter 'text' passed to the constructor
        this._text = text;
        _hidden = false; // Initialize as not hidden
    }

    // Method to hide the word
    public void Hide()
    {
        _hidden = true;
    }

    // Method to show the word
    public void Show()
    {
        _hidden = false;
    }

    // Method to check if the word is hidden
    public bool IsHidden()
    {
        return _hidden;   //true (if the word is hidden)
    }

    // Method to get the display text of the word
    public string GetDisplayText()
    {
        if (_hidden)  // If the word is hidden
        {
            return "___";  // Return underscores representing a hidden word
        }
        else  // If the word is not hidden
        {
            return _text;  // Return the actual text of the word
        }
    } 
}
