using System;

public class Customer
{
    private string name;
    private Address address;

    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    public string Name => name;
    public Address Address => address;

    public bool IsInUSA()
    {
        return address.IsInUSA();
    }
}
