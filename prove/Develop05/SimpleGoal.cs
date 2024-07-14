using System;
namespace Develop05;

public class SimpleGoal:Goal
{
    private bool _hComplete = false;

    public SimpleGoal(string name, string description, string points):base(name, description, points)
    {

    }
    public override void RecordEvent()
    {
       
    }
    public override bool hComplete()
    {
        throw new NotImplementedException();
    }
    public override string GetStringRepresentation()
    {
        throw new NotImplementedException();
    }
}