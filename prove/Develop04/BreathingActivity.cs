using System;
namespace Develop04
{
    
    public class BreathingActivity : Activity
    {
        public BreathingActivity(string name , string description):base(name, description){

        }

        public void Run(){
            Console.Clear();
        
            Console.WriteLine("Get Ready...");
            ShowSpinner(5);
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_duration);

            while (DateTime.Now < endTime)
            {
               
                Console.WriteLine();
                Console.Write("Breath in ...");
                ShowCountDown(5);
                Console.WriteLine();
                Console.Write("Breath out ...");
                ShowCountDown(5);
                Console.WriteLine();

            }  
        }

    }
}