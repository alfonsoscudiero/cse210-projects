using System;

public class MathAssignment : Assignment
{
    private string _textbookSection = "";
    private string _problems = "";
    // Getter and Setters
    public string GetSection()
    {
        return _textbookSection;
    }
    public void SetSection(string section)
    {
        _textbookSection = section;
    }
    public string GetProblems()
    {
        return _problems;
    }
    public void SetProblems(string problems)
    {
        _problems = problems;
    }
    // Method to display the Math homework
    public string GetHomeworkList()
    {
        return $"Section: {_textbookSection} - Problems: {_problems}";
    }
}