using System.Net.Sockets;

public class Customer {
    private string _name;
    Address _address;

    public Customer(string name, Address address) {
        _name = name;
        _address = address;
    }

    public bool LivingInUSA() {
        return _address.IsInUSA();
    }

    public string SetShippingLabel () {
        return $"{_name} -  {_address.GetStreetAddress()}";
    }

}