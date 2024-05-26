using System;

namespace ScriptureMemorization
{
    public class Reference
    {
        public string Book { get; private set; } //I have set all the second parameters as private instead of setting them private_Name separately
        public int Chapter { get; private set; }//You see all the 2nd paramtras sets to private
        public int StartVerse { get; private set; }
        public int EndVerse { get; private set; }
        public bool IsRange { get; private set; }

        public Reference(string book, int chapter, int verse) //Applying encapsulation for Book, Chapter,StartVerse,EndVerse and Is Range
        {
            Book = book;//These are the equetions which the public parameter such as book and private Book equits as the same value
            Chapter = chapter;
            StartVerse = verse;
            EndVerse = verse;
            IsRange = false;
        }

        public Reference(string book, int chapter, int startVerse, int endVerse)//We could also make base class here for inheritig the base value to derive class
        //But we just keep them as a method but adding more parameters.
        {
            Book = book;
            Chapter = chapter;
            StartVerse = startVerse;
            EndVerse = endVerse;
            IsRange = true;
        }

        public override string ToString() //This now calls to the Tostring() function 
        {
            return IsRange ? $"{Book} {Chapter}:{StartVerse}-{EndVerse}" : $"{Book} {Chapter}:{StartVerse}"; //This  will now returns the value to the call section
        }
    }
}