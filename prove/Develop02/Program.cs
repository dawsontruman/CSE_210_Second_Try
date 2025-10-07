using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            // clear console and display menu
            Console.Clear();
            Console.WriteLine("Welcome to the journal program!");
            Console.WriteLine("1. Write a new entry.");
            Console.WriteLine("2. Display the current journal.");
            Console.WriteLine("3. Save the current journal.");
            Console.WriteLine("4. Load a saved journal.");
            Console.WriteLine("5. Quit.");

            // take user input
            Console.Write("Enter a number to select an option from above:");
            int sel; // variable holds user selection
            try
            {
                sel = int.Parse(Console.ReadLine());
            }
            // catch user inputs that can't be parsed to int
            catch (FormatException)
            {
                continue;
            }

            // 1. Write a new entry.
            if (sel == 1)
            {

            }

            // 2. Display the current journal.
            else if (sel == 2)
            {

            }

            // 3. Save the current journal.
            else if (sel == 3)
            {

            }

            // 4. Load a saved journal.
            else if (sel == 4)
            {

            }

            // 5. Quit.
            if (sel == 5)
            {
                break;
            }

            // program clears console and repeats menu if invalid number is entered
            else
            {
                continue;
            }
        }
    }
}