using System;

class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(string userName, string text)
    {
        _comments.Add(new Comment(userName, text));
    }
    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public int GetDuration()
    {
        return _length;
    }
    public int GetCommentsCount()
    {
        return _comments.Count();
    }
    public void ShowComments()
    {
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
    }
}