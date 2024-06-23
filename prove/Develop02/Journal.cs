using System;
using System.IO; 
public class Journal

{
   //Attribute contening the responce (Date/Prompt/Answer)
   public Save _askResponce = new Save();

   //Old Journal
   public  Save _journal = new Save(); 

   //Attribute functionalities

   public string[] _options = {"Write","Display","Load","Save","Quit"};

   
   public void DisplayOption(){


    int len = _options.Length;
    for(int i = 0;i < len;i++){


        Console.WriteLine($"{i+1}.{_options[i]}");
    }


   }   
   //method register

   public void RegisterJournal( string filename){
      
    using (StreamWriter outputFile = new StreamWriter(filename)){

     int len = _askResponce._dates.Count;

     for (int i=0; i < len; i++){

        outputFile.WriteLine($"{_askResponce._dates[i]},{_askResponce._prompts[i]},{_askResponce._answers[i]}");
     }

    }

   }
   

   //method load
   public void LoadJournal(string filename){
    string[] lines = File.ReadAllLines(filename);
    
    foreach (string  line in lines) {
        string[] parts =line.Split(",");
        
        _journal._dates.Add(parts[0]);
        _journal._prompts.Add(parts[1]);
        _journal._answers.Add(parts[2]);     
    }
  
  
   }


   //method display

   public void DisplayJournal(){

    int  elemCount=_journal._dates.Count;
    int actElem=_askResponce._dates.Count;
    if(elemCount > 0){
       

        for(int i = 0; i < elemCount; i++){
      
      Console.WriteLine($"{_journal._dates[i]} - {_journal._prompts[i]} {_journal._answers[i]}");
     }


    }
    if(actElem > 0){


      for(int i = 0; i < actElem; i++){


      Console.WriteLine($"{_askResponce._dates[i]} - {_askResponce._prompts[i]} {_askResponce._answers[i]}");
      }

       
    }
   
   }
}