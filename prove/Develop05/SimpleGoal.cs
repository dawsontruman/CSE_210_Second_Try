using System;

public class SimpleGoal : Goal
{
    private int _completionPoints;
    private bool _isComplete;
    public SimpleGoal(string description, int completionPoints) : base(description)
    {
        _completionPoints = completionPoints;
    }
    public override void RecordEvent()
    {
        AddPoints(_completionPoints);
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string ReturnProgressString()
    {
        if (_isComplete)
        {
            return "1/1";
        }
        else
        {
            return "0/1";
        }
    }
}