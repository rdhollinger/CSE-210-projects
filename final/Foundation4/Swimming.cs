public class Swimming:Activity
{
    private double _laps;

    public Swimming(double laps, double length, string date): base()
    {
        _laps = laps;
        _activityLength = length;
        _date = date;
        _activityType = "Swimming";
    }
    public override void distance()
    {
        _distance = _laps * 50 / 1000 * 0.62;
    }
    public override void pace()
    {
        _pace = _activityLength / _distance;
    }
    public override void speed()
    {
        _speed = (_distance / _activityLength) * 60;
    }

}