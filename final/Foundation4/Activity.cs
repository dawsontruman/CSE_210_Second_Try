using System;

public abstract class Activity
{
    private string _date;
    private int _length; // time in minutes
    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }
    public abstract string ActivityName();
    public abstract float Distance();
    public abstract float Speed();
    public abstract float Pace();
    public int Length()
    {
        return _length;
    }
    public string GetSummary()
    {
        return $"{_date} {ActivityName()} ({_length} min) - Distance: {Distance()} km, Speed: {Speed()} kph, Pace: {Pace()} min per km";
    }
}