using System.Security.Cryptography.X509Certificates;

// public class Entry
// {
//     public DateTime _dateTime; //you can also change into string if you want
//     public string _PromptText;
//     public string _EntryText;
//     public void Display()
//     {
//         Console.WriteLine("Hello world");
//     }

// }
using System;

public class Entry 
{
    // public List<int>_dateTime=new List<int>();// you can also creat the bling list.
    // public List<string>_PromptText=new List<string>();
    // public List<string>_EntryText=new List<string>();
    public DateTime _dateTime; //you can also change into string if you want
    public string _PromptText;
    public string _EntryText;
    // foreach(string t in _dateTime)
    public void Display()
    
    {
         Console.WriteLine($"Date:{_dateTime} Prompt:{_PromptText} your answer is: {_EntryText}");
    }
   
public string DateCreated {get;}
public string Content {get;}//content is replaced

//Initializes the date and content of an entry from user input
public Entry (string dateInput, string content) {
DateCreated = dateInput;
Content = content;
}

    //Displays the content of an entry
    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {DateCreated}");
        Console.WriteLine($"Content: {Content}\n");
    }

}