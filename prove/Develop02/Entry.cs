using System;

public class Entry
{
    // ATRIBUTES
    private PromptGenerator promptGenerator = new PromptGenerator();
    private DateTime theCurrentTime = DateTime.Now;
    private string dateText;
    private string prompt;
    private string response;
    public string DateText { 
        get{ return dateText;}
    }
    public string Prompt {
        get{return prompt;}
    }
    public string Response {
        get{return response;}
    }
    // METHODS
    public Entry(){}
    public Entry(string datetext, string prompt, string response){
        this.dateText = dateText;
        this.prompt = prompt;
        this.response = response;
    }
    // WriteEntry
    public void WriteEntry(){
        dateText = theCurrentTime.ToShortDateString();
        prompt = promptGenerator.GetPrompt();
        // Display the prompt
        Console.WriteLine(prompt);
        // capture the response
        response = Console.ReadLine();
    }
    // DisplayEntry
    public void DisplayEntry(){
        Console.WriteLine(dateText);
        Console.WriteLine(prompt);
        Console.WriteLine(response);
    }
}