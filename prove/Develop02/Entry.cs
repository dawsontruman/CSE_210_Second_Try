using System;

public class Entry
{
    private string _date;
    private string _prompt;
    private string _text;
    public Entry(string prompt, string text)
    {
        // log date when entry is created
        DateTime date = DateTime.Now;
        _date = date.ToShortDateString();
        _prompt = prompt;
        _text = text;
    }
    public Entry(string prompt, string text, string date)
    {
        // constructor used when loading journals, needs a date string
        _date = date;
        _prompt = prompt;
        _text = text;
    }
    public string SaveString()
    {
        return $"{_date}|{_prompt}|{_text}";
    }
    public void Display()
    {
        Console.WriteLine($"{_date}\n{_prompt}\n{_text}\n");
    }
}