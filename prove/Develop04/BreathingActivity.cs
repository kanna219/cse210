
class BreathingActivity : BaseActivity
{
    public void RunActivity()
    {
        StartActivity();

        while (!HasTimerExpired())
        {
            RunCountDownMessage("Breathe in...", 4);

            if (HasTimerExpired())
            {
                break;
            }

            RunCountDownMessage("Breathe out...", 6);
        }

        DisplayEnding();
    }
    public BreathingActivity(string name, string description) : base(name, description)
    {
        // call StartActivity() method
        // StartActivity();

        // RunCountDownMessage("Get Ready", 5);
        // DateTime endTime = DateTime.Now.AddSeconds(20); // delete later
        // while (DateTime.Now < endTime)
        // while (! HasTimerExpired()) // Add when code is ready
        // {
        //     RunCountDownMessage("Breath in", 4);
        //     RunCountDownMessage("Breath out", 6);
        // }


        // CALL EndActivity()
    }    
}