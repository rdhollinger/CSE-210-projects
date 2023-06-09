using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Menu\n" +
                        "1. Refelect Activity\n" +
                        "2. Breathing Activity\n" +
                        "3. Listing Activity\n" +
                        "4. Quit");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    RefelctionActivity reflect = new RefelctionActivity();
                    reflect.runReflectionActivity();
                    break;
                case "2":
                    BreathingActivity breath = new BreathingActivity();
                    breath.runBreathingActivity();
                    break;
                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.runListingActivity();
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }

    }
}