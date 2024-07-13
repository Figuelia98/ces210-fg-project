using System;
namespace Develop04
{
    
    public class ListingActivity : Activity
    {    

        int _count;
        List<string>  _prompts= new List<string>();

        public ListingActivity(string name, string description):base(name,description){

        }

        public void Run(){
            Console.Clear();

            Console.WriteLine("Get Ready...");
            ShowSpinner(5);
            Console.WriteLine("");
            Console.WriteLine("List as many responses you can to the following prompt: ");
            Console.WriteLine("");
            GetRandomPrompt();
            Console.Write("You may begin in: ");
            ShowCountDown(5);
           _count= GetListFromUser().Count;
            Console.WriteLine();
            Console.WriteLine($"You have listed {_count} items");


        }
        public void SetPrompt(){
            _prompts.Add("What the most important thing you need the accomplish this month ?");
            _prompts.Add("How can you improve your communication to others ?");
            _prompts.Add("Are you happy with your actual life ? ");
            _prompts.Add("How can you change your life ?");
        }

        public void GetRandomPrompt(){
            Random radom = new Random();
            int choose = radom.Next(0, 4);
             Console.WriteLine($"--- {_prompts[choose]} ---");
        }
        public List<string> GetListFromUser(){
         List<string> listUser = new List<string>() ;
         DateTime startTime = DateTime.Now;
         DateTime endTime = startTime.AddSeconds(_duration);
         Console.WriteLine("");
         while (DateTime.Now < endTime)
         {

            Console.Write("> ");
            string answer = Console.ReadLine();
            listUser.Add(answer);

            }
          
        return listUser;
        }

    }
}