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
    public override double distance()
    {
        return _distance = _laps * 50 / 1000 * 0.62;
    }


}