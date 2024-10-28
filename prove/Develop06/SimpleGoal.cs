public class SimpleGoal : Goal {

    private bool _isComplete;
    public SimpleGoal(string name, string description, string points) : base(name, description, points){
        _isComplete = false;
    }

    public override void RecordEvent()
    {
         if (_isComplete) {

         }
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
        return $"SimpleGoal:{shortName},{description},{points}";
    }

}