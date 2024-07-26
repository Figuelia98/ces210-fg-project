using System;
namespace Foundation3;

public class Lectures: Event
{
    private string _speaker;
    private string _capacity;

    public Lectures(string title, string description,string date, string time,Address address,string speaker,string capacity): base(title,description,date,time,address){
     
      _speaker = speaker;
      _capacity =capacity;

    }
    public string FullDetail(){

        return $"Lectures ,{_title}, {_description}, {_date}, {_time}, {_address}, {_speaker}, {_capacity}";
    }
    public string ShortDetails()
    {
        return $"Lectures, {_description}, {_date}";
    }
}