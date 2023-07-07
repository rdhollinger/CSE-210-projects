public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _streetAddress = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool isUSA()
    {
        if(_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public void addressInfo()
    {
        Console.WriteLine($"{_streetAddress}");
        Console.WriteLine($"{_city}");
        Console.WriteLine($"{_state}");
        Console.WriteLine($"{_country}");
    }
}