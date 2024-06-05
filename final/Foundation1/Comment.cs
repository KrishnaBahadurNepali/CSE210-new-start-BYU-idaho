using System;

public class Comment
{
    public string CommenterName { get; set; }//Using get and set//you may use priate and then access using virtual or abstraction methods
    public string CommentText { get; set; }

    public Comment(string commenterName, string commentText)
    {
        CommenterName = commenterName;//Encapsulating and assigning the string variable
        CommentText = commentText;
    }
}

