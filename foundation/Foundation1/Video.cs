using System;
using System.Collections.Generic;

public class Video
{
    public string Title { get; set; }
    public Person Author { get; set; }
    public int Length { get; set; }
    private List<Comment> Comments = new List<Comment>();

    public Video(string title, Person author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return Comments.Count;
    }

    public void DisplayVideo()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author.GetFullName()}, Length: {Length} seconds");
        Console.WriteLine($"Number of comments: {GetCommentCount()}");
        foreach (Comment comment in Comments)
        {
            Console.WriteLine($"{comment.Commenter.GetFullName()}: {comment.CommentText}");
        }
        Console.WriteLine(new string('-', 20));
    }
}

public class Person
{
    private string _title;
    private string _firstName;
    private string _lastName;

    public Person(string title, string firstName, string lastName)
    {
        _title = title;
        _firstName = firstName;
        _lastName = lastName;
    }

    public string GetFullName()
    {
        return $"{_title} {_firstName} {_lastName}";
    }
}

