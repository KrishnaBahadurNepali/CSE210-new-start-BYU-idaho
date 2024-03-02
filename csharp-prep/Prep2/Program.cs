using System;
using System.ComponentModel;
using System.Numerics;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade in percentage?  ");
        string grade=Console.ReadLine();
        int gradePercentage=int.Parse(grade);
        int lastDigit=gradePercentage % 10;
        string letter="";
        if((gradePercentage>= 90) && (lastDigit>=3))
            {
              letter="A";
            }
        else if((gradePercentage>= 90)&&(lastDigit<3))
            {
               letter="A-";
            }
        else if((gradePercentage >= 80)&&(lastDigit>=7))
            {
                letter="B+";
            }
        else if((gradePercentage >= 80)&&(lastDigit>=3)&&(lastDigit<7))
            {
                letter="B";
            }
        else if((gradePercentage >= 80)&&(lastDigit<3))
            {
                letter="B-";
            }
        
        else if((gradePercentage>= 70)&&(lastDigit>=7))
            {
                letter="C+";
            }
        else if((gradePercentage>= 70)&&(lastDigit<7)&&(lastDigit>=3))
            {
                letter="C"; 
            }
        else if((gradePercentage>= 70)&&(lastDigit<3))  
            {
                letter="C-";
            }
        else if((gradePercentage>= 60)&&(lastDigit>=7))
            {
                letter="D+";
            }
        else if((gradePercentage>= 60)&&(lastDigit<7)&&(lastDigit>=3))
            {
                letter="D";
            }
        else if((gradePercentage>= 60)&&(lastDigit<3))
            {
               letter="D-";
            }
        else
            {
                letter="F";
               
            }
        Console.WriteLine($"your grade is:{letter}.");
        if(gradePercentage>=70)
            {
                Console.WriteLine("Congratulations You have got passed.");
            }
        else
            {
                Console.WriteLine("Please try again latter.");
            }                                               
                                                              //A >= 90;B >= 80;C >= 70;D >= 60;F < 60//
    }
}