using System;
namespace Develop05;

public abstract class Goal
{
    protected string _shortName = "";
    protected string _description = "";
    protected string _points  = "";
    protected int _score = 0;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    public string getShortName(){
        return _shortName;
    }   
    public int getScore(){
        return _score;
    } 
    public void setScore(int score){
        _score = score;
    }
   
    public string getPoint(){
        return _points;
    }
    public abstract void RecordEvent();
    public abstract bool hComplete();
    public virtual string DetailsString(){
        if (hComplete()){
          return $"[X] {_shortName}({_description}) ";
        }
        else{
           return $"[ ] {_shortName}({_description}) ";
        }
       
    }
    public abstract string GetStringRepresentation();

}