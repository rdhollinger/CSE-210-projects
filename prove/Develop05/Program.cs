using System;
class Program
{
    static void Main(string[] args)
    {
        GoalData data = new GoalData();
        while (true)
        {
            Console.WriteLine(
                $"Total Points: {data.TotalPoints}\n\n" +
                "Menu\n" +
                "1. Create New Goal\n" +
                "2. List Goals\n" +
                "3. Save Goals\n" +
                "4. Load Goals\n" +
                "5. Record Event\n" +
                "6. Quit");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    data.AddGoal();
                    break;
                case "2":
                    data.displayAllGoals();
                    break;
                case "3":
                    data.Save();
                    break;
                case "4":
                    data.Load();
                    break;

                case "5":
                    data.displayIncompleteGoals();
                    break;

                case "6":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}