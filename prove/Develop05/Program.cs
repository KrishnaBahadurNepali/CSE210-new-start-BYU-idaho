using System;

namespace EternalQuest
{
    // Main program class
    class Program
    {
        static void Main(string[] args)
        {
            GoalManager goalManager = new GoalManager();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nEternal Quest Menu");
                Console.WriteLine("1. Create new goal");
                Console.WriteLine("2. Record an event");
                Console.WriteLine("3. Show goals");
                Console.WriteLine("4. Display score");
                Console.WriteLine("5. Save progress");
                Console.WriteLine("6. Load progress");
                Console.WriteLine("7. Exit");
                Console.Write("Select an option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        goalManager.CreateNewGoal();
                        break;
                    case "2":
                        goalManager.RecordEvent();
                        break;
                    case "3":
                        goalManager.ShowGoals();
                        break;
                    case "4":
                        goalManager.DisplayScore();
                        break;
                    case "5":
                        goalManager.SaveProgress();
                        break;
                    case "6":
                        goalManager.LoadProgress();
                        break;
                    case "7":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}
