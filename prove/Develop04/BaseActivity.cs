using System;
using System.Collections.Generic;
using System.Threading;
class BaseActivity
{
    private int _duration;
    private DateTime _endTime;
    private string _name;
    private string _description;
    public BaseActivity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void StartActivity()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();

        ObtainDuration();

        RunSpinnerMessage("Get ready... ", 5);
        StartTimer();
    }

    public void ObtainDuration()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
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
        for(int i = seconds; i>0; i--)
        {
            Console.Clear();
            Console.WriteLine($"{message} - {i}");
            Thread.Sleep(1000);
        }
        Console.CursorVisible = true;
        Console.WriteLine();
    }

    public void RunSpinnerMessage(string message, int seconds)
    {
        Console.Clear();
        Console.Write(message); 
        Console.CursorVisible = false;
        DateTime now = DateTime.Now;
        DateTime endTime = now.AddSeconds(seconds);

        // for(int i=0; i < seconds; i++)
        while (DateTime.Now < endTime)
        {
            Console.Write("+");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(200);
            Console.Write("\b");
        }
        Console.CursorVisible = true;
        Console.WriteLine();

    }

    public void DisplayEnding()
    {
        Console.WriteLine();
        RunSpinnerMessage("Good job!", 3);
        RunSpinnerMessage($"You have completed {_name} for {_duration} seconds.", 3);
    }

    public string GetPromptString(List<FlaggedString> prompts)
    {
        List<FlaggedString> availablePrompts = new List<FlaggedString>();

        foreach (FlaggedString prompt in prompts)
        {
            if (!prompt.GetHasBeenUsed())
            {
                availablePrompts.Add(prompt);
            }
        }

        if (availablePrompts.Count == 0)
        {
            foreach (FlaggedString prompt in prompts)
            {
                prompt.ResetHasBeenUsed();
                availablePrompts.Add(prompt);
            }
        }

        Random random = new Random();

        int index = random.Next(availablePrompts.Count);

        FlaggedString selectedPrompt = availablePrompts[index];

        selectedPrompt.SetHasBeenUsed();

        return selectedPrompt.GetPrompt();
    }
}