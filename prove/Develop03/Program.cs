using System;

// Scripture Memorizer Program
class Program
{
    static void Main(string[] args)
    {
        // instantiate reference and scripture
        Reference ref1 = new Reference("1 Nephi", 10, 4);
        Scripture script1 = new Scripture(ref1,
        "Yea, even six hundred years from the time that my father left Jerusalem, a prophet would the Lord God raise up among the Jews— even a Messiah, or, in other words, a Savior of the world."
        );

        while (true)
        {
            Console.Clear();
            script1.Display();
            Console.Write("\nPress Enter to hide words:");
            string input = Console.ReadLine();
            if (script1.CheckHidden())
            {
                break;
            }
            else if (input == "")
            {
                script1.HideRandomWords(3);
            }
            else
            {
                continue;
            }
        }
    }
}