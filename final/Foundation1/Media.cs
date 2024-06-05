using System.Collections.Generic;

public abstract class Media
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; } // Length in seconds

    public Media(string title, string author, int length)//Fethcing three parameters
    {
        Title = title;//Assigning and encapsulating here/ if private members
        Author = author;
        Length = length;
    }

    public abstract int GetNumberOfComments();//Using Abstraction method need not virtual key word
    public abstract List<Comment> GetComments();
}

