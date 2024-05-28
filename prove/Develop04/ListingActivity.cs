public class ListingActivity : Activity     //ListingActivity inherit from Activity class
{
    private string[] prompts = {        //these are the prompt list
        "List as many things as you can in a certain area of strength or positivity.",
        "What are you grateful for?",
        "What are your talents?",
        "What are your achievements?"
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