public class Product
{
    private string _productName;
    private string _productId;
    private double _price;
    private int _quantity;

    public Product(string name, string id, double price, int quantity)
    {
        _productName = name;
        _productId = id;
        _price = price;
        _quantity = quantity;
    }

    public double productPrice()
    {
        return _price * _quantity;
    }
    public void productInfo()
    {
        Console.WriteLine($"{_productName}");
        Console.WriteLine($"{_productId}");
    }
}