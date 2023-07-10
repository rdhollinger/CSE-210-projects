using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("444 Utah Ave", "Oakland","CA");
        Event event1 = new Event();
        Lectures lecture1 = new Lectures("John Smith", 20, "How to write a mystery", "This will be a workshop on how to write mystery novels", "12/20/2023", "7:00 pm");
        lecture1.setAddress(address1);
        lecture1.standard();
        Console.WriteLine(" ");
        lecture1.Full();
        Console.WriteLine(" ");
        lecture1.shortDesc();
        Console.WriteLine(" ");
        
        Address address2 = new Address("239 Jones St", "Washington", "DC");
        Event event2 = new Event();
        Receptions reception1 = new Receptions("Greggor Wedding", "Wedding reception for the Greggor wedding", "06/10/2024", "5:00 pm");
        reception1.addToList("janedoe82@yahoo.com");
        reception1.addToList("lovesdogs94@gmail.com");
        reception1.addToList("borntorun@hotmail.com");
        reception1.setAddress(address2);
        reception1.shortDesc();
        Console.WriteLine(" ");
        reception1.standard();
        Console.WriteLine(" ");
        reception1.full();
        Console.WriteLine(" ");

        Address address3 = new Address("622 Albert Ave", "Portland", "OR");
        Event event3 = new Event();
        Outdoors outdoors1 = new Outdoors("Sunny", "Walter Company picknick", "Annual company picknick", "7/20/2024", "11:00 am");
        outdoors1.setAddress(address3);
        outdoors1.shortDesc();
        Console.WriteLine(" ");
        outdoors1.standard();
        Console.WriteLine(" ");
        outdoors1.full();
    }
}