using System;

class Program
{
    static void Main(string[] args)
    {
        // create and display a Fraction representing 1
        Fraction one = new Fraction(); // default value is 1/1 
        Console.WriteLine($"{one.GetFractionString()}");
        Console.WriteLine($"{one.GetDecimalValue()}");

        // create and display a Fraction representing 5
        Fraction five = new Fraction(5); // top will construct as 5 and bottom defautls to 1
        Console.WriteLine($"{five.GetFractionString()}");
        Console.WriteLine($"{five.GetDecimalValue()}");

        // create and display a Fraction representing 3/4
        // here we will test our getters and setters by changing the values of one
        one.SetTop(3);
        one.SetBottom(4);
        Console.WriteLine($"{one.GetFractionString()}");
        Console.WriteLine($"{one.GetDecimalValue()}");

        // create and display a Fraction representing 1/3
        Fraction one_third = new Fraction(1, 3); // constructs with top = 1 and bottom = 3
        Console.WriteLine($"{one_third.GetFractionString()}");
        Console.WriteLine($"{one_third.GetDecimalValue()}");

    }
}