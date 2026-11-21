class CheckListGoal : BaseGoal
{
    private int _numberOfCompletions;
    private int _maxCompletions;
    private int _bonusPoints;

    public  CheckListGoal(string name, string description, int points, bool complete, string goalType, int numberOfCompletions, int maxCompletions, int bonusPoints)
    : base(name, description, points, complete, goalType)
    {
        _numberOfCompletions = numberOfCompletions;
        _maxCompletions = maxCompletions;
        _bonusPoints = bonusPoints;
    }

    public CheckListGoal()
    : base("CheckListGoal")
    {
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _maxCompletions = int.Parse(Console.ReadLine());

        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonusPoints = int.Parse(Console.ReadLine());

        _numberOfCompletions = 0;
    }

    public override int RecordEvent()
    {
        if (_numberOfCompletions >= _maxCompletions)
        {
            return 0;
        }

        _numberOfCompletions++;

        int earnPoints = GetPoints();

        if (_numberOfCompletions == _maxCompletions)
        {
            MarkComplete();
            earnPoints += _bonusPoints;
        }

        return earnPoints;
    }

    public override string GetConsoleString()
    {
        return base.GetConsoleString() + $", Completed {_numberOfCompletions}/{_maxCompletions} times"; 
    }

    public override string GetFileSystemString()
    {
        return $"{GetGoalType()}|{GetName()}|{GetDescription()}|{GetPoints()}|{GetComplete()}|{_numberOfCompletions}|{_maxCompletions}|{_bonusPoints}";
    }
}