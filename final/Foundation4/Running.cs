public class Running : Activity
{   
    public Running(double distance, double length, string date) : base()
    {
        _distance = distance;
        _activityLength = length;
        _date = date;
        _activityType = "Running";
    }

}