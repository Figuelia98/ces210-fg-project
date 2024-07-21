using System;
namespace Develop05;

public class EternalGoal : Goal
{
    private bool _hComplete = false;
    private int _amountAccomplishment = 0;

    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {

    }
    public override void RecordEvent()
    {
      _score += int.Parse(_points);
      _amountAccomplishment +=1;  
    }
    public override bool hComplete()
    {
        return _hComplete;
    }
    public override string GetStringRepresentation()
    {
         string representation = $"Eternal Goal,{_shortName},{_description},{_points},{_score}";
        return representation;
    }
}