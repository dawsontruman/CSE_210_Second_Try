using System;

public class Video
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
    public void Display()
    {
        Console.WriteLine(_title);
        Console.WriteLine(_author);
        Console.WriteLine(_length);
        Console.WriteLine("Comments: ");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine(comment.CommentString());
        }
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
}