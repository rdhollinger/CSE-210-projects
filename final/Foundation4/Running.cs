public class Running : Activity
{   
    public Running(double distance, double length, string date) : base()
    {
        _distance = distance;
        _activityLength = length;
        _date = date;
        _activityType = "Running";
    }

    public override void speed()
    {
        _speed = (_distance / _activityLength) * 60;
    }
    public override void pace()
    {
        _pace = _activityLength / _distance;
    }
}