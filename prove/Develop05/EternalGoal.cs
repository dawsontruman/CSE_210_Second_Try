using System;

public class EternalGoal : Goal
{
    private int _checkPoints;
    private int _progress;
    public EternalGoal(string description, int checkPoints) : base(description)
    {
        _checkPoints = checkPoints;
    }
    public override void RecordEvent()
    {
        AddPoints(_checkPoints);
        _progress += 1;
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string ReturnProgressString()
    {
        return $"{_progress}";
    }
}