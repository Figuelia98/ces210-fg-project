using System;
namespace Develop05;
class Program
{
    static void Main(string[] args)
    {  
        Console.Clear();
       GoalManager goalManager = new GoalManager();
       string program = "running";
       while (program == "running")
       { 
        goalManager.Start();
        Console.Write("Choose one option from the menu: ");
        string choiceStr = Console.ReadLine();

        if(int.Parse(choiceStr) == 1){

           goalManager.CreateGoal();
        }
        else if(int.Parse(choiceStr) == 2){

            goalManager.ListGoalDetails();
        }
        else if(int.Parse(choiceStr) == 3){

            goalManager.SaveGoals();
        }
        else if (int.Parse(choiceStr) == 4){

            goalManager.LoadGoals();
        }
        else if (int.Parse(choiceStr) == 5){
            goalManager.RecordEvent();
        }
        else if (int.Parse(choiceStr) == 6){

            program = "stop";
        }

         
         
        
          
       }
    }
}