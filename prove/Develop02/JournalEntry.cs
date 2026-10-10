class JournalEntry
{
    public string _date;
    public string _prompt;
    public string _response;
    public string _mood;

    public void DisplayJournalEntry()
    {
        Console.WriteLine($"{_date}, {_prompt}");
        Console.WriteLine($"{_response}");
        Console.WriteLine($"Mood: {_mood}");
    }

    public void CreateJournalEntry()
    {
        string [] prompts =
        [
            "How was your day? ",
            "Talk about someone you met.",
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What is one thing I learned today?", // I added my own questions from here
            "What is one small thing that made you happy?",
            "What is one thing that made your day special? ",
            "What did you eat for dinner?",
            "What did you eat for lunch?"
        ];

        string[] hints = 
        [ 
            "Think about what happened today and how you felt.", 
            "Describe the person and something you remember about them.", 
            "Think about someone who surprised you or taught you something.", 
            "Remember a moment that made you smile or feel proud.", 
            "Think about a moment when you felt guided, helped, or blessed.", 
            "Describe the emotion and what caused it.", 
            "Think about what you would change and why.", 
            "Write about something new you discovered or practiced.", 
            "Remember a small moment that made you smile.", 
            "Think about what made today different from other days.", 
            "Describe what you ate and how you liked it.", 
            "Describe your lunch and who you ate with, if anyone." ];

        Random random = new Random();
        int index = random.Next(prompts.Length);

        _date = DateTime.Now.ToString();
        _prompt = prompts[index];
        Console.WriteLine($"{_prompt}: ");
        Console.WriteLine($"Writing idea: {hints[index]}");
        Console.Write("Your response: ");
        _response = Console.ReadLine();
        Console.WriteLine("");

        int moodChoice = 0;
        while (moodChoice < 1 || moodChoice > 6)
        {
            Console.WriteLine("How did you feel today?");
            Console.WriteLine("1. 😊 Happy");
            Console.WriteLine("2. 😆 Excited");
            Console.WriteLine("3. 😌 Calm");
            Console.WriteLine("4. 😢 Sad");
            Console.WriteLine("5. 😫 Stressed");
            Console.WriteLine("6. 😪 Tired");
            Console.Write("Choose your mood (1-6): ");
            Console.WriteLine("");
            moodChoice = int.Parse(Console.ReadLine());
        }

        switch (moodChoice)
        {
            case 1:
                _mood = "😊 Happy";
                break;
            case 2:
                _mood = "😆 Excited";
                break;
            case 3:
                _mood = "😌 Calm";
                break;
            case 4:
                _mood = "😢 Sad";
                break;
            case 5:
                _mood = "😫 Stressed";
                break;
            case 6:
                _mood = "😪 Tired";
                break;
        }
    }

    public string CreateFileSystemString()
    {
        return $"{_date}#{_prompt}#{_response}#{_mood}";
    }

    public void CreateJournalEntry(string date, string prompt, string response, string mood)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
        _mood = mood;
    }
}