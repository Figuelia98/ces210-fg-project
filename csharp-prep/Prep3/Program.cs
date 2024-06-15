using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {   string game="yes";
       while(game=="yes"){




      
        //Generate the random number
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101);
        //Starting the game
        Console.WriteLine("Get ready to guess!");
        string guessFromUser;
        int guess;
        int counter = 0;
        //Game loop
        do{

          Console.Write("What is your guess? ");
          guessFromUser=Console.ReadLine();
          guess = int.Parse(guessFromUser);
          counter=counter+1;

          if(guess > magicNumber){
            Console.WriteLine("Lower");
          }
          else if(guess < magicNumber){
            Console.WriteLine("Higher");
          }
        }
        while(guess != magicNumber);
        
        //Print the success game with the counter 
        Console.WriteLine($"Congratulation you guessed at the {counter} times");

        Console.WriteLine("Do you want to play again? (yes/no) ");
        game=Console.ReadLine();

         }
    }
}