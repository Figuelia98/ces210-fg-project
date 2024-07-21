using System;
using System.IO; 
namespace Develop05;

public class GoalManager
{
   private List<Goal> _goal = new List<Goal>();
   private int _score = 0;
   private string[] _menu = ["Create New Goal","List Goals","Save Goals","Load Goals","Record Event", "Quit"]; 
   public GoalManager(){

   }
   public void Start(){
    int len = _menu.Length; 
    DisplayPlayerInfo();
    Console.WriteLine();
    Console.WriteLine("Menu Options: ");
    for (int i = 0; i < len; i++)
    {
      Console.WriteLine($"  {i+1}. {_menu[i]}");
    }
   }
   public void DisplayPlayerInfo(){
   int len = _goal.Count;
   if (len > 0){
     _score = 0;
    for (int i = 0; i < len; i++){
        
      _score += _goal[i].getScore();

    }

   }
   if(_score > 1){
      Console.WriteLine($" You have {_score} points");
   }
   else{
      Console.WriteLine($" You have {_score} point");
   }
   
   }
   public void ListGoalNames(){
    int len = _goal.Count;
    for (int i = 0; i < len; i++){

      Console.WriteLine($" {i+1}.  {_goal[i].getShortName()}");
    }
   }
   public void ListGoalDetails(){
   int len = _goal.Count;
    for (int i = 0; i < len; i++){

      Console.WriteLine($"{i+1}.{_goal[i].DetailsString()}");
    }
   }
   public void CreateGoal(){
     string[] goalType = ["Simple goal","Eternal Goal", "Checklist Goal"];
   Console.WriteLine("Type of goals: ");
     for (int i = 0; i < goalType.Length; i++ ){
       Console.WriteLine($"  {i+1}. {goalType[i]}");
     }
   
    Console.Write("What type of goal do you want to create? ");
    string typeChoice = Console.ReadLine();

    
    if(int.Parse(typeChoice)== 1){
      Console.Write("What is the name of your goal? ");
      string nameGoal = Console.ReadLine();
      Console.Write("Give a short description of your goal? ");
      string descriptionGoal= Console.ReadLine();
      Console.Write("How many point worth this Goal? ");
      string pointsGoalStr = Console.ReadLine();
      SimpleGoal newGoal = new SimpleGoal(nameGoal,  descriptionGoal, pointsGoalStr);

      _goal.Add(newGoal);

    }
    else if (int.Parse(typeChoice)== 2){
     Console.Write("What is the name of your goal? ");
      string nameGoal = Console.ReadLine();
      Console.Write("Give a short description of your goal? ");
      string descriptionGoal= Console.ReadLine();
      Console.Write("How many point worth one accomplishment? ");
      string pointGoalStr = Console.ReadLine();
      EternalGoal newGoal = new EternalGoal(nameGoal,  descriptionGoal, pointGoalStr);
      _goal.Add(newGoal);

    }
    else if (int.Parse(typeChoice)== 3)
    {
     Console.Write("What is the name of your goal? ");
      string nameGoal = Console.ReadLine();
      Console.Write("Give a short description of your goal? ");
      string descriptionGoal= Console.ReadLine();
      Console.Write("How many point worth one accomplishment? ");
      string pointGoalStr = Console.ReadLine();
       int pointsGoal = int.Parse(pointGoalStr);
      Console.Write("How many time do you want to accomplish this? ");
      string targetGoalStr = Console.ReadLine();
      int targetGoal = int.Parse(targetGoalStr);
      Console.Write("The bonus you will get? ");
      
      string bonusGoalStr = Console.ReadLine();
      int bonusGoal = int.Parse(bonusGoalStr);


     
      ChecklistGoal newGoal = new ChecklistGoal(nameGoal,  descriptionGoal, pointGoalStr, targetGoal,bonusGoal);
      _goal.Add(newGoal);
    }
    


   }
   public void RecordEvent(){
    Console.WriteLine("Record an Event for:");
    ListGoalNames();
    Console.Write("Choose a goal: ");
    string goalChoice = Console.ReadLine();
    _goal[int.Parse(goalChoice)-1].RecordEvent();  
     Console.WriteLine($"Congratulation you got {_goal[int.Parse(goalChoice)-1].getScore()} points"); 
   }

   public void SaveGoals(){

   Console.Write("Write the name of file you want to save: ");
   string fileName = Console.ReadLine();

      using (StreamWriter outputFile = new StreamWriter(fileName))
 {
     outputFile.WriteLine($"{_score}");
    int len = _goal.Count;
    for (int i = 0; i < len; i++){
   
      outputFile.WriteLine($"{_goal[i].GetStringRepresentation()}");
    }
 }

   }
   public void LoadGoals(){
   Console.Write("Write the name of the file to load: ");
   string fileName = Console.ReadLine();
   string[] lines = System.IO.File.ReadAllLines(fileName);
   int i = 0;
foreach (string line in lines)
{   string[] parts = line.Split(",");
    if(i==0){
     _score = int.Parse(parts[0]);
    }
    else{

      if(parts[0]=="Simple Goal"){
       SimpleGoal savedGoal = new SimpleGoal(parts[1],parts[2],parts[3]);
       if (parts[4]=="True"){
         savedGoal.RecordEvent();
       }
       _goal.Add(savedGoal);
      }
      else if(parts[0]=="Eternal Goal"){
       EternalGoal savedGoal = new EternalGoal(parts[1],parts[2],parts[3]);
       savedGoal.setScore(int.Parse(parts[4]));
       _goal.Add(savedGoal);

      }
      else if(parts[0]=="Checklist Goal") {
        ChecklistGoal savedGoal = new ChecklistGoal(parts[1],parts[2],parts[3],int.Parse(parts[6]), int.Parse(parts[7]));
        savedGoal.setAmount(int.Parse(parts[5]));
        savedGoal.setScore(int.Parse(parts[8]));
        if(parts[6]==parts[5])
        {
          savedGoal.setComplete();
        }

          _goal.Add(savedGoal);
      }

    }
   

   
    i++;
}
   }

}