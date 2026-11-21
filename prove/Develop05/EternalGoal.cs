using System.ComponentModel;

class EternalGoal : BaseGoal
{
    private int _numberOfCompletions;

    public EternalGoal(string name, string description, int points, bool complete, string goalType, int numberOfCompletions)
    : base(name, description, points, complete, goalType)
    {
        _numberOfCompletions = numberOfCompletions;
    }

    public EternalGoal()
    : base("EternalGoal")
    {
        _numberOfCompletions = 0;
    }

    public override int RecordEvent()
    {
        _numberOfCompletions++;
        return GetPoints();
    }

    public override string GetConsoleString()
    {
        return base.GetConsoleString() + $", Completed {_numberOfCompletions} times";

    }

    public override string GetFileSystemString()
    {
        return $"{GetGoalType()}|{GetName()}|{GetDescription()}|{GetPoints()}|{GetComplete()}|{_numberOfCompletions}";
    }
}