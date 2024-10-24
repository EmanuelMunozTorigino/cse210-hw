
public class Circle : Shape
{
    private double _radius;
    private double _pi = Math.PI;


    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        double radiusPi = _pi * _radius;
        return Math.Round(Math.Pow(radiusPi, 2));
    }

}




/*
public void SetRadius(double radius)
{
    _radius = radius;
}

public double GetRadius()
{
    return _radius;
}
*/