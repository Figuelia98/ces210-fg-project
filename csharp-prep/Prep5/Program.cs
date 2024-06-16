using System;

class Program
{
    static void Main(string[] args)
    {
      DisplayWelcome();
     string userName = PromptUserName();
     int userNumber= PromtUserNumber();

     DisplayResult(userName,userNumber);
    }
    static void DisplayWelcome(){

        Console.WriteLine("Welcome to the program");
    }
    static string PromptUserName(){
        
        Console.Write("Please enter your name:  ");
        string userName=Console.ReadLine();

        return userName;

    }

    static int PromtUserNumber(){

         
        Console.Write("Please enter your favorite number:  ");
        string userNumber=Console.ReadLine();
        int number = int.Parse(userNumber);
       
        return number;
    }
    static void DisplayResult(string name,int number){

        Console.WriteLine($"{name}, the square of your number is {number*number} ");
    }

}