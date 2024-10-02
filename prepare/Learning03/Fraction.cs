

using System.Dynamic;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }


    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetTop()
    {
        return _top;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public string GetFractionalString()
    {
        return $"{_top}/{_bottom}";

        /*
        Console.WriteLine($"{_top}/{_bottom}");
        Console.WriteLine();
        Console.WriteLine(_top);
        Console.WriteLine("_");
        Console.WriteLine(_bottom);
        */
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }

}
