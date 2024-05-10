using System;
using System.Collections;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
    Console.WriteLine("Welcome to the magic number guess game recited from CSE210.");
    Console.WriteLine("Pick the number in between 1 to 101");
    Random RandomGenerator=new Random();
    int MagicNumber=RandomGenerator.Next(1,101);
    int guess=-1;
    int attempt=0;
    while((guess!=MagicNumber)||(Console.ReadLine().ToLower()=="y"))
        {
            Console.Write("What is your guess number?");
            guess=int.Parse(Console.ReadLine()); //you can also assign variable  like :string number= console.witeline()
            // and latter covert string to number like: guess=int.parse(number);
        attempt++; //This assigned variable with initial 0 can now increase by 1
        if (MagicNumber>guess)
            {
                Console.WriteLine("Try a higher number.");
            }
        else if(MagicNumber<guess)
            {
                Console.WriteLine("Try a lower number.");
            }
        else
            {
                Console.WriteLine($"Congratulations! {guess} is the correct number.");
                Console.WriteLine($"you have took {attempt} attempt to guess it.");
                Console.WriteLine("Thank you for playing game. Would you like to play again? yes for 'Y' No for 'N'. ");
            }
        if((guess>101)||(guess<1))
            {
                Console.WriteLine("You have entered Invalid number.");
            }
        
                
        }

    }
}