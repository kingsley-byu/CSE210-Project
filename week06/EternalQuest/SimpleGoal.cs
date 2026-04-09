using System;

public class SimpleGoal : Goal
{
    private  bool _isComplete = false;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        
    }
    public override void RecordEvent()
    {
        _isComplete = true;
    }
    
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public string GetStringRepresentation()
    {
        
    }
}