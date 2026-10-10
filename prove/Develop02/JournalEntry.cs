class JournalEntry
{
    public string _date;
    public string _prompt;
    public string _response;

    public void DisplayJournalEntry()
    {
        Console.WriteLine($"{_date}, {_prompt}");
        Console.WriteLine($"{_response}");
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

        Random random = new Random();
        int index = random.Next(prompts.Length);

        _date = DateTime.Now.ToString();
        _prompt = prompts[index];
        Console.WriteLine($"{_prompt}: ");
        _response = Console.ReadLine();
    }

    public string CreateFileSystemString()
    {
        return $"{_date}#{_prompt}#{_response}";
    }

    public void CreateJournalEntry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }
}