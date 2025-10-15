using System;

public class Journal
{
    private string _name;
    private List<Entry> _entries = new List<Entry>();
    public Journal(string name) // Journal Constructor
    {
        _name = name;
    }
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }
    public void DisplayName() // displays a standard line of text with the journal's name
    {
        Console.WriteLine($"Current journal: {_name}");
    }
    public void Display()
    {
        // display journal name followed by each entry
        DisplayName();
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void Save(string name)
    {
        _name = name;
        string filename = $"{name}.txt";
        /*
        It seems like a common issue, that the user might enter 
        the character we use as a delimiter, so maybe we should
        throw an exception when our delimiter appears in the name string.
        */
        using (StreamWriter writefile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                // we'll make a new method for Entry to produce the strings
                writefile.WriteLine($"{entry.SaveString()}");
            }
        }
    }
    public void Load(string name)
    {
        string filename = $"{name}.txt";
        string[] lines = [];
        // catch incompatible filenames, do nothing if file not found
        bool fileFound = true;
        try
        {
            lines = System.IO.File.ReadAllLines(filename);
        }
        catch (FileNotFoundException)
        {
            fileFound = false;
        }
        if (fileFound)
        {
            // set journal name to name matching found file
            _name = name;
            // Each line is an entry; we need to clear _entries, then add the new entries read from the file.
            _entries.Clear();
            foreach (string line in lines)
            {
                string[] parts = line.Split("|");
                Entry entry = new Entry(parts[1], parts[2], parts[0]);
                _entries.Add(entry);
            }
        }
    }
}