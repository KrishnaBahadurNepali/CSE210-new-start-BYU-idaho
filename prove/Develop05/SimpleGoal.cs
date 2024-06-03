namespace EternalQuest
{
    // Simple goal that can be marked as complete
    class SimpleGoal : Goal
    {
        private bool isComplete; //I choosed to make private the iscomplete variable 

        public SimpleGoal(string name, int points) : base(name, points)
        {
            isComplete = false;
        }

        public override bool IsComplete => isComplete;

        public override void RecordEvent()
        {
            isComplete = true;
            Console.WriteLine($"Completed '{Name}' and earned {Points} points!");
        }

        public override void DisplayProgress()
        {
            Console.WriteLine($"{Name} - {(IsComplete ? "[x]" : "[ ]")}");
        }
    }
}