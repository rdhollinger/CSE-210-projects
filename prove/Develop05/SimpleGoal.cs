public class SimpleGoal: CompletableGoal
{
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    public SimpleGoal(string name, string description, int points, bool isComplete) : base(name, description, points, isComplete)
    {

    }
    public override int recordEvent()
    {
        _isComplete = true;
                      
        Console.WriteLine($"You have earned {_points}");
        return _points;
    }

    public override string ToSaveString()
    {
        return $"Simple,{_goalName},{_goalDescription},{_points},{_isComplete}";
    }

    public override string Display()
    {
        return $"[{isComplete()}] {_goalName}: {_goalDescription}";
    }
}

