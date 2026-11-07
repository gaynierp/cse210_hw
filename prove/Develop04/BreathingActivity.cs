class BreathingActivity : BaseActivity
{
    public BreathingActivity(string name, string description):base(name, description)
    {
    }
    public void RunActivity()
    {
        // Call StatrtActivity()
        RunCountDownMessage("Get Ready", 5);
        StartTimer();
        while(! HasTimerExpired())
        {
            RunCountDownMessage("Breathe in", 4);
            RunCountDownMessage("Breathe out", 6);
        }
        DisplayEnding();
    }
}