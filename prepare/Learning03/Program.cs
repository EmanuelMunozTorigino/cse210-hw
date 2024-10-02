using System;

class Program
{
    static void Main(string[] args)
    {
        //   Console.WriteLine("Hello Learning03 World!");


        Fraction emptyFraction = new Fraction();

        Console.WriteLine($"The String fraction Notation is: {emptyFraction.GetFractionalString()}");
        Console.WriteLine($"The Decimal fraction Notation is: {emptyFraction.GetDecimalValue()}");


        Fraction fraction = new Fraction(5);

        Console.WriteLine($"The String fraction Notation is: {fraction.GetFractionalString()}");
        Console.WriteLine($"The Decimal fraction Notation is: {fraction.GetDecimalValue()}");

        Fraction completeFraction = new Fraction(3, 4);

        Console.WriteLine($"The String fraction Notation is: {completeFraction.GetFractionalString()}");
        Console.WriteLine($"The Decimal fraction Notation is: {completeFraction.GetDecimalValue()}");


        fraction.SetTop(1);
        fraction.GetTop();
        fraction.SetBottom(3);
        fraction.GetBottom();

        Console.WriteLine($"The String fraction Notation is: {fraction.GetFractionalString()}");
        Console.WriteLine($"The Decimal fraction Notation is: {fraction.GetDecimalValue()}");



    }
}