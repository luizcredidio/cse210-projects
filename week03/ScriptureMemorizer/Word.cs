using System;

class Word
{
    private string _text;
    private Boolean _isHidden = false;

    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public Boolean isHidden()
    {
        return _isHidden;
    }

    public string GetDIsplayText()
    {
        if (_isHidden)
        {
            string hiddenText = "";
            for (int i = 0; i < _text.Length; i++)
            {
                hiddenText += "_";
            }
            return hiddenText;
        }

        return _text;
    }
}
