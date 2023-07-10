public class Event
{
    protected string _eventType;
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;

    public void standard()
    {
        Console.WriteLine($"Event title: {_title}");
        Console.WriteLine($"Event Description: {_description}");
        Console.WriteLine($"Event Date: {_date}");
        Console.WriteLine($"Event Time: {_time}");
        Console.WriteLine($"Location:");
        _address.addressInfo();

    }
    public void shortDesc()
    {
        Console.WriteLine($"Event Type: {_eventType}");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Date: {_date}");
    }
    public void setAddress(Address address)
    {
        _address = address;
    }
}