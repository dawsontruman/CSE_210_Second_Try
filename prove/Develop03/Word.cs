using System;

public class Word
{
    private bool _isHidden;
    private string _text;
    private string _textHidden;
    public Word(string text)
    {
        _isHidden = false;
        _text = text;
        // create the string of underscores of equal length to word text
        _textHidden = "";
        for (int i = 0; i < text.Length; i += 1)
        {
            _textHidden += "_";
        }
    }
    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }
    public string ReturnString()
    {
    // returns string of underscores if hidden
        if (_isHidden)
        {
            return _textHidden;
        }
        else
        {
            return _text;
        }
    }
    public bool ReturnHidden()
    {
        return _isHidden;
    }
}