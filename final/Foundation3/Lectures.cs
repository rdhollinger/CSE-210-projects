public class Lectures : Event
{
    private string _speaker;
    private int _isLimit;

    public Lectures(string speaker, int limit, string title, string description, string date, string time) : base()
    {
        _speaker = speaker;
        _isLimit = limit;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _eventType = "Lecture";

    }

    public void Full()
    {
        Console.WriteLine($"Event: {_eventType}");
        standard();
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine($"Event limit is {_isLimit}");
    }
}