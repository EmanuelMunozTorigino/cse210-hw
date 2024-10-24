using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop05 World!");

        string menuOptions = """
Menu Options:
    1. Start breathing activity
    2. Start reflecting activity
    3. Start listing activity
    4. quit
""";
        Console.WriteLine(menuOptions);
        Console.Write("Select a choice from the menu: ");
        string option = Console.ReadLine();

        while (option != "4")
        {
            // Clear the console to swow the specific activity..
            Console.Clear();

            switch (option)
            {

                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();

                    break;
                case "2":
                    ReflectingActivity reflecting = new ReflectingActivity();

                    break;
                case "3":
                    ListingActivity listing = new ListingActivity();
                    break;

                default:
                    Console.WriteLine("You chose a invalid option");
                    Console.WriteLine("Type again");
                    break;
            }
            // Clear the screen to show the Menu..
            Console.Clear();
            Console.WriteLine(menuOptions);
            Console.Write("Select a choice from the menu: ");
            option = Console.ReadLine();
        }

    }



}