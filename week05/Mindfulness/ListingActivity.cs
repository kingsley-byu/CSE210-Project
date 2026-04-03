using System;
public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    
    {
        _count = 0;
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void Run()
    {
       DisplayStartingMessage();
       Console.WriteLine(GetRandomPrompt());
       Console.WriteLine("You have a few seconds to  seconds to think about the prompt...");
       Console.WriteLine("Start listing items! ");
       ShowCountDown(5);
       GetListFromUser();
       Console.WriteLine($"You listed {_count} items");
       DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
         Random random = new Random();
        int index = random.Next(0, _prompts.Count);
        return _prompts[index];
    }

    public List<string> GetListFromUser()
    {
        List<string> userInput = new List<string>();
        DateTime startTime = DateTime.Now;
        while ((DateTime.Now -startTime).TotalSeconds <Duration)
        {
            Console.Write("List item: ");
            string input = Console.ReadLine();
            userInput.Add(input);

            _count++;    
        }
        return userInput;
    }
}