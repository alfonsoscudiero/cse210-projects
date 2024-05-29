using System;

public class Customer
{
    private string _customerName;
    private Address _address;

    // Constructor
    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }   

    // Get the customer name
    public string GetCustomerName()
    {
        return _customerName;
    }

    // Set customer name within the class
    private void SetCustomerName(string customerName)
    {
        _customerName = customerName;
    }

    // Get the customer address
    public Address GetAddress()
    {
        return _address;
    }

    // Set customer address within the class
    private void SetAddress(Address address)
    {
        _address = address;
    }    

    // Method to determine if the customer lives in the USA
    public bool LiveInUSA()
    {
        return _address.IsInUSA();
    }
}