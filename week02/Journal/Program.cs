using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
      Journal journal = new Journal();
      //create a new list of prompt that the user will respond to 
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
        // use the random function to randomly select prompt to display to the user
        Random random = new Random();
        bool programRunning = true;
        // loop that keep running as long as the condition is true
        while (programRunning)
        {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. count Entries");
            Console.WriteLine("6. Quit");
             

            Console.Write("Choose from the options above ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Entry newEntry = new Entry();
                //This input is used to ask the user how about their mood before the write each entries
                Console.Write("How are you feeling today? ");
                newEntry._mood = Console.ReadLine();

                int index = random.Next(prompts.Count);
                string prompt = prompts[index];

                Console.WriteLine(prompt);
                



                Console.Write("Write about it: ");
                newEntry._entryText = Console.ReadLine();
                newEntry._promptText = prompt;

                newEntry._date = DateTime.Now.ToLongDateString();
                journal.AddEntry(newEntry);
            } 
            else if (choice == "2")
            {
                journal.DisplayAll();
            }

            else if (choice == "3")
            {
                Console.Write("Enter filename: ");
                string fileload = Console.ReadLine();

                journal.saveToFile(fileload);
            }
            else if (choice == "4")
            {
              Console.Write("Enter filename: ");
                string fileload = Console.ReadLine();

                journal.loadFromFile(fileload);  
            }
            //count the number of entries made 
            else if (choice == "5")
            {
                journal.countEntries();
            }

            else if (choice == "6")
            {
                programRunning = false;
            }

            Console.WriteLine();
        }  
    }
}