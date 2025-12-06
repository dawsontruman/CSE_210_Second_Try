using System;

public class EternalGoal : Goal
{
    private int _checkPoints;
    public EternalGoal(string description, int checkPoints) : base(description)
    {
        _checkPoints = checkPoints;
    }
    public override void RecordEvent()
    {
        base.RecordEvent();
    }
}