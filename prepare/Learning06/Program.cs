using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning06 World!");

        List<Shape> listShapes = new List<Shape>();

        Square blueSquare = new Square("Blue", 5);

        Rectangle redRectangle = new Rectangle("Purple", 6, 4);

        Circle greenCircle = new Circle("Black", 3);

        listShapes.Add(blueSquare);
        listShapes.Add(redRectangle);
        listShapes.Add(greenCircle);

        foreach (Shape shape in listShapes)
        {
            /*
            Console.WriteLine($"The color of the shape is: {shape.GetColor()}");
            Console.WriteLine();
            Console.WriteLine($"The are of the shape is: {shape.GetArea()}");
            
            */
            Console.WriteLine($"The area of the {shape.GetColor()} shape is: {shape.GetArea()}");
            Console.WriteLine();
        }

    }
}