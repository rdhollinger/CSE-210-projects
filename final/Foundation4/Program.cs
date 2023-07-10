using System;

class Program
{
    static void Main(string[] args)
    {
        Running running1 = new Running(3, 30, "10/22/2022");
        running1.speed();
        running1.pace();
        running1.getSummary();

        Biking bike1 = new Biking(15, 30, "05/25/2023");
        bike1.distance();
        bike1.pace();
        bike1.getSummary();

        Swimming swim1 = new Swimming(100, 45, "07/02/2023");
        swim1.distance();
        swim1.pace();
        swim1.speed();
        swim1.getSummary();

    }
}