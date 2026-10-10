using System.IO; 
class Journal
{
    public List<JournalEntry> _entries = new List<JournalEntry>();
 
    public void DisplayJournal()
    {
        Console.WriteLine($"You have {_entries.Count} journal entries.");

        foreach (JournalEntry entry in _entries)
        {
            entry.DisplayJournalEntry();
        }
    }

    public void CreateEntry()
    {
        JournalEntry newEntry = new JournalEntry();
        newEntry.CreateJournalEntry();
        _entries.Add(newEntry);
    }

    public void WriteToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach(JournalEntry entry in _entries)
            {
                outputFile.WriteLine(entry.CreateFileSystemString());
            }
        }
    }

    public void ReadFromFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        _entries.Clear();

        foreach (string line in lines)
        {
            string[] parts = line.Split('#');

            string date = parts[0];
            string question = parts[1];
            string entryText = parts[2];

            JournalEntry entry = new JournalEntry();

            entry.CreateJournalEntry(date, question, entryText);

            _entries.Add(entry);
        }
    }
    
}



    
        