using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        List<int> numbers= new List<int>();
        
        string numberFromUser;
        int numberVersion;
        float average;
        float sum=0;
        int min=1000000;
        int max=0;


        do{

            Console.Write("Enter number: ");
            numberFromUser=Console.ReadLine();
            numberVersion=int.Parse(numberFromUser);
            numbers.Add(numberVersion);
            
            }
        while(numberVersion!=0);

        
        for(int i = 0; i < numbers.Count; i++){

           sum=sum+numbers[i]; 
           if(min > numbers[i] && numbers[i] > 0){

              min = numbers[i];
           }
        
          if(max < numbers[i]){
              
              max = numbers[i];

          }
           
        }
        average=((float)sum)/numbers.Count;
      Console.WriteLine($"The sum is: {sum}");      
      Console.WriteLine($"The average is: {average}");
      Console.WriteLine($"The largest number is: {max}"); 
      Console.WriteLine($"The smallest positive number is: {min}"); 

      numbers.Sort();
      Console.WriteLine("This is the sorted list:"); 

      for(int i = 0; i < numbers.Count;i++){

        Console.WriteLine(numbers[i]);
      }       

    }
}