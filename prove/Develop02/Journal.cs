using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.IO;

public class Journal
 {
public List <Entry>_entries=new List<Entry>();//initialize to creat the 37 line new entry p generator
public PromptGenerator RandomPrompt=new PromptGenerator();

    //Constructor initializes and empty list of entries
    public Journal() 
    {
       
    }

 //Adds a new entry to the journal from user input
public void AddEntry()
    {  
    string prompt = RandomPrompt.GetRandomPrompt();
    // Console.Write("Please enter the date(mm/dd/yyyy): "); you can also ask from the user but here is system date time
    var TodayDate = DateTime.Today;
    string dateTime=TodayDate.ToString();
    // _dateTime.Add(_date);//   This can be done by creating new entry list an adding them all in the _entries List 
    Console.WriteLine($"Today's Prompt: {prompt}");
    Console.Write(">>>");
    string Text = Console.ReadLine();
    Entry NewEntry =new Entry(TodayDate, prompt, Text); //Here NewEntry is another variable
    _entries.Add(NewEntry);
    } 

    //Displays data input this session
    public void DisplayEntry() {
        foreach (Entry entry in _entries) {
            entry.DisplayEntry();
        }
    }

    //Saves Entries to a file named by the user
    public void SaveToFile() {
        Console.Write("Please enter the filename without Extension: ");
        string InputFileName = Console.ReadLine();
        string extension=".csv";  // I want to save the file as .CSV
        string filename=string.Concat(InputFileName, extension);  
        try {
            using (StreamWriter OutputFile = new StreamWriter(filename)) {
                foreach (Entry entry in _entries) {
                    string CSVFile=entry.GetEntryAsCSV(); //This calls the function from Entry public class and returns the CSV format here   
                    OutputFile.WriteLine(CSVFile);
                }
            }
            Console.WriteLine($"Journal entries saved to {filename}");
        } catch (Exception e) {
            Console.WriteLine($"Error saving entries to {filename}: {e.Message}");
        }
    }

    //Loads Entries from a file named by the user
    public void LoadFromFile() {
        Console.Write("Please enter the file name with extension like (john.cvs): ");
        String filename = Console.ReadLine();
        string[] lines=System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            Console.WriteLine(line); // If you want to sepatrate thet line's column, you can say strinf[] iteams=line.sprit(",")
        }           //And item1=items[0] and item2=items[1] like that
        // try {
        //     using (StreamReader reader = new StreamReader(filename)) { // We can use here string[] Lines=System.IO.File.readAllLine(FileName)
        //         while (!reader.EndOfStream) {
        //             string dateString = reader.ReadLine();
        //             string content = reader.ReadLine();
        //             Entry entry = new Entry(dateString, content);
        //            _entries.Add(entry);
        //         }
        //     } 
        // } catch (Exception e) {
        //         Console.WriteLine($"Error loading entries from :filename: {e.Message}");
        // }
    }

}