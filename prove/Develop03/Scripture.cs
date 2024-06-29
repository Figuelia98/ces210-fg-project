using System;

public class Scripture
{

    private Reference _reference;
    private List<Word> _words= new List<Word>();

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;

        string [] splited = text.Split(" ");
        int length = splited.Length;
        Word newWord;

        for (int i = 0; i < length; i++)
        {
            newWord = new Word(splited[i]);
            _words.Add(newWord);

        }

    }
    public void HideRandomWord( int numberToHide)
    {
     Random random = new Random();
    
     int len =_words.Count;
     int successHideCount=0;
     int choice;
     int counter = 0;
      for (int i = 0; i < len; i++)
      {
          if(_words[i].IsHidden()==false){
            counter +=1;
          }   
      }
     
     while(successHideCount != numberToHide){

        choice = random.Next(0,len);
       
        if(_words[choice].IsHidden() == false){
            
          _words[choice].Hide();
          successHideCount +=1;
        }
         if(counter < numberToHide){
            numberToHide = counter;
        }

        
     }


    }
    public string GetDisplayText()
    {
       string text="";
       int len =_words.Count;
       string space;
       for (int i = 0;i < len; i++)
       {    if(i==0)
        {
           space="";  
        }
        else
        {
            space=" ";
        }
            text += $"{space}{_words[i].GetDisplayText()}";
          
       }
       return text;


    }

    public bool IsCompletelyHidden()
    {
      int len = _words.Count;
      int counter = 0;
      bool state = false;

      for (int i = 0; i < len; i++)
      {
          if(_words[i].IsHidden()==false){
            counter +=1;
          }   
      }
      if(counter==0){
        state=true;
      }
      return state;
    }

}