public abstract class Activity
{
    protected string _date;
    protected double _activityLength;
    protected double _pace;
    protected double _distance;
    protected double _speed;
    protected string _activityType;

    public void getSummary()
    {
        Console.WriteLine($"{_date} {_activityType} ({_activityLength} min)- Distance {_distance} miles, Speed {_speed} mph, Pace {_pace} min per mile");
    }
    public virtual void distance()
    {

    }
    public virtual void speed()
    {

    }
    public virtual void pace()
    {

    }
}