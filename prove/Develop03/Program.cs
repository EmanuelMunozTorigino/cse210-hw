using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop03 World!");



        // Reference with one verse,
        Reference reference = new Reference("Jhon", 17, 3);
        Scripture scripture = new Scripture(reference, "And this is life eternal, that they might know thee the only true God, and Jesus Christ, whom thou hast sent.");


        // A serie of verses.!
        /*        Reference reference1 = new Reference("Jhon", 10, 17, 18);
                Scripture scripture1 = new Scripture(reference1, "Therefore doth my Father love me, because I lay down my life, that I might take it again. No man taketh it from me, but I lay it down of myself. I have power to lay it down, and I have power to take it again. This commandment have I received of my Father.");
        */
        Console.WriteLine("~~~~~~~~~~~~~~~ Welcome to Scripture Memorizer program ~~~~~~~~~~~~~~~");

        while (!scripture.IsCompletelyHidden())
        {
            // Clear the screen and display the whole scripture           
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());


            Console.WriteLine("Type the Enter key to hidden some words or 'quit' to finish.");

            string userAnswer = Console.ReadLine();

            if (userAnswer.ToLower() == "quit")
            {
                Console.Clear();
                Console.WriteLine("The program is finished");
                break;
            }

            scripture.HideRandmomWords(2);
        }


        if (scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine("The scripture was completely Hidden");
        }

    }
}