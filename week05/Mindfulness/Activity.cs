using System;
using System.Threading;
public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    protected int Duration 
    {
        get {return _duration;}
    }

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine(_description);

        Console.Write("How many seconds would you like the activity to last? ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Get ready to begin...");
        ShowSpinner(3);
        
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Great job,  Well Done!!");
        ShowSpinner(3);
        Console.WriteLine($"You have completed {_duration} seconds of the {_name}.");
    }

    public void ShowSpinner(int seconds)
    {
        string [] spinners = {"|", "/", "-", "\\"};
        int index = 0;
        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < seconds)
        {
            Console.Write(spinners[index % spinners.Length]);
            Thread.Sleep(200);
            Console.Write("\b \b"); 
            index++;
        }  
    }

    public void ShowCountDown(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);
        Thread.Sleep(3000);

        DateTime currentTime = DateTime.Now;
        if (currentTime <endTime)
        {
            Console.WriteLine("Done");
        }

        

    }
}