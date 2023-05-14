using System;
class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        while(true){
    
            Console.WriteLine("Menu\n" +
                "1. Add Entry\n" +
                "2. Display Entries\n" +
                "3. Save Entries\n" +
                "4. Load Entries\n" +
                "5. Quit"
            );
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    journal.AddEntry();
                    break;
                case "2":
                    journal.DisplayEntry();
                    break;
                case "3":
                    journal.SaveEntries();
                    break;
                case "4":
                    journal.LoadEntries();
                    //journal.DisplayEntry();
                    
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }

    }
}