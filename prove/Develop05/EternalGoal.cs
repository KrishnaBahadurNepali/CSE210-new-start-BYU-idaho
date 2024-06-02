namespace EternalQuest
{
    // Eternal goal that is never complete
    class EternalGoal : Goal
    {
        public EternalGoal(string name, int points) : base(name, points) { }

        public override bool IsComplete => false;

        public override void RecordEvent()
        {
            Console.WriteLine($"Recorded '{Name}' and earned {Points} points!");
        }

        public override void DisplayProgress()
        {
            Console.WriteLine($"{Name} - Eternal Goal");
        }
    }
}