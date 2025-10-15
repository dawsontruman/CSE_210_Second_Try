using System;

class Program
{
    static void Main(string[] args)
    {
        Journal currentJournal = new Journal("New Journal");
        /*
        A new journal is created on start, but this
        object will hold whatever the current journal is.
        We will be able to load a saved journal, reassigning this
        object with the properties of the stored journal, or
        save the current journal, renaming it and
        storing its data in a file.
        */

        Console.Clear(); // clear console on start

        while (true)
        {
            // display menu
            Console.WriteLine("Welcome to the journal program!\n");
            currentJournal.DisplayName();
            Console.WriteLine("1. Write a new entry.");
            Console.WriteLine("2. Display the current journal.");
            Console.WriteLine("3. Save the current journal.");
            Console.WriteLine("4. Load a saved journal.");
            Console.WriteLine("5. Quit.");

            // take user input
            Console.Write("Enter a number to select an option from above: ");
            int sel; // variable holds user selection
            try
            {
                sel = int.Parse(Console.ReadLine());
            }
            // catch user inputs that can't be parsed to int
            catch (FormatException)
            {
                Console.Clear();
                continue;
            }

            // 1. Write a new entry.
            if (sel == 1)
            {
                // generate a new prompt
                Prompt promptGen = new Prompt();
                string prompt = promptGen.GenerateRandomPrompt();
                // display prompt and get user input for response
                Console.Clear();
                Console.WriteLine(prompt);
                string response = Console.ReadLine();
                // construct a new entry with prompt and input
                Entry newEntry = new Entry(prompt, response);
                // add entry to journal
                currentJournal.AddEntry(newEntry);
            }

            // 2. Display the current journal.
            else if (sel == 2)
            {
                while (true)
                {
                    // clear console and display journal
                    Console.Clear();
                    currentJournal.Display();
                    // prompt user to press Enter to return to menu
                    Console.Write("Press Enter to return to menu: ");
                    string rtrn = Console.ReadLine();
                    if (rtrn == "")
                    {
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            // 3. Save the current journal.
            else if (sel == 3)
            {
                Console.Clear();
                // get a new journal name from user
                Console.WriteLine("Please avoid using these characters: . | \\");
                Console.Write("Enter a name for your journal: ");
                string name = Console.ReadLine();
                // Save method assigns journal with the new name and writes to a file
                currentJournal.Save(name);
                Console.Clear();
            }

            // 4. Load a saved journal.
            else if (sel == 4)
            {
                Console.Clear();
                /*
                For a little stretch challenge, to try for that last 7%, I'm
                going to find a way to have my program display a list of the
                journals that are saved in this folder.
                */
                Console.WriteLine("Journals on local directory:");
                string[] filenames = System.IO.Directory.GetFiles(Environment.CurrentDirectory,"*.txt");
                foreach (string filename in filenames)
                {
                    string[] splitName = filename.Split("\\");
                    string txtName = splitName[splitName.Count() - 1];
                    string[] splitName2 = txtName.Split(".");
                    string journalName = splitName2[0];
                    Console.WriteLine(journalName);
                }

                // get name of journal user is looking for
                Console.Write("\nEnter the name of the journal to load: ");
                string name = Console.ReadLine();
                // load method checks for a file with that name and
                // reads its data to the current journal
                currentJournal.Load(name);
                Console.Clear();
            }

            // 5. Quit.
            if (sel == 5)
            {
                break;
            }

            // program clears console and repeats menu if invalid number is entered
            else
            {
                Console.Clear();
                continue;
            }
        }
    }
}