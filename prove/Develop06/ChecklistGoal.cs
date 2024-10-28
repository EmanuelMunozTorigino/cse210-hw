public class checklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public checklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override void RecordEvent()
    {

    }
    public override bool isComplete()
    {
        return true;
    }
    public override string GetDetailsString()
    {
        string shortName = GetShortName();
        string description = GetDescription();

        if (isComplete())
        {
            return $"[X] {shortName} ({description}) -- Currently completed {_amountCompleted}/{_target}";
        }
        else
        {
            return $"[ ] {shortName} ({description}) -- Currently completed {_amountCompleted}/{_target}";
        }

    }

    public override string GetStringRepresentation()
    {
        string shortName = GetShortName();
        string description = GetDescription();
        string points = GetPoints();
        return $"ChecklistGoal:{shortName},{description},{points},{_bonus},{_amountCompleted},{_target}";
    }

}