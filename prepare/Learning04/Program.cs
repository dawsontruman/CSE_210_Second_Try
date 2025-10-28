using System;

class Program
{
    static void Main(string[] args)
    {
        // test Assignment
        Assignment homework1 = new Assignment("Mary Jane", "Shave Three Tigers");
        Console.WriteLine(homework1.GetSummary());

        // test MathAssignment
        MathAssignment mathHwk = new MathAssignment("Samuel Harrison", "Linear Algebra", "3.1", "3,5,9");
        Console.WriteLine(mathHwk.GetSummary());
        Console.WriteLine(mathHwk.GetHomeworkList());

        // test WritingAssignment
        WritingAssignment paper = new WritingAssignment("Dawson Truman", "CSE 210", "Articulate: Encapsulation");
        Console.WriteLine(paper.GetSummary());
        Console.WriteLine(paper.GetWritingInformation());   
    }
}