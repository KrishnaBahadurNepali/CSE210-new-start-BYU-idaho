using System;

class Program
{
    static void Main(string[] args)
    {
        // I have created base class Assignment to next class and here declaring the variable summary
        Assignment summary1 = new Assignment("Krishna Bahadur Nepali", "CSE210 week 04 ");
        Console.WriteLine(summary1.GetSummary());

        // Now create the derived class assignments and pass them to the class called MathAssignment including 4 variables
        MathAssignment summery2 = new MathAssignment("Manisha Maurati", "Trigonometric", "8", "10-20");//ready to accept these 4parameters by MathAssignmet with three variable parameters
        Console.WriteLine(summery2.GetSummary());
        Console.WriteLine(summery2.GetHomeworkList());

        WritingAssignment summery3= new WritingAssignment("Pooja Ghimire", "About Nepal", "The history of Mountain everest");
        Console.WriteLine(summery3.GetSummary());
        Console.WriteLine(summery3.GetWritingInformation());
    }
}