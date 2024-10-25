public class ReflectingActivity : Activity
{

    private List<string> _prompts;
    private List<string> _questions;


    public ReflectingActivity() : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {

    }

    public void Run()
    {
        DisplayStartingMessage();

        DisplayPrompt();

        Console.Write("When you have something in mind, press enter to continue: ");
        Console.ReadLine();

        Console.WriteLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        DisplayCountDown(5);

        Console.Clear();

        DisplayQuestions();
        Console.WriteLine();

        DisplayEndingMessage();
    }


    public string GetRandomPrompt()
    {
        _prompts = [
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."];


        Random random = new Random();

        int index = random.Next(_prompts.Count);

        string prompt = _prompts[index];

        return prompt;
    }
    public string GetRandomQuestion()
    {
        _questions = [
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"];

        Random random = new Random();

        int index = random.Next(_questions.Count);

        string question = _questions[index];

        return question;
    }

    public void DisplayPrompt()
    {

        string prompt = GetRandomPrompt();

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"*** {prompt} ***");
        Console.WriteLine();
    }


    public void DisplayQuestions()
    {

        int duration = GetDuration();

        DateTime startTime = DateTime.Now;

        DateTime futureTime = startTime.AddSeconds(duration);

        while (DateTime.Now < futureTime)
        {
            string question = GetRandomQuestion();
            Console.Write($"> {question}  ");
            DisplaySpinner(10);
            Console.WriteLine();
        }

    }

}
