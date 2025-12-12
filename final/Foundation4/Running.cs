using System;

public class Running: Activity
{
    private float _distance;
    public Running(string date, int length, float distance)
    : base(date, length)
    {
        _distance = distance;
    }
    public override float Distance()
    {
        return _distance;
    }
    public override float Speed()
    {
        return 60 * _distance / Length();
    }
    public override float Pace()
    {
        return Length() / Distance();
    }
    public override string ActivityName()
    {
        return "Running";
    }
}