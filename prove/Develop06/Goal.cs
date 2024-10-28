public abstract class Goal
{
    private string _shortName;
    private string _description;
    private string _points;

    public Goal(string shortName, string description, string points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public string GetShortName()
    {
        return _shortName;
    }
    public string GetDescription()
    {
        return _description;
    }

    public string GetPoints()
    {
        return _points;
    }

    public abstract void RecordEvent();

    public abstract bool isComplete();

    public virtual string GetDetailsString()
    {
        if (isComplete()){
            return $"[X] {_shortName} ({_description})";

        }
        else {
            return $"[ ] {_shortName} ({_description})";
        }
    }

    public abstract string GetStringRepresentation();

}