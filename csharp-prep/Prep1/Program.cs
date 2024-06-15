using System;

class Program
{
    static void Main(string[] args)
    {   // Print the asking first name question and get the answer 
        Console.Write("What is your first name? ");
        string FirstName = Console.ReadLine();
        // Print the asking last name question and get the answer 
        Console.Write("What is your last name? ");
        string LastName = Console.ReadLine();

        Console.WriteLine($"Your name is {LastName}, {FirstName} {LastName}.");
    }
}