using System.Collections.Generic;

public class Video : Media//Base class Media
{
    private List<Comment> Comments { get; set; } //The comments are fetch from the Commets class and makes lists

    public Video(string title, string author, int length) : base(title, author, length)//These are the parameters  fetch from the 
    //Video section with name and comments and the video length
    //In week 04 and 05 we have learned how to pass parameters or call the function and return the values
    {
        Comments = new List<Comment>();//We can  also write like: private List<Comment> Comments=new List<Comments>()
    }

    // Add a comment to the video
    public void AddComment(Comment comment) //comment is Comment templete variable 
    {
        Comments.Add(comment);//From the comment class templete, all the (comment) are add to the Comments List
    }

    // Override method to return the number of comments
    public override int GetNumberOfComments()//Comments are from different people that why I use override method.
    {
        return Comments.Count; //This returns all the comments to the called on fuction
    }

    // Override method to return the list of comments
    public override List<Comment> GetComments()
    {
        return Comments;
    }
}
