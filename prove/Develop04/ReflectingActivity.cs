using System;
namespace Develop04
{
    
    public class ReflectingActivity : Activity
    {
        private List<string> _prompts = new List<string>();
        private  List<string> _questions = new List<string>();

        public ReflectingActivity(string name, string description):base(name, description){
       
        }
      
        public void Run(){
            Console.Clear();

            Console.WriteLine("Get Ready...");
            ShowSpinner(5);
            Console.WriteLine("");
            Console.WriteLine("Consider the following Prompt:");
            Console.WriteLine("");
            DisplayPrompt();
            Console.WriteLine("When you have something in mind press Enter to continue.");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Now you ponder on each of the following questions as the related to the experience.");
            Console.Write("You may begin in: ");
            ShowCountDown(5);
            Console.Clear();
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_duration);


            while (DateTime.Now < endTime)
            {
              
              DisplayQuestion();
              ShowSpinner(5);
              Console.WriteLine();

            }
        }
        public void SetPrompt()
        {
            _prompts.Add("Think of a time that you ovecame a difficult situation");
            _prompts.Add("Think of the bigest change in your life when you recieved God");
            _prompts.Add("Think of your carrier actually or future carrier");
            _prompts.Add("Think of your study accomplishment");
            
        }
        public void SetQuestion()
        {
            _questions.Add("How did you feel from this experience ?");
            _questions.Add("How did you feel from the presence of God on that moment ?");
            _questions.Add("Do you feel that think that has something from your faith ?");
            _questions.Add("How can you share your experience to others ?");

        }
        public string GetRandomPrompt(){
            Random radom = new Random();
            int choose =radom.Next(0,4);
            return _prompts[choose];
        }
        public string GetRandomQuestion(){
            Random radom = new Random();
            int choose = radom.Next(0, 4);
            return _questions[choose];
        }
       public void DisplayPrompt(){
            Console.WriteLine();
            Console.WriteLine($"--- {GetRandomPrompt()} ---");
            Console.WriteLine();
        }
       public void DisplayQuestion(){
            Console.Write($"> {GetRandomQuestion()} ");

        }
    }
}