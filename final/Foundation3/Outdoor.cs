using System;
namespace Foundation3;

public class Outdoor : Event
{
   
    private string _weather;

    public Outdoor(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address)
    {
        _weather = weather;

    }
    public override string FullDetails()
    {

        return $"Outdoor ,{_title}, {_description}, {_date}, {_time}, {_address.GetAddressLine()}, {_weather}";
    }
    public override string ShortDetails()
    {
        return $"Outdoor, {_description}, {_date}";
    }
}