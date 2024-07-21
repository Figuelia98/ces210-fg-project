using System;
namespace Develop05;

public class ChecklistGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;
    private bool _hComplete= false;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
      _target=target;
      _bonus=bonus;
    }
    public override void RecordEvent()
    {
      if (_amountCompleted < _target){
        _amountCompleted += 1;
        _score += int.Parse(_points);
      }
      else{
         _score += _bonus;
         _hComplete = true;
         
      }
    }
    public override bool hComplete()
    {
        return _hComplete;
    }
    public override string DetailsString()
    {
         if (hComplete()){
          return $"[X] {_shortName}({_description}) -- Currently Completed {_amountCompleted}/{_target} ";
        }
        else{
           return $"[ ] {_shortName}({_description}) -- Currently Completed {_amountCompleted}/{_target} ";
        }
    }
    public override string GetStringRepresentation()
    {
         string representation = $"Checklist Goal,{_shortName},{_description},{_points},{_hComplete},{_amountCompleted},{_target},{_bonus},{_score}";
        return representation;
    }
}