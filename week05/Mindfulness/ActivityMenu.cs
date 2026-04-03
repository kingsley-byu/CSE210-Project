using System;
public class ActivityMenu
{
    private void DisplayMenu()
    {
        Console.WriteLine("Welcome to the Mindfulness program!");
        Console.WriteLine("Please choose an activity: ");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflecting Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Quit");
    }
    public void Run()
    {
        bool running = true;
        while (running)
        {
            DisplayMenu();
            Console.Write("Select a choice");
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
                running = false;
                break;
                default:
                Console.WriteLine("Invalid choice, please try again.");
                break;
            }
        }
    }
}