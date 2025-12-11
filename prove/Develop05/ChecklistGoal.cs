using System;

public class ChecklistGoal : Goal
{
    private int _checkPoints;
    private int _completionPoints;
    private int _progress;
    private int _target;
    public ChecklistGoal(string description, int completionPoints, int checkPoints, int target) : base(description)
    {
        _completionPoints = completionPoints;
        _checkPoints = checkPoints;
        _target = target;
        _progress = 0;
    }
    public override void RecordEvent()
    {
        _progress += 1;
        if (_progress == _target)
        {
            AddPoints(_completionPoints);
            MarkComplete();
        }
        else
        {
            AddPoints(_checkPoints);
        }
    }
    public int ReturnProgress()
    {
        return _progress;
    }
    public int ReturnTarget()
    {
        return _target;
    }
}