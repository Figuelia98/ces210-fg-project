using System;
namespace Develop05;

public class SimpleGoal:Goal
{
    private bool _hComplete = false;

    public SimpleGoal(string name, string description, string points):base(name, description, points)
    {

    }
    public override void RecordEvent()
    {   _score = int.Parse(_points);
        _hComplete = true;
    }
    public override bool hComplete()
    {
       
        return _hComplete;
    }
    public override string GetStringRepresentation()
    {
        string representation = $"Simple Goal,{_shortName},{_description},{_points},{_hComplete},{_score}";
        return representation;

    }
}