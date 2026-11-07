
class FlaggedString
{
    private string _prompt;
    private bool _hasBeenUsed;

    public FlaggedString(string prompt, bool hidden)
    {
        _prompt = prompt;
        _hasBeenUsed = hidden;
    }

    public string GetPrompt()
    {
        return _prompt;
    }

    public void SetHasBeenUsed()
    {
        _hasBeenUsed = true;
    }

    public bool GetHasBeenUsed()
    {
        return _hasBeenUsed;
    }

    public void ResetHasBeenUsed()
    {
        _hasBeenUsed = false;
    }
}
