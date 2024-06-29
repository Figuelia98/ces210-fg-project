using System;

public class Reference
{

    private string _book;
    private int _chapiter;
    private int _verse;
    private int _endVerse=0;

    public Reference(string book, int chapiter, int verse)
    {
      _book = book;
      _chapiter = chapiter;
      _verse = verse;
    }
    public Reference(string book, int chapiter, int startVerse, int endVerse){
     _book = book;
     _chapiter = chapiter;
     _verse = startVerse;
     _endVerse = endVerse;

    }

    public string GetDisplayText()
    {   
        string reference;
        
        if (_endVerse == 0){
           
            reference=$"{_book} {_chapiter}: {_verse}";

         }
         else{
            reference=$"{_book} {_chapiter}: {_verse}-{_endVerse}";
         }

         return reference;
        
    }
}  