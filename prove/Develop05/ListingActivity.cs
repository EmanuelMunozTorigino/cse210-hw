public class ListingActivity : Activity
{

    private int _count = 0;
    private List<string> _prompts;

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }


    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("List as many responses you can to this Ponder Question:");

        GetRandomPrompt();

        Console.Write("You may begin in:  ");
        DisplayCountDown(5);
        Console.WriteLine();

        Console.WriteLine();
        Console.WriteLine("Your list: ");

        GetListFromUser();

        Console.WriteLine();

        DisplayEndingMessage();
        Console.Clear();
    }

    public void GetRandomPrompt()
    {

        _prompts = [
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
        ];

        Random random = new Random();

        int index = random.Next(_prompts.Count);


        string prompt = _prompts[index];

        Console.WriteLine($"*** {prompt} ***");
    }

    public void GetListFromUser()
    {

        int duration = GetDuration();

        DateTime startTime = DateTime.Now;

        DateTime futureTime = startTime.AddSeconds(duration);

        while (DateTime.Now < futureTime)
        {
            Console.Write($"> ");
            Console.ReadLine();
            _count++;
        }

        if (_count <= 1)
        {
            Console.WriteLine($"You listed {_count} item!");
        }
        else
        {
            Console.WriteLine($"You listed {_count} items!");
        }


    }
}