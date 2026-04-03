using System;
 public class ReflectingActivity : Activity
 {
    private List<string> _prompts;
    private List<string> _question;

    public ReflectingActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
       _prompts = new List<string>()
       {
         "Think of a time when you stood up for someone else.",
         "Think of a time when you did something really difficult.",
         "Think of a time when you helped someone in need.",
         "Think of a time when you did something truly selfless"
       };
       _question = new  List<string>()
       {
         "Why was this experience meaningful to you?",
         "Have you ever done anything like this before?",
         "How did you get started?",
         "How did you feel when it was complete?",
         "What made this time different than other times when you were not as successful?",
         "What is your favorite thing about this experience?",
         "What could you learn from this experience that applies to other situations?",
         "What did you learn about yourself through this experience?",
         "How can you keep this experience in mind in the future?"
       };
    }

    public void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();
        ShowCountDown(6);
        DisplayQuestion();
        DisplayEndingMessage();


    }

    public string GetRandomPrompt()
    {
       Random random = new Random();
       int index = random.Next(0, _prompts.Count);
       return _prompts[index]; 
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
       int index = random.Next(0, _question.Count);
       return _question[index]; 
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }

    public void DisplayQuestion()
    {
        DateTime startTime = DateTime.Now;
        while ((DateTime.Now -startTime).TotalSeconds <Duration)
      {
        Console.Write(GetRandomQuestion());
        ShowSpinner(4);   
      }
    }
 }