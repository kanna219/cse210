using System;
using System.Collections.Generic;

class ListingActivity : BaseActivity
{
    private List<FlaggedString> _prompts;

    public ListingActivity(string name, string description)
        : base(name, description)
    {
        _prompts = new List<FlaggedString>();

        SetPrompts();
    }

    public void RunActivity()
    {
        StartActivity();

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();

        string prompt = GetPromptString(_prompts);

        Console.WriteLine($"--- {prompt} ---");

        RunCountDownMessage("You may begin in", 5, false);

        List<string> responses = new List<string>();

        int count = 0;
        while (!HasTimerExpired())
        {
            Console.Write("> ");

            string response = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(response))
            {
                responses.Add(response);
                count++;
            }
        }

        Console.WriteLine();
        if (count == 1)
        {
            Console.WriteLine("You listed 1 item!");
        }
        else
        {
            Console.WriteLine($"You listed {count} items!");
        }

        DisplayEnding();
    }

    private void SetPrompts()
    {
        _prompts = new List<FlaggedString>
        {
            new FlaggedString("Who are people that you appreciate?", false),
            new FlaggedString("What are personal strengths of yours?", false),
            new FlaggedString("Who are people that you have helped this week?", false),
            new FlaggedString("What are some things that make you happy?", false),
            new FlaggedString("Who are some of your personal heroes?", false)
        };
    }

    private void ResetPromptsUsage()
    {
        foreach (FlaggedString prompt in _prompts)
        {
            prompt.ResetHasBeenUsed();
        }
    }
}