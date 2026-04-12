using System;
public class ActivityMenu 
{

    /* This class create a private method which display the menu of the activity to the user , it allow user to make a choice 
    on which activity to select. and is called in the main program to  display the menu to the user*/
    private void DisplayMenu()
    {
        Console.WriteLine("Welcome to the Mindfulness program!");
        Console.WriteLine("Please choose an activity: ");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflecting Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Visualization Activity");
        Console.WriteLine("5. Quit");
    }
    public void Run()
    {
        bool running = true;
        while (running)
        {
            /* This create  a loop consisting of different cases and create an object for the 3 (three) activity 
            break when the activity finishes and display the menu again for the user to select*/
            DisplayMenu();
            Console.Write("Select a choice: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
                break;

                case "2":
                ReflectingActivity reflection = new ReflectingActivity();
                reflection.Run();
                break;

                case "3":
                ListingActivity listing = new ListingActivity();
                listing.Run();
                break;
                case "4":
                VisualizationActivity visual = new VisualizationActivity();
                visual.Run();
                break;
                case "5":
                running = false;
                break;
                default:
                Console.WriteLine("Invalid choice, please try again.");
                break;

                
            }
            
        }
    }
}