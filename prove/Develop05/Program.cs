using System;

class Program
{
    static void Main(string[] args)
    {
        // start by creating a new list; user must save it with a new name or load a saved list
        List<Goal> currentGoalList = new List<Goal>();
        string goalListName = "New Goal List";
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Goal Tracker Program.");
            // display info about current goal list
            Console.WriteLine($"Current List: {goalListName}");
            // add up points in the goal list and display them
            int pointTotal = 0;
            foreach (Goal goal in currentGoalList)
            {
                pointTotal += goal.ReturnPoints();
            }
            Console.WriteLine($"Points: {pointTotal}\n");
            // menu
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create a New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            string selection = Console.ReadLine();
            // 1. Create a New Goal
            if (selection == "1")
            {
                
            }
            // 2. List Goals
            else if (selection == "2")
            {
                
            }
            // 3. Save Goals
            else if (selection == "3")
            {
                
            }
            // 4. Load Goals
            else if (selection == "4")
            {
                
            }
            // 5. Record Event
            else if (selection == "5")
            {
                
            }
            // 6. Quit
            else if (selection == "6")
            {
                
            }
            // repeat loop if input is invalid
            else
            {
                continue;
            }
        }
    }
}