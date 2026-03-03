using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
    string toPlay = "yes";
    while (toPlay.ToLower() == "yes")
    { 
        Random randomNumber = new Random();
        int magicNumber = randomNumber.Next(1, 100);
        int userGuess = 0;
        int guessCount = 0;

        Console.WriteLine("I have chosen a number between 1 and 100.");
    
        while (userGuess != magicNumber)
        { 
            Console.Write("What is your guess? ");
            userGuess = int.Parse(Console.ReadLine());
            guessCount++;
            if (userGuess == magicNumber)
                {
                Console.WriteLine("you guess it");   
                }
            else if (userGuess<= magicNumber)
                {
                    Console.WriteLine("guess higher");
                }
            else
                {
                    Console.WriteLine("lower");
                }
        
    }
        Console.WriteLine($"You used {guessCount} guesses!");
        Console.Write("Do you still want to play (yes/no)");
        toPlay = Console.ReadLine();
    }

    Console.WriteLine("Thanks for playing!");
    }
    
          
    
}