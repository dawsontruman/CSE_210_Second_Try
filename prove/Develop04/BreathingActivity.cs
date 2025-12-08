using System;
public class BreathingActivity : Activity
{
    private int _inhaleTime;
    private int _exhaleTime;
    public BreathingActivity(int duration, int inhaleTime, int exhaleTime) : base(duration, "Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
        _inhaleTime = inhaleTime;
        _exhaleTime = exhaleTime;
    }
    // description copied from project specification
    public void Run()
    {
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (true)
        {
            DateTime currentTime = DateTime.Now;
            if (currentTime < endTime){
                Console.Clear();
                Console.Write("Breath in...");
                CountDown(_inhaleTime);
                Console.Write("\nBreathe out...");
                CountDown(_exhaleTime);
            }
            else
            {
                break;
            }
        }
    }
}