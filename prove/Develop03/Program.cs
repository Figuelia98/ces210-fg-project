using System;

class Program
{
    static void Main(string[] args)
    {   string book = "3 Nephi";
        int chapiter = 12;
        int verse = 44;
        string programStat="running";
        string scriptureText = "But behold I say unto you, love your enemies, bless them that curse you, do good to them that hate you, and pray for them who despitefully use you and persecute you";

        Reference reference = new Reference(book,chapiter,verse);

        Scripture scripture =  new Scripture(reference,scriptureText);
        
        string userWrite;
       
        while(programStat!="quit")
        {
            Console.WriteLine($"{reference.GetDisplayText()}-{scripture.GetDisplayText()}");
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");

           if(scripture.IsCompletelyHidden()==true){
            programStat="quit";
           }
           else{
            userWrite = Console.ReadLine();
           if(userWrite!="quit"){
            scripture.HideRandomWord(3);
            Console.Clear();
           }
           else{
            programStat = userWrite;
           }


           }
         
        }


    }
}