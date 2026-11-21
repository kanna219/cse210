class SimpleGoal : BaseGoal
{
    public SimpleGoal(string name, string description, int points, bool complete, string goalType)
    :base(name, description, points, complete, goalType)
    {
        
    }
    public SimpleGoal() :base("SimpleGoal")
    {
        
    }

    public override int RecordEvent()
    {
        // TO DO !!!!!
        return MarkComplete();
    }
}