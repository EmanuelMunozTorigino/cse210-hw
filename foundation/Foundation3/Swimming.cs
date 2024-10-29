public class Swimming : Activity
{
    private int _quantityLaps;

    public Swimming(string date, int duration, int Laps) : base(date, duration)
    {
        _quantityLaps = Laps;
    }

    public override double CalculateDistance()
    {
        return _quantityLaps * 50 / 1000;
    }
}