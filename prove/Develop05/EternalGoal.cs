public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }


    public override int recordEvent()
    {
        Console.WriteLine($"You have earned {_points}");
        return _points;
    }

    public override string ToSaveString()
    {
        return $"Eternal,{_goalName},{_goalDescription},{_points}";
    }

    public override string Display()
    {
        return $"[ ] {_goalName}: {_goalDescription}";
    }

}