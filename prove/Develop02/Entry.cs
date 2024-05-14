using System.Security.Cryptography.X509Certificates;
using System;

public class Entry //This is a Entry class for public
{
    // public List<int>_dateTime=new List<int>();// you can also creat the bling list.
    // public List<string>_PromptText=new List<string>();
    // public List<string>_EntryText=new List<string>();
    public DateTime _dateTime; //you can also change into string if you want
    public string _PromptText; //This is a prompt text 
    public string _EntryText; //Entry response 
    // foreach(string t in _dateTime
    public Entry (DateTime dateTime, string promptText, string EntryText)
    {
        _dateTime = dateTime;
        _PromptText = promptText;
        _EntryText = EntryText;

    }
    public void DisplayEntry()
    
    {
         Console.WriteLine($"Date:{_dateTime} Prompt:{_PromptText} your answer is: {_EntryText}");
    }
   
   public string GetEntryAsCSV()
   {
    return string.Format("{0}-{1}-{2}",_dateTime,_PromptText,_EntryText);
   }
// public string DateCreated {get;}
// public string Content {get;}//content is replaced

// //Initializes the date and content of an entry from user input
// public Entry (string dateInput, string content) {
// DateCreated = dateInput;
// Content = content;
// }

//     //Displays the content of an entry
//     public void DisplayEntry() //Displays here
//     {
//         Console.WriteLine($"Date: {DateCreated}");
//         Console.WriteLine($"Content: {Content}\n");
//     }

}