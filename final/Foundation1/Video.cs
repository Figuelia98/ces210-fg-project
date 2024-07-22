using System;
namespace Foundation1;

public class Video{
 
 private  string _title;
 private string _author;
 private int _length;

 private List<Comment> _comments = new List<Comment>();

 public Video(string title, string author,int length ){

    _title = title;
    _author = author;
    _length = length;


 }
 public void displayVideoInfo(){
   
   Console.WriteLine($"{_title} by {_author}, length: {_length} minutes");
   Console.WriteLine();
   Console.WriteLine("Comments:");
   foreach(Comment comment in _comments){

     comment.DisplayComment();
     Console.WriteLine();
    }
 }

 public void SetComment(string userName, string userComment){

   Comment newComment = new Comment(userName,userComment);
   _comments.Add(newComment);
 }

}