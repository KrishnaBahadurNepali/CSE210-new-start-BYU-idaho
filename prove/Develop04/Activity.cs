using System;
using System.Threading;

public abstract class Activity      //parent class for other Breathing,Listing,and Reflection activities
{
    protected string _Name; //protected can be only acced by the class and derived class
    protected string _Description;//this can be access by the same class 
    protected int _Duration;

    public Activity(string name, string description)//If u don't need _Duration parameter, you don't have to send by the methods
    {
        _Name = name;
        _Description = description;
    }

    public void Start() //if invoked by other class, this function Start() will then execute
    {
        Console.Clear();//This clear() function can clears the previous screen
        Console.WriteLine($"Starting {_Name} Activity");
        Console.WriteLine(_Description);
        Console.Write("Enter the duration of the activity in seconds: ");
        _Duration = int.Parse(Console.ReadLine());//shortcut method
        Console.WriteLine("Prepare to begin...");
        PauseWithAnimation(3);  //StartAnimation, StopAnimation and PausewithAnimation methods handles the animation for 3 secods
    }

    public void End()   //if invoked by other class, this function End() will then execute
    {
        Console.WriteLine("Good job! You've completed the activity.");
        Console.WriteLine($"You completed the {_Name} activity for {_Duration} seconds.");//No other class need _Duration parameter
        PauseWithAnimation(3);
    }

    protected void PauseWithAnimation(int seconds)  //this method is called by other function members. exampe Start() and End() function from previous lines
    {
        for (int i = 0; i < seconds; i++)   // loop start from 0 to 2 when you have 3 integer value
        {
            Console.Write(".");
            Thread.Sleep(1000); //current execution is now pause for 1000 milisecond and start after that
        }
        Console.WriteLine();
    }

    public abstract void Execute();
}