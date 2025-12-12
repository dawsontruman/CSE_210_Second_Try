using System;

public class Cycling: Activity
{
    private float _speed;
    public Cycling(string date, int length, float speed)
    : base(date, length)
    {
        _speed = speed;
    }
    public override float Distance()
    {
        return Length() / Pace();
    }
    public override float Speed()
    {
        return _speed;
    }
    public override float Pace()
    {
        return 60 / Speed();
    }
    public override string ActivityName()
    {
        return "Cycling";
    }
}