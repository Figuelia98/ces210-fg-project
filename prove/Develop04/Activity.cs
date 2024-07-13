using System;

namespace Develop04
{  
    public class Activity
    {

        protected string _name;
        protected string _description;
        protected int _duration;
        
        private string [] _menu = ["breathing activity","reflecting activity","listing activity", "Quit"];


        public Activity(){

        }
        public Activity( string name , string description)
        {
            _name=name;
            _description=description;
        }
        public void SetDuration( int duration){
          _duration=duration;
        }
        public void DisplayMenu(){

            Console.Clear();
            Console.WriteLine("Menu Options:");
            for (int i = 0;i < _menu.Length;i++)
            {
                Console.WriteLine($"   {i+1} - Start {_menu[i]}");
            }
            Console.Write("Select a choice from the menu:  ");

        }
        public  void DisplayStartingMessage(){
          Console.Clear();
          Console.WriteLine($"Welcome to the {_name} ");
          Console.WriteLine("");
          Console.WriteLine(_description);
        }

        public void DisplayEndingMessage(){
         Console.WriteLine("Well Done !!!");
         ShowSpinner(3);
         Console.WriteLine();
         Console.WriteLine($"You have completed  another {_duration} seconds of the {_name}");
         ShowSpinner(3);
         
        }
        public void ShowSpinner(int seconds){

            string[] animationStr = ["\\", "|", "/", "-"];
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(seconds);
            int i = 0;
            while (DateTime.Now < endTime)
            {
 
                Console.Write(animationStr[i]);
                Thread.Sleep(300);
                Console.Write("\b \b");
                 i++;
                if(i >= animationStr.Length){
                    i = 0;
                }

            }

        }
        public void ShowCountDown(int seconds){
         
          int Len = 0;
            for (int i = seconds; i > 0; i--)
         {
            Console.Write(i);
            Len = i.ToString().Length;
            Thread.Sleep(1000);
            if(Len == 2)
              {
                    Console.Write("\b \b");
                    Console.Write("\b \b");
              }
              else if(Len == 3){
                    Console.Write("\b \b");
                    Console.Write("\b \b");
                    Console.Write("\b \b");
                }
            else{
                    Console.Write("\b \b");
                }
            
            
         }
        }

    }

}