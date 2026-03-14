using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
      Journal journal = new Journal();
      List<string> prompts = new List<string>()
        {
          "Who was the most interesting person I interacted with today?",
          "What was the best part of my day?",
          "How did I see the hand of the Lord in my life today?",
          "What was the strongest emotion I felt today?",
          "If I had one thing I could do over today, what would it be?", 
          "What are you grateful for today?",
            "What was the best part of your day?",
            "Who helped you today?",
            "What did you learn today?" 
        };

        Random random = new Random();
        bool programRunning = true;
        while (programRunning)
        {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit"); 

            Console.Write("Choose from the options above");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                int index = random.Next(prompts.Count);
                string prompt = prompts[index];

                Console.WriteLine(prompt);
                Entry newEntry = new Entry();

                newEntry._promptText = prompt;

                Console.Write("YOUR ANSWER: ");
                newEntry._entryText = Console.ReadLine();
                
            } 
        }  
    }
}