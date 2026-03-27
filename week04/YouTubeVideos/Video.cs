using System;
using System.Collections.Generic;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comment = new List<Comment>();

    public Video(string title,  string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(Comment comment)
    {
       _comment.Add(comment); 
    }

    public int GetNumberOfComment()
    {
        return _comment.Count;

    }

    public void Display()
    {
        Console.WriteLine("Title | Author | Length of comment");
        Console.WriteLine($"{_title} | {_author} | {_length}");
        
    }
}