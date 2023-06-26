public class CheckListGoal : CompletableGoal
{
    private int _timesDone;
    private int _bonusPoints;
    private int _target;

    public CheckListGoal(string name, string description, int points, bool isComplete, int timesdone, int target, int bonuspoints) : base(name, description, points, isComplete)
    {
        _timesDone = timesdone;
        _target = target;
        _bonusPoints = bonuspoints;
    }
    public CheckListGoal(string name, string description, int points, int target, int bonuspoints) : base(name, description, points)
    {
        _target = target;
        _bonusPoints = bonuspoints;
    }
    public override int recordEvent()
    {
        _timesDone++;
        if(_timesDone == _target)
        {
            _isComplete = true;
            Console.WriteLine($"Congratulations! You have completed the Goal and earned {_bonusPoints} bonus points.");
            return _bonusPoints + _points;
        }
        else
        {
            Console.WriteLine($"You have earned {_points}");
            return _points;
        }

    }

    public override string ToSaveString()
    {
        return $"Checklist,{_goalName},{_goalDescription},{_points},{_isComplete},{_timesDone},{_target},{_bonusPoints}";
    }

    public override string Display()
    {
        return $"[{isComplete()}] {_goalName}: {_goalDescription} {_timesDone}/{_target}"; 
    }
}