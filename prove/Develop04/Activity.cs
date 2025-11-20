using System;
public class Activity
{
    private int _duration;
    private string _activityName;
    /*
    A needed change from the initial design, each activity has a fixed
    name in its constructor that is passed into the base class,
    and that name is used in the public DisplayStartMessage() and 
    DisplayEndMessage() methods.
    */
    private string _description;
    // after reading the project specifications more closely we find that each activity also needs a description
    public Activity(int duration, string activityName, string description)
    {
        _duration = duration;
        _activityName = activityName;
        _description = description;
    }
    public void DisplayStartMessage()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine($"Welcome to the {_activityName}.");
            Console.WriteLine(_description);
            Console.WriteLine("Please enter a duration for this activity: ");
            try
            {
                int duration = int.Parse(Console.ReadLine());
                _duration = duration;
                break;
            }
            catch (FormatException)
            {
                continue;
            }
        }
    }
    public void DisplayEndMessage()
    {
        Console.WriteLine($"This concludes the {_activityName}.");
    }
    public void Spinner(int seconds)
    {
        List<string> spinnerStrings = ["|","/","-","\\"];
        for (int i = 0; i < seconds; i += 1)
        {
            Console.Write($"{spinnerStrings[i%4]}");
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }
    public void CountUp(int seconds)
    {
        for (int i = 1; i <= seconds; i += 1)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            if (i < 10)
            {
                Console.Write("\b \b");
            }
            else if (10 <= i && i < 100)
            {
                Console.Write("\b\b  \b\b");
            }
        }
    }
    public void CountDown(int seconds)
    {
        for (int i = seconds; i > 0; i -= 1)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            if (i < 10)
            {
                Console.Write("\b \b");
            }
            else if (i >= 10 && i < 100)
            {
                Console.Write("\b\b  \b\b");
            }
        }
    }
}