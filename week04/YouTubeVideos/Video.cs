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

    public int GetNumberOfComments()
    {
        return _comment.Count;

    }

    public void Display()
    {
        Console.WriteLine("Title | Author | Video length");
        Console.WriteLine($"{_title} | {_author} | {_length} seconds");
        Console.WriteLine($"Number of comments: {{GetNumberOfComments}}")
        Console.WriteLine("Comments: ");
        foreach (Comment comment in _comment)
        {
            comment.Display();
        }
    }
}