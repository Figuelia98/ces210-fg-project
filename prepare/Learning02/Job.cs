 using System;
 public class Job{
        
        public string _company="";
        public string _jobTitle="";
        public int _startYear=0000;
        public int _endYear=0000;
      
      public Job(){
       
      }

      public void Display(){
 
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear} ");
        
      }
    }