using System;
public class BreathingActivity : Activity
{
    private int _inhaleTime;
    private int _exhaleTime;
    public BreathingActivity(
        int duration,
        int inhaleTime,
        int exhaleTime
        ) : base(duration)
    {
        _inhaleTime = inhaleTime;
        _exhaleTime = exhaleTime;
    }
    public void Run()
    {
        
    }
}