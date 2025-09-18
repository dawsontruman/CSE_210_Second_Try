using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your first name: ");
        string first = Console.ReadLine();
        Console.Write("Please enter your last name: ");
        string last = Console.ReadLine();
        Console.Write($"\nYour name is {last}, {first} {last}.");
    }
}