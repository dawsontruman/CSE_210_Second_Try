using System;

public class EternalGoal : Goal
{
    private int _checkPoints;
    public EternalGoal(string description, int target = -1, int checkPoints) : base(description, target)
    {
        _checkPoints = checkPoints;
    }
    public override void RecordEvent()
    {
        AddPoints(_checkPoints);
        AddProgress();
    }
    public override string ReturnProgressString()
    {
        return $"{_progress}";
    }
}