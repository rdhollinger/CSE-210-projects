public abstract class CompletableGoal  : Goal
{
    protected bool _isComplete = false;
    public bool IsComplete {get{return _isComplete;}}

    public CompletableGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    public CompletableGoal(string name, string description, int points, bool isComplete) : base(name, description, points)
    {
        _isComplete = isComplete;
    }
    public char isComplete()
    {
        if (_isComplete)
            return 'X';
        else
            return ' ';
    }
}