using System;
using System.Net.Sockets;
namespace Foundation3;

public class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;
    public Event(){

    }
    public Event(string title, string description, string date, string time, Address address){

        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;

    }

    public string StdDetails(){
       return $"{_title}, {_description}, {_date}, {_time}, {_address.GetAddressLine()}";
    }
    public virtual string FullDetails(){
        return"";
    }
    public virtual string ShortDetails(){
        return "";
    }

   
}