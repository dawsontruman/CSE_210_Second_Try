using System;

public class SimpleGoal : Goal
{
    private int _completionPoints;
    public SimpleGoal(string description, int completionPoints) : base(description)
    {
        _completionPoints = completionPoints;
    }
    public override void RecordEvent()
    {
        AddPoints(_completionPoints);
        MarkComplete();
    }
}