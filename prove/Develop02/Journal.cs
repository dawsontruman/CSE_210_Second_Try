using System;

public class Journal
{
    private string _name;
    private List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }
    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void Save()
    {

    }
    public void Load()
    {
        
    }
}