public class ReflectionActivity : Activity
{
    private string[] questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "What did you learn about yourself?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity() : base("Reflection", "Guide the user to think deeply about an experience.")
    {
    }

    public override void Execute()
    {
        Start();
        Random random = new Random();
        for (int i = 0; i < Duration / 5; i++)
        {
            Console.WriteLine("Think about a time when you were successful or demonstrated strength.");
            PauseWithAnimation(5);
            Console.WriteLine(questions[random.Next(questions.Length)]);
            PauseWithAnimation(5);
        }
        End();
    }
}

