using System;
using System.IO;
public class PromptGen
{
    //Create an array that content all the prompt
    
    Random rando= new Random();
    public int _pickId ;
    public string _picked;


    //Define method that return one of the prompt

    public string PromptGenerator(){

    string filename = "prompts.csv";
    string[] lines=File.ReadAllLines(filename);
    int num = rando.Next(1,5);
    _pickId = num;

    foreach (string line in lines){

        string [] parts = line.Split(",");
        
        if(_pickId == int.Parse(parts[0])){
        
          _picked = parts[1];

          break;
          
        }
    }
    return _picked;
    }


}