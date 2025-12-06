using System;

public class Goal
{
    private bool _complete;
    private int _points;
    private string _description;
    public Goal(string description)
    {
        _description = description;
    }
    public virtual void RecordEvent() { }
    public bool IsComplete()
    {
        return _complete;
    }
    public void MarkComplete()
    {
        _complete = true;
    }
    public int ReturnPoints()
    {
        return _points;
    }
    public void AddPoints(int points)
    {
        _points += points;
    }
}