using System;
namespace Foundation1;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Abstraction Foundation");
        List <Video> videos = new List<Video>();
        //Define object video
        Video video01 = new Video("Gospel Song","David",5);
        Video video02 = new Video("Child animation", "OnlineToonly", 25);
        Video video03 = new Video("Movies","Disney",44);
        Video video04 = new Video("Documentary","OnlineSearch",30);
        //Set comment  
        video01.SetComment("Jean Gophe", "Very nice song, keep up the good work! ");
        video01.SetComment("Patrick Halen", "Always to listen your song");
        video01.SetComment("Sary Jose", "What a masterpiece, Thank you ");
        //Set comment
        video02.SetComment("Maria Andre", "These animations are very good ");
        video02.SetComment("Brian Ferra", "My child like this animation");
        video02.SetComment("Drish Nathan", "Funny to watch");
        //Set Comment
        video03.SetComment("Olivier Matu", "Happy to see that");
        video03.SetComment("Glario Feria", "Wonderful story");
        video03.SetComment("Pary Feno", "I love this one");
        //Set Comment
        video04.SetComment("Muarry Fahima", "Very nice");
        video04.SetComment("Dieras Muasy", "Intersting");
        video04.SetComment("Nuaro Buano", "Need more like this");

        videos.Add(video01);
        videos.Add(video02);
        videos.Add(video03);
        videos.Add(video04);

        foreach(Video  videov in videos){

            videov.displayVideoInfo();
        }



    }
}