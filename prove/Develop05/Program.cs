using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");


        for (int i = 0; i < 7; i++)
        {
            
            

            Console.Write("/");

            Thread.Sleep(500);
            Console.Write("-");
            Console.Write("\b");
            Console.Write("|");

        }

    }



}