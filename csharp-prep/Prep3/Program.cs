using System;

class Program
{
    static void Main(string[] args)
    {
        Random randNumb = new Random();

        // put whole thing in a loop
        bool cont = true;
        while (cont)
        {
            // Generate random number
            int number = randNumb.Next(1, 101);

            // get user guess, handle FormatException
            int guess;
            try
            {
                Console.Write("Guess a number from 1 to 100.\nWhat is your guess? ");
                guess = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a whole number.");
                continue;
            }

            // count user guesses
            int count = 1;

            // loop until guess equals random number
            while (guess != number)
            {
                if (guess < number)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > number)
                {
                    Console.WriteLine("Lower");
                }

                try
                {
                    Console.Write("What is your guess? ");
                    guess = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a number.");
                    continue;
                }
                count += 1;
            }

            // two different completion messages depending on number of tries
            if (count == 1)
            {
                Console.WriteLine("Yes! First try!");
            }
            else
            {
                Console.WriteLine($"Correct!\nYou guessed it in {count} tries.");
            }

            // ask if they want to play again
            Console.Write("Would you like to play again?\nType \"no\" to quit: ");
            string quitText = Console.ReadLine();
            if (quitText == "no")
            {
                cont = false;
            }
            else
            {
                continue;
            }
        }
    }
}