using System;

class Program
{
    static void Main(string[] args)
    {
         Resume resume = new Resume();
         resume._name = "Juliane Maval";
         Job job1 = new Job();
         
         job1._jobTitle = "Software Developer";
         job1._company = "Amazon";
         job1._startYear = 2019;
         job1._endYear = 2030;
          
         Job job2 = new Job();
         job2._jobTitle = "Data Analyst";
         job2._company = "Google";
         job2._startYear = 2005;
         job2._endYear = 2015;

         resume._jobs.Add(job1);
         resume._jobs.Add(job2);

         resume.Display();

    }
 
}