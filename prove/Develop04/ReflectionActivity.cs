public class RefelctionActivity : Activity
{
    private List<string> reflectionPrompt = new List<string>() 
    {
        "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."
    };
    public RefelctionActivity()
    {
        _activityName = "Reflection";
        _activityDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }
    public void runReflectionActivity()
    {
        
        displayStartMessage();
        pauseSpinner();
        Console.WriteLine(getRandomPrompt());
        timer(5);
        DateTime duration = getDuration(_duration);
        while (DateTime.Now <= duration)
        {
            Console.WriteLine(getRandomQuestion());
            timer(5);
        }
        displayEndMessage();

    }
    public string getRandomPrompt()
    {
        return reflectionPrompt[rnd.Next(reflectionPrompt.Count)];
    }


    public string getRandomQuestion()
    {
        List<string> reflectionQuestion = new List<string>()
        {
            "Why was this experence meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"
        };
        return reflectionQuestion[rnd.Next(reflectionQuestion.Count)];



    }


}