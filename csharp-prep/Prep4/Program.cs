using System;

class Program
{
    static void Main(string[] args)
    {
        // get a list of numbers from the user
        List<double> numbers = new List<double>();

        while (true)
        {
            // use a try-catch loop to catch common FormatException
            double entry;
            try
            {
                Console.Write("Please enter a number, or enter 0 when finished: ");
                entry = double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                continue;
            }
            // break if user entered a zero, otherwise add number to list and loop continues
            if (entry == 0)
            {
                break;
            }
            else
            {
                numbers.Add(entry);
            }
        }

        // compute the sum of the numbers in the list
        double sum = 0;
        foreach (double numb in numbers)
        {
            sum += numb;
        }

        // compute the mean average of the numbers in the list
        // use sum from previous step
        double average = sum / numbers.Count;

        // find the maximum number in the list
        double max = numbers[0];
        foreach (double numb in numbers)
        {
            if (numb > max)
            {
                max = numb;
            }
        }

        // display results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The max is: {max}");
    }
}