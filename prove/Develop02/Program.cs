using System;

class Program
{
    static void Main(string[] args)
    {  
      // start the program with in loop while
      string programStat="Running";
      int option;
     
      Journal Journal = new Journal();

      do{

      DateTime CurrentDate = DateTime.Now;
      PromptGen promptUser = new PromptGen();
    

       //print welcome sentence 
       Console.WriteLine("Welcome to your Journals");
       Console.WriteLine("Please choose one the following options:");
       //print the list of the fontcinality 
       Journal.DisplayOption();
       //print the use about the fonctionality the user want to use
       Console.WriteLine("What you would like to do? ");
    
        //Read the user response and run the fonctionality
        string userNeed= Console.ReadLine();
        option = int.Parse(userNeed);
         if (option==1){
      
     
        string today = CurrentDate.ToShortDateString();

        string strpromt= promptUser.PromptGenerator();
          
        Console.Write(strpromt);
        string answer = Console.ReadLine();
        
        Journal._askResponce._answers.Add(answer);
        Journal._askResponce._prompts.Add(strpromt);
        Journal._askResponce._dates.Add(today);

        
     }
     else if(option==2){
       Console.WriteLine(Journal._askResponce._answers[0]);
        Journal.DisplayJournal();
      
     }

     else if(option==3){
      Console.Write("Write the name of the file you want to load?  ");
      string filename = Console.ReadLine();
      Journal.LoadJournal(filename);
     }
     else if(option==4){
         

      Console.Write("Write the name of the file that you want to save the file:  ");
      string filename = Console.ReadLine();
      Journal.RegisterJournal(filename);
     }
     else{
         programStat="Stop";
     }

      


      }
      while (programStat=="Running");

       
    }
    
   
}