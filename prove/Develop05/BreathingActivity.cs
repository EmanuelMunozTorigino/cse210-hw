public class BreathingActivity : Activity
{

    public BreathingActivity() : base("Breathing", "his activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {

    }


    public void Run()
    {
        DisplayStartingMessage();


        int duration = GetDuration();

        DateTime startTime = DateTime.Now;

        DateTime futureTime = startTime.AddSeconds(duration);

        Thread.Sleep(2000);




        Console.Write("Breathe in...");
        DisplayCountDown(2);
        Console.WriteLine("");
        Console.Write($"Breathe out...");
        DisplayCountDown(3);
        Console.WriteLine("");
        Console.WriteLine("");

        while (DateTime.Now < futureTime)
        {
            Console.Write("Breathe in...");
            DisplayCountDown(4);
            Console.WriteLine("");
            Console.Write($"Breathe out...");
            DisplayCountDown(6);
            Console.WriteLine("");
            Console.WriteLine("");
        }

        Console.Clear();

        DisplayEndingMessage();

    }

    /*
        public void GetDurations()
        {
            
    */


    /*
    DateTime currentTime = DateTime.Now;

    if (currentTime < futureTime)
    {
        Console.WriteLine("We have not arrived at our future time yet...")
    }
    */
}
