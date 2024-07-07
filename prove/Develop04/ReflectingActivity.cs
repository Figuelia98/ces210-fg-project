using System;
namespace Develop04
{
    
    public class ReflectingActivity : Activity
    {
        private List<string> _prompt = new List<string>();
        private List<string> _questions = new List<string>();
        public ReflectingActivity(){

        }

        public void Run(){
            
        }
        public string GetRandomPrompt(){
         return "TST";
        }
        public string GetRandomQuestion(){
         return "TST";
        }
       public void DisplayPrompt(){

       }
       public void DisplayQuestion(){
        
       }
    }
}