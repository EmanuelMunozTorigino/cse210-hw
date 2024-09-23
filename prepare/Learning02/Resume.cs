



public class Resume
{
    public string _personName;
    public List<Job> _Jobs = new List<Job>();


    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_personName}");

        Console.WriteLine("Jobs:");

        foreach (Job job in _Jobs)
        {
            job.DisplayJobInfo();
        }
    }
}