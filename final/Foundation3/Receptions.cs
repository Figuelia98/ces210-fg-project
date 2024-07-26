using System;
namespace Foundation3;

public class Receptions : Event
{
    private string _email;

    public Receptions(string title, string description, string date, string time, Address address, string email) : base(title, description, date, time, address)
    {
        _email = email;
    }
    public string FullDetail()
    {

        return $"Receptions ,{_title}, {_description}, {_date}, {_time}, {_address}, {_email}";
    }
    public string ShortDetails()
    {
        return $"Receptions, {_description}, {_date}";
    }
}