namespace EternalQuest
{
    // Checklist goal that must be accomplished a certain number of times
    class ChecklistGoal : Goal
    {
        public int TargetCount { get; }
        public int CurrentCount { get; set; }  // Add setter for CurrentCount //I Have used getter and setter
        public int BonusPoints { get; }//Making these variable a  public can be easier to get access from other classes

        public ChecklistGoal(string name, int points, int targetCount, int bonusPoints) : base(name, points)
        {
            TargetCount = targetCount;
            BonusPoints = bonusPoints;
            CurrentCount = 0;
        }

        public override bool IsComplete => CurrentCount >= TargetCount;

        public override void RecordEvent()
        {
            CurrentCount++;
            Console.WriteLine($"Recorded '{Name}' and earned {Points} points!");
            if (IsComplete)
            {
                Console.WriteLine($"Completed '{Name}' and earned bonus {BonusPoints} points!");
            }
        }

        public override void DisplayProgress()
        {
            Console.WriteLine($"{Name} - Completed {CurrentCount}/{TargetCount} times {(IsComplete ? "[x]" : "[ ]")}");
        }
    }
}
