using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
public class GoalManager 
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }
    

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Your score is: {_score}");
    }
    public void ListGoalNames()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetName());
        }
    }
    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("1. SimpleGoal");
        Console.WriteLine("2. CheckListGoal");
        Console.WriteLine("3. EternalGoal");

        Console.Write("Enter a goal type: ");
        string choice = Console.ReadLine();

        Console.Write("Enter a goal name: ");
        string goalName = Console.ReadLine();

        Console.Write("Enter goal description: ");
        string goalDescription = Console.ReadLine();
        Console.WriteLine("Enter point for this goal: ");
        int  goalPoint = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
            SimpleGoal simple = new SimpleGoal(goalName, goalDescription, goalPoint);
            _goals.Add(simple);
            break;

            case "2":
            Console.Write("Enter goal target: ");
            int goalTarget = int.Parse(Console.ReadLine());
            Console.Write("Enter goal Bonus: ");
            int goalBonus= int.Parse(Console.ReadLine());
            
            CheckListGoal checkList = new CheckListGoal(goalName, goalDescription, goalPoint, goalTarget, goalBonus);
            _goals.Add(checkList);
            break;
            case "3":
            EternalGoal eternal = new EternalGoal(goalName, goalDescription, goalPoint);
            _goals.Add(eternal);
            break;

            default:
                Console.WriteLine("Invalid choice, please try again.");
                break;
        }
        
    }
    public void RecordEvent()
    {
    Console.WriteLine("Select a goal to record:");
    for (int i = 0; i < _goals.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
    }

    Console.Write("Enter goal number: ");
    int goalIndex = int.Parse(Console.ReadLine()) - 1;

    Goal selectedGoal = _goals[goalIndex];
    selectedGoal.RecordEvent();
    _score += selectedGoal.GetPoints();

    if (selectedGoal is CheckListGoal checkList)
    {
        if (checkList.IsComplete())
        {
            _score += checkList.GetBonus();
            Console.WriteLine($"Congratulations! You completed your checklist goal and earned a bonus of {checkList.GetBonus()} points!");
        }
    }

    Console.WriteLine($"You have earned {selectedGoal.GetPoints()} points!");
    Console.WriteLine($"Your total score is now {_score} points!");
    }
    public void SaveGoals()
    {
        Console.Write("Create a file name");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal  goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
    public void LoadGoals()
    {
        Console.Write("Enter file name:");
        string fileName = Console.ReadLine();
        string [] lines = File.ReadAllLines(fileName);
        _score = int.Parse(lines[0]);
        for (int i=1; i< lines.Length; i++)
        {
            string [] parts = lines[i].Split(",");
            switch (parts[0])
            {
                case "SimpleGoal":
                SimpleGoal simpleGoal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
                _goals.Add(simpleGoal);
                break;

                case "CheckListGoal":
                CheckListGoal checkList = new CheckListGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]),int.Parse(parts[5]), int.Parse(parts[6]));
                _goals.Add(checkList);
                break;

                case "EternalGoal":
                EternalGoal eternalGoal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
                _goals.Add(eternalGoal);
                break; default:
                Console.WriteLine("Invalid choice, please try again.");
                break;
            }
        }
        
    }
    private void DisplayMenu()
    {
        Console.WriteLine("Welcome to Eternal Quest!");
        Console.WriteLine("Please choose an option:");
        Console.WriteLine("1. Create a new goal");
        Console.WriteLine("2. List goal names");
        Console.WriteLine("3. List goal details");
        Console.WriteLine("4. Record an event");
        Console.WriteLine("5. Display player info");
        Console.WriteLine("6. Save goals");
        Console.WriteLine("7. Load goals");
        Console.WriteLine("8. Quit");
    }

    public void Start()
    {
        bool running = true;
        while (running)
        {
          DisplayMenu();
          Console.Write("Select choice: ");
          string choice = Console.ReadLine();
          switch (choice)
            {
                case "1": CreateGoal();
                break;
                case "2": ListGoalNames();
                break;
                case "3": ListGoalDetails();
                break;
                case "4": RecordEvent();
                break;
                case "5": DisplayPlayerInfo();
                break;
                case "6": SaveGoals();
                break;
                case "7": LoadGoals();
                break;
                case "8": running = false;
                break;
                default: 
                Console.WriteLine("invalid entry");
                break;
            }  
        }
    }
}