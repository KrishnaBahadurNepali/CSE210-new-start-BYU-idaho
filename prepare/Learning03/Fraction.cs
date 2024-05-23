using System;

public class Fraction // this is fraction class
{
    private int _top;  //this makes private encapsulated top numerator
    private int _bottom; // Denominator

    public Fraction()
    {
        // Default to 1/1
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom) //two parameters are called from main program
    {
        _top = top; //connection between private and public / encapsulation
        _bottom = bottom;
    }

    public string GetFractionString() // function for calling GetFractionString
    {
        // Notice that this is not stored as a member variable.
        // Is is just a temporary, local variable that will be recomputed each time this is called.
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue() //function for calling GetDecimalValue
    {
        // Notice that this is not stored as a member variable.
        // Is will be recomputed each time this is called.
        return (double)_top / (double)_bottom;
    }
}