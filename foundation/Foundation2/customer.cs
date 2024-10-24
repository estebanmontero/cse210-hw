using System;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool LivesInUSA() => _address.IsInUSA();

    public string GetFullName() => _name;

    public string GetAddress() => _address.FullAddress();
}
