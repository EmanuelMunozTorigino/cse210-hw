using System.Dynamic;

public class Address
{
    private string _address;
    private string _city;
    private string _state;
    private string _country;


    public Address(string address, string city, string state, string country)
    {
        _address = address;
        _city = city;
        _state = state;
        _country = country;
    }
    public bool IsInUSA()
    {
        return _country.ToLower() == "usa";        
    }

    public string GetCompleteAddress()
    {
        string address = $"{_address} - {_city}, {_state}, {_country}";
        
        return address;
    }

    public string GetStreetAddress ()
    {
        return _address;
    }


}