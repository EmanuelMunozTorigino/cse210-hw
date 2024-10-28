public class EternalGoal : Goal
{

    public EternalGoal(string name, string description, string points) : base(name, description, points) { }

    public override void RecordEvent()
    {

    }

    public override bool isComplete()
    {
        return true;
    }

    public override string GetStringRepresentation()
    {
        string shortName = getShortName();
        string description = getDescription();
        string points = getPoints();
        return $"ChecklistGoal:{shortName},{description},{points}";
    }

}


