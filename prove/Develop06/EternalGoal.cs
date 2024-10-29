public class EternalGoal : Goal
{

    public EternalGoal(string name, string description, string points) : base(name, description, points) { }

    public override void RecordEvent()
    {
        string points = GetPoints();
        Console.WriteLine($"Congratulations! You earned {points} points!");
    }

    public override bool IsComplete()
    {    
        return false;
    }

    public override string GetStringRepresentation()
    {
        string shortName = GetShortName();
        string description = GetDescription();
        string points = GetPoints();
        return $"EternalGoal:{shortName},{description},{points}";
    }

}


