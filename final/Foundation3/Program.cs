using System;
namespace Foundation3;
class Program
{
    static void Main(string[] args)
    {
       List<Event> events= new List<Event>();
       Lectures lectures= new Lectures("Books","Lecture of manga books","06-07-2024","05:31",new Address("Ankorondrano","Tananarive","Malagasy","Madagascar"),"Hellon","12");
       Receptions receptions = new Receptions("Meeting", "Lecture of manga books", "06-07-2024", "05:31", new Address("Ankorondrano", "Tananarive", "Malagasy", "Madagascar"), "Hellon@gmail.com");
       Outdoor outdoor = new Outdoor("Festival", "Lecture of manga books", "06-07-2024", "05:31", new Address("Ankorondrano", "Tananarive", "Malagasy", "Madagascar"), "Sunny");

       events.Add(lectures);
       events.Add(receptions);
       events.Add(outdoor);

       for(int i=0;i<events.Count;i++)
       {
           Console.WriteLine($"{events[i].StdDetails()}");
            Console.WriteLine($"{events[i].FullDetails()}");
            Console.WriteLine($"{events[i].ShortDetails()}");
       }
       
    }
}