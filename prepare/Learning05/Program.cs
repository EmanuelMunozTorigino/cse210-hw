using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning05 World!");

        // Assignment instance
        Assignment assignment1 = new Assignment("Emanuel Muñoz", "Programming with classes");
        Console.WriteLine(assignment1.GetSummary());

        // Math Assignment
        MathAssignment assignment2 = new MathAssignment("Hunter Jhonson", "Limits", "7.3", "8-19");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());

        // Writing Assignment
        WritingAssignment assignment3 = new WritingAssignment("Emely Smith", "European History", "The Causes of World War II");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());




    }
}