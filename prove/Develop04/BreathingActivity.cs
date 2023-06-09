public class BreathingActivity : Activity
{

    public BreathingActivity() : base()
    {
        _activityName = "Breathing";
        _activityDescription = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }



    public void runBreathingActivity()
    {
        Console.Clear();
        displayStartMessage();
        DateTime duration = getDuration(_duration);
        while (DateTime.Now <= duration)
        {
            Console.WriteLine("Breath in ...");
            timer(5);
            Console.WriteLine();
            Console.WriteLine("Breath out ...");
            timer(5);
            Console.WriteLine();
        }
        Console.Clear();
        displayEndMessage();

    }


}