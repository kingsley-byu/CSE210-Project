using System;

public class CheckListGoal : Goal
{
    private  int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public CheckListGoal(string name, string description, int points, int target, int bonus, int amountCompleted) : base(name, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }
    public override void RecordEvent()
    {
        _amountCompleted += 1;
        
    }

    public int GetBonus()
    {
        return _bonus;
    }
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        string completed = IsComplete() ? "[X]" : "[ ]";
        return $"{completed} {GetName()} ({GetDescription()}) -- Completed {_amountCompleted}/{_target} times";
    }
    public override string GetStringRepresentation()
    {
       return $"CheckListGoal,{GetName()},{GetDescription()},{GetPoints()},{_target},{_bonus},{_amountCompleted}";   
    }
}