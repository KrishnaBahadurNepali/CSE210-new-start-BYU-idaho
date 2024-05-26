using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptureMemorization
{
    public class Scripture
    {
        public Reference Reference { get; private set; }
        public List<Word> Words { get; private set; }

        public Scripture(Reference reference, string text)
        {
            Reference = reference;
            Words = text.Split(' ').Select(word => new Word(word)).ToList();
        }

        public void HideRandomWords()
        {
            Random random = new Random();
            foreach (var word in Words.Where(w => !w.IsHidden).OrderBy(x => random.Next()).Take(3))
            {
                word.Hide();
            }
        }

        public bool AllWordsHidden()
        {
            return Words.All(w => w.IsHidden);
        }

        public override string ToString()
        {
            return $"{Reference}\n{string.Join(" ", Words)}";
        }
    }
}