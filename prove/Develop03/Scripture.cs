class Scripture
{
    private List<Word> _words;
    // TODO - Add scriptre Reference
    private ScriptureReference _reference;

    public Scripture(string bookName, int chapter, int verse, string text)
    {
        _words = ConvertToWordList(text);

        // test - _words[7].Hide();
        // todo
        _reference = new ScriptureReference(bookName, chapter, verse);
    }

    public Scripture(string bookName, int chapter, int startVerse, int endVerse, string text)
    {
        // todo
        _words = ConvertToWordList(text);
        _reference = new ScriptureReference(bookName, chapter, startVerse, endVerse);
    }

    public Scripture(ScriptureReference reference, string text)
    {
        // todo
        _reference = reference;
        _words = ConvertToWordList(text);
    }

    public void HideSomeWords()
    {
        Random random = new Random();
        for (int i = 0; i < 3; i++)
        {
            int index = random.Next(0, _words.Count);
            _words[index].Hide();
        }

    }
    public void ShowScripture()
    {
        _reference.DisplayScriptureReference();

        foreach(Word word in _words)
        {
            word.Display();
        }
    }

    public int NumberOfHiddenWords()
    {
        int count = 0;

        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                count++;
            }
        }

        return count;
    }

    public bool IsCompletelyHidden()
    {
        return NumberOfHiddenWords() == _words.Count;
    }

    // TODO - Add constructor for Scripturereference

    /********************************************************
    * ConvertToWordList() - this method will recieve a string parmater,
    * which is a paragraph of text. It will slipt that text into words
    * and add those words to a List<word> and return the list.
    *********************************************************/

    private List<Word> ConvertToWordList(string text)
    {
        List<Word> tempWordList = new List<Word>();
        string[] tempWords = text.Split(' ');
        foreach(string w in tempWords)
        {
            Word tempWord = new Word(w);
            tempWordList.Add(tempWord);
        }

        return tempWordList;
    }
}