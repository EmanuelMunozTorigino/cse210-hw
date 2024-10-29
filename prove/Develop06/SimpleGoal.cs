public class SimpleGoal : Goal {

    private bool _isComplete;
    public SimpleGoal(string name, string description, string points) : base(name, description, points){
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
        string points = GetPoints();
        Console.WriteLine($"Congratulations! You earned {points} points!");
    }

    public void SetIsComplete(bool isComplete) {
        _isComplete = isComplete;
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {        
        string shortName = GetShortName();
        string description = GetDescription();
        string points = GetPoints();
        return $"SimpleGoal:{shortName},{description},{points},{_isComplete}";
    }

}