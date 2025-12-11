using System;

public abstract class Goal
{
    // instead of a boolean complete attribute, we'll use integers for progress and target
    // the IsComplete() method below gives us a bool we can check
    private int _points;
    private string _description;
    public Goal(string description)
    {
        _description = description;
    }
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public void AddPoints(int points)
    {
        _points += points;
    }
    public int ReturnPoints()
    {
        return _points;
    }
    public string ReturnDescription()
    {
        return _description;
    }
    public abstract string ReturnProgressString();
}