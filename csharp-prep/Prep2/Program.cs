using System;
class Program
{
    static void Main(string[] args)
    {
        // get grade percentage from user
        Console.Write("Please enter your grade percentage: ");
        float grade = float.Parse(Console.ReadLine());

        // Determine letter grade
        string letter;
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine plus or minus
        string plusMinus;
        if (grade % 10 >= 7 & letter != "A" & letter != "F")
        {
            plusMinus = "+";
        }
        else if (grade % 10 < 3 & letter != "A" & letter != "F")
        {
            plusMinus = "-";
        }
        else
        {
            plusMinus = "";
        }

        // determine pass or fail
        bool pass;
        if (grade >= 70)
        {
            pass = true;
        }
        else
        {
            pass = false;
        }

        // display grade
        Console.WriteLine($"Your grade: {letter}{plusMinus}");

        // rub it in
        if (pass)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine("You did not pass. Better luck next time!");
        }
    }
}