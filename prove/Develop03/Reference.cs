using System;

namespace ScriptureMemorization
{
    public class Reference
    {
        public string Book { get; private set; }
        public int Chapter { get; private set; }
        public int StartVerse { get; private set; }
        public int EndVerse { get; private set; }
        public bool IsRange { get; private set; }

        public Reference(string book, int chapter, int verse)
        {
            Book = book;
            Chapter = chapter;
            StartVerse = verse;
            EndVerse = verse;
            IsRange = false;
        }

        public Reference(string book, int chapter, int startVerse, int endVerse)
        {
            Book = book;
            Chapter = chapter;
            StartVerse = startVerse;
            EndVerse = endVerse;
            IsRange = true;
        }

        public override string ToString()
        {
            return IsRange ? $"{Book} {Chapter}:{StartVerse}-{EndVerse}" : $"{Book} {Chapter}:{StartVerse}";
        }
    }
}