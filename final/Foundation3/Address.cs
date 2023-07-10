public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;

    public Address(string street, string city, string state)
    {
        _streetAddress = street;
        _city = city;
        _state = state;
    }

    public void addressInfo()
    {
        Console.WriteLine($"{_streetAddress}");
        Console.WriteLine($"{_city}");
        Console.WriteLine($"{_state}");
    }
}