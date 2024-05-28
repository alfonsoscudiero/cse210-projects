using System;
using System.Collections.Generic;

public class Video
{
    public string _titleName { get; set; }
    public string _authorName { get; set; }
    public int _length { get; set; }
    private List<Comment> _comments;

    // Constructor Method
    public Video(string titleName, string authorName, int length)
    {
        _titleName = titleName;
        _authorName = authorName;
        _length = length;
        _comments = new List<Comment>();
    }

    // Method to add a comment to the video
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Method to count number of comments
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    // Method to display the video's info
    public void DisplayInfo()
    {
        Console.WriteLine();
        Console.WriteLine($"Title: '{_titleName}'");
        Console.WriteLine($"Author: {_authorName}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Number of comments: {GetNumberOfComments()}");
        Console.WriteLine("Comments:");
        foreach (var line in _comments)
        {
            line.Display();
        }
    }
}

