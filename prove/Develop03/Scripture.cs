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
        /*
        Needs to work as such:
        1. STOP WHEN ALL WORDS ARE HIDDEN
        2. Go through and make a list of THE INDEXES OF all the unhidden words in _words
        3. Hide random index
        */
        for (int i = 0; i < numberToHide; i += 1)
        {
            if (CheckHidden())
            {
                break;
            }
            else
            {
                List<int> indices = new List<int>();
                int length = _words.Count();
                for (int j = 0; j < length; j += 1)
                {
                    if (_words[j].ReturnHidden())
                    {
                        continue;
                    }
                    else
                    {
                        indices.Add(j);
                    }
                }
                int randNum = random.Next(0, indices.Count() - 1);
                int wordToHide = indices[randNum];
                _words[wordToHide].Hide();
            }
        }
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