using System;

class Program
{
    static void Main(string[] args)
    {   // Getting the grade in percent from the user
        Console.Write("What is your grade in percent? ");
        string gradeStr = Console.ReadLine();
        // Converting the grade to number
        int grade = int.Parse(gradeStr);
        int lastDigit= grade % 10;
         
        string letter;
        if(grade >= 90){
          
            if (lastDigit < 3){
                letter="A-";
            }
            else{
                letter="A";
            }
           
        }
        else if(grade>=80){

            if(lastDigit >= 7){
                letter="B+";
            }
            else if (lastDigit < 3){
                letter="B-";
            }
            else{
               letter="B";
            }
        }
        else if(grade>=70){

            if(lastDigit >= 7){
                letter="C+";
            }
            else if (lastDigit < 3){
                 letter="C-";
            }
            else{
                letter="C";
            }
        }
        else if(grade>=60){

            if(lastDigit >= 7){
                letter="D+";
            }
            else if (lastDigit < 3){
                 letter="D-";
            }
            else{
                letter="D";
            }
        }
        else{

            letter="F";
        }
       
        // Print the letter grade and the result
        Console.WriteLine($"You grade is {letter}");

       if(grade >=70){

        Console.WriteLine("Congratulation You passed!");
       }
       else{
        Console.WriteLine("Need more effort next time!");
       }
    }
}