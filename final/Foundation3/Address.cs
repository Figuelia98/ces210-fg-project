using System;
namespace Foundation3;

public class Address
{

    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {


        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool FromUS()
    {
        if (_country == "USA")
        {

            return true;
        }
        else
        {
            return false;
        }
    }
    public void DislpayAddress()
    {

        Console.WriteLine($"{_street},{_city},{_state},{_country}");
    }
    public string GetAddressLine()
    {
        return $"{_street},{_city},{_state},{_country}";
    }


}