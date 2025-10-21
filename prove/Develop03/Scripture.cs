using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        // split word string and construct list of words to pass into _words
        string[] wordList = text.Split(" ");
        foreach (string word in wordList)
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
    }
    public void Display()
    {
        Console.WriteLine(_reference.GetReferenceString());
        foreach (Word word in _words)
        {
            Console.Write(word.ReturnString()+" ");
        }
    }
    public bool CheckHidden()
    // iterate through word list, returns false if any words not hidden yet
    {
        bool allHidden = true;
        foreach (Word word in _words)
        {
            if (word.ReturnHidden() == false)
            {
                allHidden = false;
            }
        }
        return allHidden;
    }
}