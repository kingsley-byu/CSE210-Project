using System;
using System.Collection.Generic;

public class Video
{
    private string _title;
    private string author;
    private int _length;
    private List<Comment> _comment = new List<Comment>

    public Video(string title,  string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(Comment comment)
    {
        
    }

    public int GetNumberOfComment()
    {

    }

    public void Display()
    {

    }
}