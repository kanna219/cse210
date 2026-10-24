class ScriptureReference
{
    private string _bookName;
    private int _chapter;
    private int[] _verse;

    public ScriptureReference(string name, int chapter, int verse)
    {
        _bookName = name;
        _chapter = chapter;
        _verse = new int[] { verse };
    }

    public ScriptureReference(string name, int chapter, int startVerse, int endVerse)
    {
        _bookName = name;
        _chapter = chapter;

        _verse = new int[] { startVerse, endVerse };
    }

    private string GetScriptureReferenceString()
    {
        string reference = $"{_bookName} {_chapter}:{_verse[0]}";

        if (_verse.Length > 1)
        {
            reference += $"-{_verse[1]}";
        }

        return reference;
    }

    public string GetScriptureReference()
    {
        return GetScriptureReferenceString();
    }

    public void DisplayScriptureReference()
    {
        Console.WriteLine(GetScriptureReference());
    }
}