using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Cycling("07 June 2024", 45, 21),
            new Running("09 June 2024", 40, 5),
            new Swimming("23 June 2024", 30, 10)
        };
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}