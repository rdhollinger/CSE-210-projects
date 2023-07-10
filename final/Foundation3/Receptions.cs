public class Receptions:Event
{
    private List<string> emails = new List<string>();

    public Receptions(string title, string description, string date, string time):base()
    {

        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _eventType = "Reception";
    }

    public void full()
    {
        Console.WriteLine($"Event: {_eventType}");
        standard();
        Console.WriteLine("Emails that have RSVP:");
        foreach(string email in emails)
        {
            Console.WriteLine($"{email}");
        }
    }
    public void addToList(string email)
    {
        emails.Add(email);
    }


}