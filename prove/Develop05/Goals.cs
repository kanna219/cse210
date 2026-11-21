using System;
using System.Collections.Generic;
using System.IO;

class Goals
{
    private List<BaseGoal> _goals;
    private int _totalScore;

    public Goals()
    {
        _goals = new List<BaseGoal>();
        _totalScore = 0;
    }

    public void AddGoal(BaseGoal goal)
    {
        _goals.Add(goal);
    }

    public void DisplayGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetConsoleString()}");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"You have {_totalScore} points.");
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("There are no goals.");
            return;
        }

        DisplayGoals();

        Console.Write("Which goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine());

        if (choice < 1 || choice > _goals.Count)
        {
            Console.WriteLine("That is not a valid goal.");
            return;
        }

        int points = _goals[choice - 1].RecordEvent();
        _totalScore += points;

        Console.WriteLine($"Congratulations! You earned {points} points!");
        Console.WriteLine($"You now have {_totalScore} points.");
    }

    public void SaveGoals()
    {
        Console.Write("What is the name of the file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_totalScore);

            foreach (BaseGoal goal in _goals)
            {
                outputFile.WriteLine(goal.GetFileSystemString());
            }
        }

        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals()
    {
        Console.Write("What is the name of the file? ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("The file does not exist.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);

        _goals.Clear();
        _totalScore = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');

            string goalType = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);
            bool complete = bool.Parse(parts[4]);

            if (goalType == "SimpleGoal")
            {
                SimpleGoal goal = new SimpleGoal(
                    name, description, points, complete, goalType);

                _goals.Add(goal);
            }
            else if (goalType == "EternalGoal")
            {
                int completions = int.Parse(parts[5]);

                EternalGoal goal = new EternalGoal(
                    name, description, points, complete,
                    goalType, completions);

                _goals.Add(goal);
            }
            else if (goalType == "CheckListGoal")
            {
                int completions = int.Parse(parts[5]);
                int maxCompletions = int.Parse(parts[6]);
                int bonusPoints = int.Parse(parts[7]);

                CheckListGoal goal = new CheckListGoal(
                    name, description, points, complete,
                    goalType, completions,
                    maxCompletions, bonusPoints);

                _goals.Add(goal);
            }
        }

        Console.WriteLine("Goals loaded successfully.");
    }
}