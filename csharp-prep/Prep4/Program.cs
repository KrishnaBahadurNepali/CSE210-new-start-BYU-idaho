using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Welcome in CSE210");
        List<int> numbers = new List<int>(); // you can see here list<variable type(int)> storeVariable(numbers)
        // We can use do-while loop as well
        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter the number if you want to stop press '0': ");
            
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);
            
            // Only add the number to the list if it is not 0
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // first of all  Compute the sum
        int sum = 0;
        foreach (int number in numbers) // same as for loop in python.
        {
            sum += number; //sim=sum+number;
        }

        Console.WriteLine($"The sum is: {sum}");
     //  Computing the average using float
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        //  Find the max
        // There are several ways to do this, such as sorting the list
        
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                // if this number is greater than the max, we have found the new max!
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");
        Console.WriteLine("The sorted list is: ");
        numbers.Sort();
        foreach(int number in numbers)
        {
            Console.WriteLine(number);
        }

    }

}