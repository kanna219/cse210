abstract class BaseGoal
{
    private string _name;
    private string _description;
    private int _points;
    private bool _complete;
    private string _goalType;

    public BaseGoal(string name, string description, int points, bool complete, string goalType)
    {
        _name = name;
        _description = description;
        _points = points;
        _complete = complete;
        _goalType = goalType;
    }
    public BaseGoal(string goalType)
    {
        SetName();
        SetDescription();
        SetPoints();
        _complete = false;
        _goalType = goalType;
    }

    private void SetName()
    {
        Console.Write("What is the name of your goal: ");
        _name = Console.ReadLine();
    }

    private void SetDescription()
    {
        Console.Write($"What is the descrription of your {_name} goal: ");
        _description = Console.ReadLine();
    }

    private void SetPoints()
    {
        Console.Write($"What is the points for your {_name} goal: ");
        _points = int.Parse(Console.ReadLine());
    }
    public virtual string GetConsoleString()
    {
        string completeString = " ";

        if (_complete)
            completeString = "X";

        return $"[{completeString}] {_goalType} Goal Name: {_name}, Description: {_description}, Points: {_points}";
    }
    public bool IsComplete()
    {
        return _complete;
    }
    public int MarkComplete()
    {
        if (_complete)
        {
            return 0;
        }

        _complete = true;
        return _points;
    }

    public abstract int RecordEvent();

    public int GetPoints()
    {
        return _points;
    }

    public virtual string GetFileSystemString()
    {
        return $"{_goalType}|{_name}|{_description}|{_points}|{_complete}";
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public bool GetComplete()
    {
        return _complete;
    }

    public string GetGoalType()
    {
        return _goalType;
    }
    
}