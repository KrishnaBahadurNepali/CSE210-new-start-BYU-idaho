namespace EternalQuest
{
    // Class to manage goals and the user's progress
    class GoalManager
    {
        private List<Goal> goals = new List<Goal>();//This is private set for the score
        private int totalScore = 0; //total score is private/ encapsulated
        private int level = 1; 

        public void CreateNewGoal()//this function is called by program.cs creat a new goal in the class GoalManager
        {
            Console.WriteLine("\nCreate New Goal");//Goals are different, so I have specified which goal 
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.WriteLine("4. Negative Goal");
            Console.Write("Select goal type: ");
            string goalType = Console.ReadLine();

            Console.Write("Enter goal name: ");
            string name = Console.ReadLine();

            Console.Write("Enter goal points: ");
            int points = int.Parse(Console.ReadLine());

            switch (goalType)
            {
                case "1":
                    goals.Add(new SimpleGoal(name, points));//direct access to the goals by add method
                    break;
                case "2":
                    goals.Add(new EternalGoal(name, points));
                    break;
                case "3":
                    Console.Write("Enter target count: ");
                    int targetCount = int.Parse(Console.ReadLine());

                    Console.Write("Enter bonus points: ");
                    int bonusPoints = int.Parse(Console.ReadLine());

                    goals.Add(new ChecklistGoal(name, points, targetCount, bonusPoints));
                    break;
                case "4":
                    goals.Add(new NegativeGoal(name, points));//Negative goals will decline your points
                    break;
                default:
                    Console.WriteLine("Invalid goal type. Please try again.");
                    break;
            }
        }

        public void RecordEvent()
        {
            Console.WriteLine("\nRecord an Event");
            for (int i = 0; i < goals.Count; i++)//initialize i=0, until i<goals.count,increases by +1
            {
                Console.WriteLine($"{i + 1}. {goals[i].Name}");
            }
            Console.Write("Select a goal to record: ");
            int goalIndex = int.Parse(Console.ReadLine()) - 1;

            if (goalIndex >= 0 && goalIndex < goals.Count)
            {
                goals[goalIndex].RecordEvent();
                if (goals[goalIndex] is NegativeGoal)//Negative goal can reduce the point.
                {
                    totalScore -= goals[goalIndex].Points;
                }
                else
                {
                    totalScore += goals[goalIndex].Points;
                    if (goals[goalIndex] is ChecklistGoal checklistGoal && checklistGoal.IsComplete)
                    {
                        totalScore += checklistGoal.BonusPoints;
                    }
                }
                CheckLevelUp();
            }
            else
            {
                Console.WriteLine("Invalid goal selection. Please try again.");
            }
        }

        public void ShowGoals()
        {
            Console.WriteLine("\nGoals:");
            foreach (var goal in goals)
            {
                goal.DisplayProgress();
            }
        }

        public void DisplayScore()
        {
            Console.WriteLine($"\nTotal Score: {totalScore}");
            Console.WriteLine($"Level: {level}");
        }

        private void CheckLevelUp()
        {
            int requiredPoints = level * 1000;
            if (totalScore >= requiredPoints)
            {
                level++;
                Console.WriteLine($"Congratulations! You've leveled up to Level {level}!");
            }
        }

        public void SaveProgress()
        {
            using (StreamWriter writer = new StreamWriter("progress.txt"))
            {
                writer.WriteLine(totalScore);
                writer.WriteLine(level);
                foreach (var goal in goals)
                {
                    writer.WriteLine($"{goal.GetType().Name},{goal.Name},{goal.Points},{(goal is ChecklistGoal checklistGoal ? $"{checklistGoal.CurrentCount},{checklistGoal.TargetCount},{checklistGoal.BonusPoints}" : "0,0,0")}");
                }
            }
            Console.WriteLine("Progress saved.");
        }

        public void LoadProgress()
        {
            if (File.Exists("progress.txt"))
            {
                using (StreamReader reader = new StreamReader("progress.txt"))
                {
                    totalScore = int.Parse(reader.ReadLine());
                    level = int.Parse(reader.ReadLine());
                    goals.Clear();
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        string type = parts[0];
                        string name = parts[1];
                        int points = int.Parse(parts[2]);
                        if (type == nameof(SimpleGoal))
                        {
                            goals.Add(new SimpleGoal(name, points));
                        }
                        else if (type == nameof(EternalGoal))
                        {
                            goals.Add(new EternalGoal(name, points));
                        }
                        else if (type == nameof(ChecklistGoal))
                        {
                            int currentCount = int.Parse(parts[3]);
                            int targetCount = int.Parse(parts[4]);
                            int bonusPoints = int.Parse(parts[5]);
                            var checklistGoal = new ChecklistGoal(name, points, targetCount, bonusPoints)
                            {
                                CurrentCount = currentCount
                            };
                            goals.Add(checklistGoal);
                        }
                        else if (type == nameof(NegativeGoal))
                        {
                            goals.Add(new NegativeGoal(name, points));
                        }
                    }
                }
                Console.WriteLine("Progress loaded.");
            }
            else
            {
                Console.WriteLine("No saved progress found.");
            }
        }
    }
}