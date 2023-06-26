public abstract class Goal
{
    protected int _points;
    protected string _goalDescription;
    protected string _goalName;

    public Goal(string name, string description, int points)
    {
        _goalDescription = description;
        _goalName = name;
        _points = points;
    }

    public abstract int recordEvent();

    public abstract string ToSaveString();

    public abstract string Display();


}