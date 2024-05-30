public class ListingActivity : Activity     //ListingActivity inherit from Activity class
{
    private string[] prompts = {        //these are the prompt list
        "List as many things as you can in a certain area of strength or positivity.",
        "What are you grateful for?",
        "What are your talents?",
        "What are your achievements?",
        "How do you liked your day?",
         "What did I learn today?",
        "what is the hardest part of my day?",
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What was the best part of your day?",
        "Write about an experience where you felt the spirit with you today:",
        "Who was the most interesting person you interacted with today?",
        "Write about something that happened for which you are grateful today:",
        "If you had one thing you could do over today, what would it be?",
        "What was the strongest emotion I felt today?",
        "Write about an act of service you either witnessed or performed today:>",
        "Write about a tender mercy you noticed today:",
        "Write about a positive interaction you had with someone else today:",
        "Write about something you noticed that reminded you of Jesus Christ today:",
        "Write about an experience you had that allowed you to teach someone else today:",
        "Good habits to write a journal, write your one thought"
    };

    public ListingActivity() : base("Listing", "Guide the user to think broadly.")
    {
    }

    public override void Execute()
    {
        Start();
        Random random = new Random();
        Console.WriteLine(prompts[random.Next(prompts.Length)]);
        PauseWithAnimation(_Duration);
        End();
    }
}