using System;

public class PromptGenerator{
    private List<string> prompts = new List<string>() {"What are my top priorities for the day?", "What is a small detail I noticed today?", "What am I thankful for today?", "What could I have done different today?", "What is something I can do to make today amazing?", "What is happening today?", "What is the most interesting thing I saw or heard?", "What did I learn Today?", "What did I do today that I'm proud of?"};
    private Random rnd = new Random();

    public string GetPrompt()
    {
       return prompts[rnd.Next(prompts.Count)];
    }
}