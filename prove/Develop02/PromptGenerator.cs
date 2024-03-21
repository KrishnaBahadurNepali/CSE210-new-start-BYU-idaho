using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

public class PromptGenerator
{
    public List<string> _Prompts; //this is _prompt list for different prompt questions.
    public string GetRandomPrompt() //calling 
    {
    _Prompts=new List<string>()//this is list of the prompt
        {
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
        "Write about an experience you had that allowed you to teach someone else today:"
        };
     Random random = new Random();// new random inisiation
    return _Prompts[random.Next(_Prompts.Count)];//prompt.count do not repeat the question
    
    }
}