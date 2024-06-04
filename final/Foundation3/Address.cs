using System;

public class Address
{
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _zipCode;

    // Constructor
    public Address(string street, string city, string stateProvince, string zipCode)
    {
        _street = street;
        _city = city;
        _stateProvince = stateProvince;
        _zipCode = zipCode;
    }

    // Method to get full address
    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_stateProvince}, {_zipCode}";
    }
}