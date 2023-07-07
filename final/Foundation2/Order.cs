public class Order
{
    private List<Product> products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public double orderTotal()
    {
        double ordertotal = 0;
        foreach(Product product in products)
        {
            ordertotal += product.productPrice();
        }
        return ordertotal;
        
    }
    public double shipping()
    {
        double shippingCost = 0;
        Console.WriteLine($"Your order total is ${orderTotal()}");
        if(_customer.isUSA()==true)
        {
            Console.WriteLine("Your shipping cost is $5");
            shippingCost = 5;
        }
        else
        {
            Console.WriteLine("Your shipping cost is $35");
            shippingCost = 35;
        }
        Console.WriteLine($"Your total with shipping is ${orderTotal() + shippingCost}");
        return shippingCost;

    }
    public void packingLable()
    {
        foreach(Product product in products)
        {
            product.productInfo();
        }
    }
    public void shippingLabel()
    {
        _customer.customerinfo();
    }
    public void addToList(Product product)
    {
        products.Add(product);
    }
}