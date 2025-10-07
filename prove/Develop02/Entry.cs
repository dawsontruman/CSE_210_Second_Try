using System;

public class Entry
{
    private string _date;
    private string _prompt;
    private string _text;
    public void Display()
    {
        Console.WriteLine($"{_date}\n{_prompt}\n{_text}\n");
    }
}