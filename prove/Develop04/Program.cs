using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfulness Program!\n");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Enter the number of the activity you would like to do: ");
            string select = Console.ReadLine();
            // 1. Breathing Activity
            if (select == "1")
            {
                BreathingActivity breath = new BreathingActivity(0, 4, 7);
                breath.DisplayStartMessage();
                breath.Run();
                breath.DisplayEndMessage();
            }
            // 2. Reflection Activity
            else if (select == "2")
            {
                ReflectionActivity reflect = new ReflectionActivity(0, 10);
                reflect.DisplayStartMessage();
                reflect.Run();
                reflect.DisplayEndMessage();
            }
            // 3. Listing Activity
            else if (select == "3")
            {
                ListingActivity list = new ListingActivity(0, 5);
                list.DisplayStartMessage();
                list.Run();
                list.DisplayEndMessage();
            }
            // 4. Quit.
            else if (select == "4")
            {
                break;
            }
            else
            {
                continue;
            }
        }
    }
}