class BaseActivity
{
    private int _duration;
    private string _activityName;
    private string _activityDescription;
    private DateTime _endTime;
    public BaseActivity(string name, string description)
    {
        _activityDescription = description;
        _activityName = name;
       _duration = ObtainDuration();
    }
    public void StartActivity()
    {
        Console.WriteLine(_activityName);
        RunCountDownMessage(_activityDescription, 5);
    }
    public void DisplayEnding()
    {
        DisplaySpinnerMessage("Thanks for participating in this activity!!", 5);

    }
    public void StartTimer()
    {
        _endTime = DateTime.Now.AddSeconds(_duration);
    }
    public bool HasTimerExpired()
    {
        return DateTime.Now > _endTime;
    }
    public void RunCountDownMessage(string message, int seconds)
    {
        Console.CursorVisible = false;
        for(int i = seconds; i > 0; i--){
            Console.WriteLine($"{message} - {i}");
            Thread.Sleep(1000);
            Console.Clear();
        }
        Console.CursorVisible = true;
    }
    public void DisplaySpinnerMessage(string message, int seconds)
    {
        Console.CursorVisible = false;
        Console.Clear();
        Console.Write($"{message} ");
        string spinnerAnimation = "-\\|/";
        int index = 0;
        for (int i=0; i<seconds*3; i++)
        {
            Console.Write($"{spinnerAnimation[index++ % spinnerAnimation.Length]}");
            Console.Write("\b");
            Thread.Sleep(333);
        }
        Console.Clear();
        Console.CursorVisible = true;
    }
    public int ObtainDuration()
    {
        Console.WriteLine("How many seconds would you like to do this activity? ");
        return int.Parse(Console.ReadLine());
    }
    
}