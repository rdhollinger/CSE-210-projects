public class Biking : Activity
{
    public Biking(double speed, double length, string date) : base()
    {
        _speed = speed;
        _activityLength = length;
        _date = date;
        _activityType = "Biking";
    }
    public override void distance()
    {
        _distance = (_speed / 60) * _activityLength;
    }
    public override void pace()
    {
        _pace = _activityLength / _distance;
    }
}