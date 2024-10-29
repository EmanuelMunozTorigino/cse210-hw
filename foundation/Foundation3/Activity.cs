using System.Data.SqlTypes;

public class Activity
{
    private string _date;
    private int _duration;

    public Activity(string date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public virtual double CalculateDistance()
    {
        return 0.0;
    }
    public virtual double CalculateSpeed()
    {
        return CalculateDistance() / _duration * 60;
    }
    public virtual double CalculatePace()
    {
        return _duration / CalculateDistance();
    }

    public string GetSummary()
    {
        if (GetType().Name.ToLower() == "cycling")
        {
            return $"{_date}: {GetType().Name} ({_duration} min.) : Distance {CalculateDistance()} km, Speed: {CalculateSpeed()} kph";
        }
        else
        {
            return $"{_date}: {GetType().Name} ({_duration} min.) : Distance {CalculateDistance()} km, Speed: {CalculateSpeed()} kph, Pace: {CalculatePace()} min. per km";
        }
    }

}