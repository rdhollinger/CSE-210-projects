public class Outdoors:Event
{
    private string _weather;

    public Outdoors(string weather, string title, string description, string date, string time):base()
    {
        _weather = weather;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _eventType = "Outdoor";
    }

    public void forecast()
    {
        Console.WriteLine($"Your weather for this event should be {_weather}.");
    }
    public void full()
    {
        Console.WriteLine($"Event: {_eventType}");
        standard();
        forecast();
    }

}