using System;
public class ListingActivity : Activity
{
    private int _waitTime; // added a programmable wait time (the time the user has to consider the prompt before listing responses)
    private List<string> _listingPrompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    }; // prompts copied from project specification
    public ListingActivity(int duration, int waitTime) : base(duration, "Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _waitTime = waitTime;
    }
    // description copied from project specification
    public void Run()
    {
        Console.Clear();
        // get a random prompt and display it
        Random rand = new Random();
        string prompt = _listingPrompts[rand.Next(0,_listingPrompts.Count)];
        Console.WriteLine(prompt);
        CountDown(_waitTime);
        // mark start and end time
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        // mark current time and start a count
        DateTime currentTime = DateTime.Now;
        int count = 0;
        // prompt user to list as many responses as possible
        Console.WriteLine("List as many responses as you can think of: ");
        // count the number of answers the user enters; stop after end time is reached
        while (currentTime < endTime)
        {
            Console.ReadLine();
            count += 1;
            currentTime = DateTime.Now;
        }
        // display number of responses; prompt user to press enter to continue
        Console.WriteLine($"Number of responses: {count}");
        Console.Write("Press enter to continue: ");
        Console.ReadLine();
    }
}