using System;

class Program
{
    static void Main(string[] args)
    {
        //   Console.WriteLine("Hello Learning02 World!");


        Job job1 = new Job();

        job1._jobTitle = "Software Engineer";
        job1._company = "open AI";
        job1._startYear = 2020;
        job1._endYear = 2023;


        Job job2 = new Job();

        job2._jobTitle = "Data Analyst";
        job2._company = "Apple";
        job2._startYear = 2018;
        job2._endYear = 2019;

        // job1.DisplayJobInfo();
        // job2.DisplayJobInfo();


        Resume myResume = new Resume();

        myResume._personName = "Emanuel Muñoz";

        myResume._Jobs.Add(job1);
        myResume._Jobs.Add(job2);

        // Console.WriteLine(myResume._Jobs[0]._jobTitle);

        myResume.DisplayResume();

    }
}