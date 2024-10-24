public class Comment
{
    public Person Commenter { get; set; } // Person class for the commenter
    public string CommentText { get; set; }

    public Comment(Person commenter, string commentText)
    {
        Commenter = commenter;
        CommentText = commentText;
    }
}


