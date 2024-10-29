using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation3 World!");

        List<Activity> activities = new List<Activity>();

        Swimming swimming = new Swimming("03 Nov 2022", 60, 40);
        //        Console.WriteLine(swimming.GetSummary());

        activities.Add(swimming);

        Running running = new Running("03 Nov 2022", 30, 4.8);
        //        Console.WriteLine(running.GetSummary());

        activities.Add(running);

        Cycling Cycling = new Cycling("22 Dec 2024", 45, 12.0);

        activities.Add(Cycling);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }


}