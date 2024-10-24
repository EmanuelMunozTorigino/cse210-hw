public class Rectangle : Shape {
    private double _width;
    private double _lenght;

    public Rectangle (string color, double width, double lenght) : base(color)
    {
        _width = width;
        _lenght = lenght;
    }
    

    public void SetWidth(double lenght) {
        _width = lenght;
    }

    public double GetWidth() {
        return _width;
    }

    public void SetLenght(double lenght) {
        _lenght = lenght;
    }

    public double GetLenght() {
        return _lenght;
    }

    public override double GetArea() {
        return _width * _lenght;
    } 

}