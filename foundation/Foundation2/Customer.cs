using System.Net.Sockets;

public class Customer
{
    private string _name;
    Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }

    public string GetShippingLabel()
    {
        //        return $"Customer name: {_name} - address: {_address.GetStreetAddress()}";
        return $"ShippingLabel:\nCustomer name: {_name} - address: {_address.GetCompleteAddress()}";
    }

}