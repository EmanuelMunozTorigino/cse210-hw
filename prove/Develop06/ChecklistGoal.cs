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

    public void SetAmountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }

    public int GetBonus()
    {
        return _bonus;
    }
    public override void RecordEvent()
    {
        _amountCompleted++;

        if (IsComplete())
        {
            int totalPoints = int.Parse(GetPoints()) + _bonus;
            SetPoints(totalPoints.ToString());
        }

        else {
            string points = GetPoints();
            Console.WriteLine($"Congratulations! You earned {points} points!");            
        }
    }
    public override bool IsComplete()
    {
        return _amountCompleted == _target;

    }
    public override string GetDetailsString()
    {

        return $"{base.GetDetailsString()} -- Currently completed {_amountCompleted}/{_target}";

        /*
    
        string shortName = GetShortName();
        string description = GetDescription();
    
        if (isComplete())
        {
            return $"[X] {shortName} ({description}) ;
        }
        else
        {
            return $"[ ] {shortName} ({description}) -- Currently completed {_amountCompleted}/{_target}";
        }
    
        */

    }

    public override string GetStringRepresentation()
    {
        string shortName = GetShortName();
        string description = GetDescription();
        string points = GetPoints();
        return $"ChecklistGoal:{shortName},{description},{points},{_bonus},{_amountCompleted},{_target}";
    }

}