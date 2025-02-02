using System;

class Comment
{
    private string _authorName;
    private string _text;

    public Comment(string authorName, string text)
    {
        _authorName = authorName;
        _text = text;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"{_authorName}: {_text}");
        Console.WriteLine();
    }
}