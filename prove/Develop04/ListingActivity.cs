public class ListingActivity: Activity
{
    private List<string> _items = new List<string>();

    public ListingActivity()
    {
        _activityName = "Listing";
        _activityDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public string getRandomPrompt()
    {
        List<string> listingPrompts = new List<string>()
        {
            "Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"
        };
        return listingPrompts[rnd.Next(listingPrompts.Count)];
    }


    public void runListingActivity()
    {
        Console.Clear();
        displayStartMessage();
        Console.WriteLine(getRandomPrompt());
        timer(5);
        DateTime duration = getDuration(_duration);
        while(DateTime.Now <= duration)
        {
            Console.WriteLine("");
            string response = Console.ReadLine();
            _items.Add(response);
        }
        Console.Clear();
        Console.WriteLine("The items in your list are:");
        foreach(var i in _items)
        {
            Console.WriteLine(i);
        }
        timer(5);
        displayEndMessage();



    }
}