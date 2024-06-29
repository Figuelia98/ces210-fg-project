using System;
using System.Dynamic;

public class Word{

   private string _text;
   private bool _isHidden = false ;

   public Word(string text)
   {
        
        _text = text;
   }
   public void Hide()
   {
     _isHidden=true;
   }
   public void Show()
   {
    _isHidden=false;
   } 
   public bool IsHidden()
   {
     return _isHidden;
   }
   public string GetDisplayText()
   {
     string text="";
     if(_isHidden)
     {  for(int i = 0; i < _text.Length; i++)
     {
        if(i==0){
            text = "_"; 
        }
        else{
            text += "_";
        }

     }
        
     }
     else
     {
       text = _text;
     }

     return text;

   }
}