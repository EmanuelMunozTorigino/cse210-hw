public class ListingActivity : Activity
{

    private int _count;
    private List<string> _prompts = [
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
        ];

    public ListingActivity() : base("Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        
    }


    public void Run()
    {
        DisplayStartingMessage();
    }



}