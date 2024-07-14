using System;
namespace Develop05;

public class ChecklistGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
      _target=target;
      _bonus=bonus;
    }
    public override void RecordEvent()
    {

    }
    public override bool hComplete()
    {
        throw new NotImplementedException();
    }
    public override string DetailsString()
    {
        return base.DetailsString();
    }
    public override string GetStringRepresentation()
    {
        throw new NotImplementedException();
    }
}