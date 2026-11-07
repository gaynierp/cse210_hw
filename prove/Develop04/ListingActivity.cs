class ListingActivity : BaseActivity
{
    private List<string> _prompts;
    private int _listCount;
    public ListingActivity(string name, string description) : base(name, description)
    {
        _prompts = ["Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"];
    }
        public string GenerateRandomPrompt()
    {
            Random number = new Random();
            return _prompts[number.Next(0,_prompts.Count)];
    }
    public void RunActivity()
    {
        StartActivity();
        StartTimer();
        RunCountDownMessage(GenerateRandomPrompt(), 5);
        CountInput();
        Console.WriteLine($"You listed {_listCount} items");
        DisplayEnding();

    }
    public void CountInput()
    {
        while(! HasTimerExpired())
        {
            Console.ReadLine();
            _listCount +=1;
        }
    }
}