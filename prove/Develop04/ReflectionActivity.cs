using System;
public class ReflectionActivity : Activity
{
    private List<string> _reflectionPrompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    }; // prompts copied from project specification
    private List<string> _reflectionQuestions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    }; // questions copied from project specification
    private int _reflectionTime;
    public ReflectionActivity(int duration, int reflectionTime) : base(duration, "Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _reflectionTime = reflectionTime;
    }
    // description copied from project specification
    public void Run()
    {
        Console.Clear();
        // get a random prompt and display it
        Random rand = new Random();
        string prompt = _reflectionPrompts[rand.Next(0,_reflectionPrompts.Count)];
        Console.WriteLine(prompt);
        // mark start and end time
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        // loop displaying new questions with pauses until current time exceeds end time
        DateTime currentTime = DateTime.Now;
        while (currentTime < endTime)
        {
            string quest = _reflectionQuestions[rand.Next(0,_reflectionQuestions.Count)];
            Console.Write($"\n{quest}");
            Spinner(_reflectionTime);
            currentTime = DateTime.Now;
        }
    }
}