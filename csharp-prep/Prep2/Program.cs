using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep2 World!");


        Console.WriteLine("What was your grade? (0-100): ");
        string grade = Console.ReadLine();
        int gradeNumber = int.Parse(grade);

        int remainderGrade = gradeNumber % 10;


        string sign = "";

        string letter = "";

        // Check the score and its relatives letter grade

        if (gradeNumber >= 90)
        {
            letter = "A";
        }
        else if (gradeNumber >= 80)
        {
            letter = "B";
        }

        else if (gradeNumber >= 70)
        {
            letter = "C";
        }

        else if (gradeNumber >= 60)
        {
            letter = "D";
        }

        else if (gradeNumber < 60)
        {
            letter = "F";
        }

        // Verify if the letter has a - or + sign after grade letter

        if (remainderGrade >= 7)
        {
            sign = "+";
        }
        else if (remainderGrade < 3)
        {
            sign = "-";
        }


        // There is not a + sign for an "A" and there is no sign for an 'F' grade, so its ommits the sign or restore its value to an empty string
        if (letter == "A" && remainderGrade >= 7 || letter == "F")
        {
            sign = "";
        }

        // print the score following to its sign if 
        Console.WriteLine($"You get a '{letter}{sign}'");


        // A congrats message or an encourage message to next term is display!
        if (gradeNumber >= 70)
        {
            Console.WriteLine("You passed the class");
        }

        else
        {
            Console.WriteLine("Sorry, try next semester, you can achieve it");
        }


    }
}