using System;

public class Swimming: Activity
{
    private float _laps;
    public Swimming(string date, int length, float laps)
    : base(date, length)
    {
        _laps = laps;
    }
    public override float Distance()
    {
        return _laps *  50 / 1000;
    }
    public override float Speed()
    {
        return 60 * Distance() / Length();
    }
    public override float Pace()
    {
        return Length() / Distance();
    }
    public override string ActivityName()
    {
        return "Swimming";
    }
}