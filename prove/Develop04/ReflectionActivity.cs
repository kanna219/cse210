using System;
using System.Collections.Generic;

class ReflectionActivity : BaseActivity
{
    private List<FlaggedString> _prompts;
    private List<FlaggedString> _questions;

    public ReflectionActivity(string name, string description)
        : base(name, description)
    {
        _prompts = new List<FlaggedString>();
        _questions = new List<FlaggedString>();

        SetPromptsAndQuestions();
    }

    public void RunActivity()
    {
        StartActivity();

        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();

        string prompt = GetPromptString(_prompts);

        Console.WriteLine($"--- {prompt} ---");

        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();

        RunCountDownMessage("You may begin in: ", 5);

        while (!HasTimerExpired())
        {
            string question = GetPromptString(_questions);

            Console.WriteLine();
            RunSpinnerMessage(question, 10);

           
        }

        DisplayEnding();
    }

    private void SetPromptsAndQuestions()
    {
        _prompts = new List<FlaggedString>
        {
            new FlaggedString("Think of a time when you stood up for someone else.", false),
            new FlaggedString("Think of a time when you did something really difficult.", false),
            new FlaggedString("Think of a time when you helped someone in need.", false),
            new FlaggedString("Think of a time when you did something truly selfless.", false)
        };

        _questions = new List<FlaggedString>
        {
            new FlaggedString("Why was this experience meaningful to you?", false),
            new FlaggedString("Have you ever done anything like this before?", false),
            new FlaggedString("How did you get started?", false),
            new FlaggedString("How did you feel when it was complete?", false),
            new FlaggedString("What made this time different from other times?", false),
            new FlaggedString("What did you learn about yourself through this experience?", false),
            new FlaggedString("How can you keep this experience in mind in the future?", false)
        };
    }

    private void ResetPromptsUsage()
    {
        foreach (FlaggedString prompt in _prompts)
        {
            prompt.ResetHasBeenUsed();
        }

        foreach (FlaggedString question in _questions)
        {
            question.ResetHasBeenUsed();
        }
    }
}
