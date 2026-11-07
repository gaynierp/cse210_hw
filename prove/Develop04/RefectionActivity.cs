class ReflectionActivity : BaseActivity
{
    private List<string> _prompts;
    private List<string> _questions;
    public ReflectionActivity(string name, string description):base(name, description)
    {
        _prompts = ["Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."];

    }

    public string GenerateRandomPrompt()
    {
            Random number = new Random();
            return _prompts[number.Next(0,_prompts.Count)];
    }
    public string GenerateRandomQuestion()
    {
        _questions = ["Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"];
        Random number = new Random();
        return _questions[number.Next(0,_questions.Count)];
    }
    public void RunActivity()
    {
        StartActivity();
        StartTimer();
        Console.Clear();
        RunCountDownMessage(GenerateRandomPrompt(), 5);
        while (! HasTimerExpired()){
            DisplaySpinnerMessage(GenerateRandomQuestion(), 5);
        }
        DisplayEnding();
    }
}