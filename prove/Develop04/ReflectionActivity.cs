public class ReflectionActivity : Activity      //ReflectionActivity inherit from Activity base class
{
    private string[] questions = {      //reflecting  prompt list 
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "What did you learn about yourself?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity() : base("Reflection", "Guide the user to think deeply about an experience.")
    {
    }

    public override void Execute() //This Override keyword is for multiple //different behaviour activity where polimerphism is applied
    {
        Start();
        Random random = new Random();
        for (int i = 0; i < _Duration / 5; i++)
        {
            Console.WriteLine("Think about a time when you were successful or demonstrated strength.");
            PauseWithAnimation(5);
            Console.WriteLine(questions[random.Next(questions.Length)]);
            PauseWithAnimation(5);
        }
        End();
    }
}

