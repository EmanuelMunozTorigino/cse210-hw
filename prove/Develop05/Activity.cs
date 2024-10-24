public class Activity
{
    private string _name;
    private string _description;
    private int _duration;


    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write($"How long in seconds, would you like for your session? ");

        _duration = int.Parse(Console.ReadLine());
        Console.Clear();

        Console.WriteLine("Get Ready...");
        DisplaySpinner(5);
        Console.WriteLine();
    }


    public int GetDuration()
    {
        return _duration;
    }

    public void DisplayEndingMessage()
    {
        //  Console.WriteLine("Well done!!");
        Console.WriteLine("You are the best!");

        Thread.Sleep(1000);
        DisplaySpinner(5);
        Console.WriteLine();
        Console.WriteLine($"You have completed {_name} Activity for {_duration} seconds");
        Thread.Sleep(1000);
        DisplaySpinner(5);
    }

    public void DisplaySpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {

            Console.Write("\b \b-");
            Thread.Sleep(250);
            Console.Write("\b \b\\");
            Thread.Sleep(250);
            Console.Write("\b \b|");
            Thread.Sleep(250);
            Console.Write("\b \b/");
            Thread.Sleep(250);
            // List<string> stringAnimation = ["|","/","-","\\"];

        }
        Console.Write("\b \b");
    }

    public void DisplayCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\b \b{i}");
            Thread.Sleep(1000);
        }
        Console.Write($"\b \b");
    }



}