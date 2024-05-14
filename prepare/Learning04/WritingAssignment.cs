using System;

public class WritingAssignment : Assignment
{
    private string _title = "";
    // calling the parent constructor using "base"

    // public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    // {
    //     _title = title;
    // }
    // Getter and Setter
    public string GetTitle()
    {
        return _title;
    }
    public void SetTitle(string title)
    {
        _title = title;
    }

    // Method to return a summary of the assignment
    public string GetWritingInformation()
    {
        return $"{_title} by {_studentName}"; 
    }
}