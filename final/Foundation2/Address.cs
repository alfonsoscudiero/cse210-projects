using System;

public class Address
{
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country; 

    // Constructor method
    public Address(string street, string city, string stateProvince, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }   

    // Method to Display Address
    public string GetFullAddress()
    {
        return ($"{_street}\n{_city}, {_stateProvince}\n{_country}");
    }
    // Check if the customer lives in the USA
    public bool IsInUSA()
    {
        return _country.ToLower() == "usa";
    }
}