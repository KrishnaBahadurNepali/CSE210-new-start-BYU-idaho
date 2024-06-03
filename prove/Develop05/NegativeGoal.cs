namespace EternalQuest
{
    // Negative goal that deducts points when an event is recorded
    class NegativeGoal : Goal
    {
        public NegativeGoal(string name, int points) : base(name, points) 
        { 
        
        }

        public override bool IsComplete => false;

        public override void RecordEvent()
        {
            Console.WriteLine($"Recorded '{Name}' and lost {Points} points!");
        }

        public override void DisplayProgress()
        {
            Console.WriteLine($"{Name} - Negative Goal");
        }
    }
}