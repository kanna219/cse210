class Word
{
    private string _word;
    private bool _hidden;
    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }

    public bool IsHidden()
    {
        return _hidden;
    }

    public void Hide()
    {
        _hidden = true;
    }

    public string GetWordString()
    {
        string returnString= "";
        if (_hidden)
        {
            // for (int i = 0; i < _word.Length; i++)
            foreach(char c in _word)
            {
                returnString += '_';
            }
        }
        else
        {
            returnString = _word;
        }
        return returnString;
    }

    public void Display()
    {
        Console.WriteLine($"{GetWordString()} ");
    }
}