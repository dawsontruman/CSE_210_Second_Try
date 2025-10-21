using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verseStart;
    private int _verseEnd;
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verse;
        _verseEnd = 0;
    }
    public Reference(string book, int chapter, int verseStart, int verseEnd)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _verseEnd = verseEnd;
    }
    public string GetReferenceString()
    // returns different strings depending on whether there is an endVerse
    {
        if (_verseEnd == 0)
        {
            return $"{_book} {_chapter}: {_verseStart}";
        }
        else
        {
            return $"{_book} {_chapter}: {_verseStart}-{_verseEnd}";
        }
    }
}