public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, int duration, double speed) : base(date, duration)
    {
        _speed = speed;
    }

    public override double CalculatePace() {
        return 60 / _speed;
    }

    public override double CalculateSpeed() {
        return _speed;
        }

    public override double CalculateDistance() {
        return  _speed * GetDuration() / 60 ;
    }

}
