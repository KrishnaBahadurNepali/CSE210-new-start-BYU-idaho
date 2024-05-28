public class BreathingActivity : Activity    // creating BreathingActivity as a child class for Activity
{
    public BreathingActivity() : base("Breathing", "Help the user pace their breathing.")
    {
    }

    public override void Execute()
    {
        Start();
        int halfDuration = _Duration / 2;
        for (int i = 0; i < halfDuration; i++)
        {
            Console.WriteLine("Breathe in...");
            PauseWithAnimation(2);
            Console.WriteLine("Breathe out...");
            PauseWithAnimation(2);
        }
        End();
    }
}

