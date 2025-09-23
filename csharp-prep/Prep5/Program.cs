using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int birthYear;
        PromptUserBirthYear(out birthYear);
        int squareNumber = SquareNumber(number);
        DisplayResult(name, squareNumber, birthYear);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }
    static int PromptUserNumber()
    {
        int favNumber;
        while (true)
        {
            Console.Write("Please enter your favorite number: ");
            try
            {
                favNumber = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                continue;
            }
            break;
        }
        return favNumber;
    }
    static void PromptUserBirthYear(out int birthYear)
    {
        while (true)
        {
            Console.Write("Please enter the year you were born: ");
            try
            {
                birthYear = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                continue;
            }
            break;
        }
    }
    static int SquareNumber(int number)
    {
        return number * number;
    }
    static void DisplayResult(string name, int squareNumber, int birthYear)
    {
        Console.WriteLine($"{name}, the square of your number is {squareNumber}");
        // calculate and display age of user, using 2025 as current year, 
        // shamefully avoiding using DateTime for this assignment
        int age = 2025 - birthYear;
        Console.WriteLine($"{name}, you will turn {age} this year.");
    }
}