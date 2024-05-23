using System;
using System.Diagnostics;
using System.Runtime.InteropServices.Marshalling;
using System.Xml.Schema;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the fraction genarator");
        Console.WriteLine("I want to generate itself If Yes:1, No:2");
        string entered=Console.ReadLine();
        int outcome=int.Parse(entered);
        if (outcome==1)
         {
            Fraction f1 = new Fraction(); //This will calls a new fraction template with no parameter function from fraction class
            Console.WriteLine(f1.GetFractionString());// calls f1-fraction class--GetFractionString() function.
            Console.WriteLine(f1.GetDecimalValue());

            Fraction f2 = new Fraction(5);////This will calls a new fraction template with parameter (5) from fraction class
            Console.WriteLine(f2.GetFractionString());
            Console.WriteLine(f2.GetDecimalValue());

            Fraction f3 = new Fraction(3, 4);//first _Top  and second at the _bottem
            Console.WriteLine(f3.GetFractionString());
            Console.WriteLine(f3.GetDecimalValue());

            Fraction f4 = new Fraction(1, 3);
            Console.WriteLine(f4.GetFractionString());
            Console.WriteLine(f4.GetDecimalValue());
            Console.WriteLine("");
         }
        else if (outcome==2)
        {
           
    
            Console.WriteLine("Please enter the upper digit:");
            string upper=Console.ReadLine();
            int top=int.Parse(upper);
            Console.WriteLine("Please enter the lower digit:");
            string lower=Console.ReadLine();
            int bottom=int.Parse(lower);
            Fraction f5 = new Fraction(top, bottom);  
            Console.WriteLine(f5.GetFractionString());
            Console.WriteLine(f5.GetDecimalValue());
            Console.WriteLine(""); 
        }
        else
        Console.WriteLine("Not a valid nuber");
    }
}