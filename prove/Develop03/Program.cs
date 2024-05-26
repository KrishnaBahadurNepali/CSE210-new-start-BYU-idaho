using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ScriptureMemorization
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            List<Scripture> scriptures = LoadScriptures("scriptures.txt");
            Random random = new Random();
            Scripture scripture = scriptures[random.Next(scriptures.Count)];

            while (true)
            {
                Console.Clear();
                Console.WriteLine(scripture);

                if (scripture.AllWordsHidden())
                {
                    Console.WriteLine("All words have been hidden.");
                    break;
                }

                Console.WriteLine("Press Enter to hide words, type 'quiz' for a quiz, or type 'quit' to exit.");
                string input = Console.ReadLine().ToLower();

                if (input == "quit")
                {
                    break;
                }
                else if (input == "quiz")
                {
                    StartQuiz(scripture);
                }
                else
                {
                    scripture.HideRandomWords();
                }
            }
        }

        static List<Scripture> LoadScriptures(string filePath)
        {
            List<Scripture> scriptures = new List<Scripture>();

            foreach (var line in File.ReadAllLines(filePath))
            {
                var parts = line.Split('|');
                var referenceParts = parts[0].Split(':');
                string book = referenceParts[0];
                int chapter = int.Parse(referenceParts[1]);
                int startVerse = int.Parse(referenceParts[2]);
                int endVerse = startVerse;
                if (referenceParts.Length > 3)
                {
                    endVerse = int.Parse(referenceParts[3]);
                }

                Reference reference = (startVerse == endVerse) ? new Reference(book, chapter, startVerse) : new Reference(book, chapter, startVerse, endVerse);
                scriptures.Add(new Scripture(reference, parts[1]));
            }

            return scriptures;
        }

        static void StartQuiz(Scripture scripture)
        {
            Console.Clear();
            Console.WriteLine("Quiz Mode! Fill in the blanks:");

            var hiddenWords = scripture.Words.Where(w => w.IsHidden).ToList();
            if (hiddenWords.Count == 0)
            {
                Console.WriteLine("No words are hidden. Hide some words first.");
                return;
            }

            foreach (var hiddenWord in hiddenWords)
            {
                Console.Write($"Enter the word for \"{hiddenWord.Text}\": ");
                string answer = Console.ReadLine();
                if (answer == hiddenWord.Text)
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine($"Incorrect! The correct word was \"{hiddenWord.Text}\".");
                }
            }

            Console.WriteLine("Press Enter to return to the main program.");
            Console.ReadLine();
        }
    }
}

