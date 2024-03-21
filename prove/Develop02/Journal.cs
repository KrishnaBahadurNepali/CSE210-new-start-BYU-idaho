// public class Journal //There is no any semi colon in the class
// {
//    public List<Entry>_entries;
//    public void AddEntry(Entry newEntry) // you know the method theJournal._entries.Add(Entry {should be new Entry type})
//    {                                    //This is method adding new Entry to the box.
//     _entries.Add(newEntry);
//    }
//    public void displayAll()
//    {

//    }
//    public void AddToFile(string file)
//    {

//    }

//     public void LoadFromFile(string file)
//     {

//     }
    



// }
//The above  calling are just for making sure if the course requirement is fulfilled.
using System;
using System.Security.Cryptography.X509Certificates;

public class Journal
 {
public List <Entry>_entries; //initialize to creat the 37 line new entry p generator
public PromptGenerator PromptGenerator=new PromptGenerator();

    //Constructor initializes and empty list of entries
    public Journal() 
    {
        _entries = new List<Entry>();
        //Initializes the prompt generator
        // PromptGenerator = new PromptGenerator();
    }

    //Adds a new entry to the journal from user input
    public void AddEntry()
     {  
        
        string prompt = PromptGenerator.GetRandomPrompt();
        Console.Write("Please enter the date(mm/dd/yyyy): ");
        string _date = Console.ReadLine();
        List<string>_dateTime=new List<string>();//for new string date and time
        _dateTime.Add(_date);//
        Console.WriteLine($"Today's Prompt: {prompt}");
        Console.Write("> ");
        string _Text = Console.ReadLine();
         //content is answer here
        List<string>_PromptText=new List<string>();
        _PromptText.Add("_Text");//correction here
    }

    //Displays data input this session
    public void DisplayEntry() {
        foreach (Entry entry in _entries) {
            entry.DisplayEntry();
        }
    }

    //Saves Entries to a file named by the user
    public void SaveToFile() {
        Console.Write("Please enter the filename you would like to save to: ");
        string filename = Console.ReadLine();
        try {
            using (StreamWriter writer = new StreamWriter(filename)) {
                foreach (Entry entry in _entries) {
                    writer.WriteLine($"{entry.DateCreated}\n{entry.Content}");
                }
            }
            Console.WriteLine($"Journal entries saved to {filename}");
        } catch (Exception e) {
            Console.WriteLine($"Error saving entries to {filename}: {e.Message}");
        }
    }

    //Loads Entries from a file named by the user
    public void LoadFromFile() {
        Console.Write("Please enter the file name you would like to load from: ");
        String filename = Console.ReadLine();
        try {
            using (StreamReader reader = new StreamReader(filename)) {
                while (!reader.EndOfStream) {
                    string dateString = reader.ReadLine();
                    string content = reader.ReadLine();
                    Entry entry = new Entry(dateString, content);
                   _entries.Add(entry);
                }
            } 
        } catch (Exception e) {
                Console.WriteLine($"Error loading entries from :filename: {e.Message}");
        }
    }

}