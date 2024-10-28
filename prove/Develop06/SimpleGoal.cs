public class SimpleGoal : Goal {

    private bool _isComplete;
    public SimpleGoal(string name, string description, string points) : base(name, description, points){
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        isComplete();
        string points = GetPoints();
        Console.WriteLine($"Congratulations! You earned {points} points!");
    }

    public override bool isComplete()
    {
        return true;
    }

    public override string GetStringRepresentation()
    {        
        string shortName = GetShortName();
        string description = GetDescription();
        string points = GetPoints();
        return $"SimpleGoal:{shortName},{description},{points}";
    }

}