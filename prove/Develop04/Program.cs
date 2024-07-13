using System;
namespace Develop04
{
    

  class Program
  {
    static void Main(string[] args)
    {  string Program = "Running";
       while (Program == "Running")

       {
        Activity activity = new Activity();
        activity.DisplayMenu();
        string choice = Console.ReadLine();
        if(choice.ToLower() =="quit" || int.Parse(choice) == 4)
        {
          Program = "Stop";
        }
        else{
            runActivity(int.Parse(choice));
        }
       

      } 
    }
    static void runActivity(int choice)
    {

          if(choice == 1){
           Console.Clear();
           string name ="Breathing Activity";
           string description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
           BreathingActivity breathingActivity= new BreathingActivity(name, description);
           breathingActivity.DisplayStartingMessage();
           Console.WriteLine("");
           Console.Write("How long , in seconds, would you like for your session? ");
           string duration = Console.ReadLine();
           breathingActivity.SetDuration(int.Parse(duration));
           breathingActivity.Run();
           Console.WriteLine("");
           breathingActivity.DisplayEndingMessage();
              

           
          }
          else if(choice == 2){
            string name = "Reflection Activity";
            string description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
            ReflectingActivity reflectingActivity = new ReflectingActivity(name, description);
            reflectingActivity.DisplayStartingMessage();
            Console.WriteLine("");
            Console.Write("How long , in seconds, would you like for your session? ");
            string duration = Console.ReadLine();
            reflectingActivity.SetPrompt();
            reflectingActivity.SetQuestion();
            reflectingActivity.SetDuration(int.Parse(duration));
            reflectingActivity.Run();
            Console.WriteLine("");
            reflectingActivity.DisplayEndingMessage();

      }
          else if(choice == 3){
            string name = "Listing Activity";
            string description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
            ListingActivity listingActivity = new ListingActivity(name, description);
            listingActivity.DisplayStartingMessage();
            Console.WriteLine("");
            Console.Write("How long , in seconds, would you like for your session? ");
            string duration = Console.ReadLine();
            listingActivity.SetPrompt();
            listingActivity.SetDuration(int.Parse(duration));
            listingActivity.Run();
            Console.Write("");
            listingActivity.DisplayEndingMessage();
      }
          else{
           Console.WriteLine("Choose another activity that exist in the Menu!");
           Thread.Sleep(2000);
          }

    }
 }
}