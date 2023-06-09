public class Activity
{
    protected string _activityType;
    protected Random rnd = new Random();
    protected int _duration;
    protected string _activityName;
    protected string _activityDescription;
    List<string> animationspinner = new List<string>()
    {"|", "/", "-", "\\"};


    public void pauseSpinner()
    {
        DateTime futureTime = getDuration(5);

        while (DateTime.Now <= futureTime)
        {
            foreach (string s in animationspinner)
            {
                Console.Write(s);
                Thread.Sleep(250);
                Console.Write("\b \b");
            }
        }
        
    }
    public DateTime getDuration(int duration)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
        return futureTime;
    }

    public void timer(int duration)
    {
        for (int i = duration; i > 0; i -- )
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void displayStartMessage()
    {
        Console.WriteLine($"Welcome to the {_activityName} activity.");
        Console.WriteLine($"{_activityDescription}");
        Console.Write("How long would you like to do this activity in seconds? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.Write("Get ready ...");
        
        Console.WriteLine("\n");



    }

    public void displayEndMessage()
    {
        Console.WriteLine("Well Done!");
        pauseSpinner();
        Console.WriteLine();
        Console.WriteLine($"You have completed {_duration} seconds of {_activityName}.");
        pauseSpinner();
    }

}