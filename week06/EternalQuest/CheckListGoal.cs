using System;

public class CheckListGoal : Goal
{
    private  int _amountCompleted;
    private string _target;
    private int _bonus;

    public CheckListGoal(string name, string description, string points, string target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }
    public void RecordEvent()
    {
        
    }
    public bool IsComplete()
    {
        
    }
    public string GetStringRepresentation()
    {
        
    }
}