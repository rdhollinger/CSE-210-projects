using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("510 Bowler Ln", "Oakland", "Oregon", "USA");
        Customer customer1 = new Customer("John Smith", address1);
        Product product1 = new Product("Milk", "M001", 2.50, 2);
        Order order1 = new Order(customer1);
        order1.addToList(product1);
        Product product2 = new Product("Sugar", "S001", 5.00, 3);
        order1.addToList(product2);
        order1.packingLable();
        order1.orderTotal();
        order1.shipping();
        order1.shippingLabel();
        Address address2 = new Address("1023 Salem St", "Onterio", "Onterio", "Cananada");
        Customer customer2 = new Customer("Jane Doe", address2);
        Order order2 = new Order(customer2);
        Product product3 = new Product("Tomatoes", "T001", .98, 6);
        order2.addToList(product3);
        Product product4 = new Product("Watermelon", "W001", 7.99, 2);
        order2.addToList(product4);
        order2.packingLable();
        order2.orderTotal();
        order2.shipping();
        order2.shippingLabel();

    }
}