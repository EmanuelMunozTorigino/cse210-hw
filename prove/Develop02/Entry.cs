public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    // Wiht an empty constructor
    //    public Entry() {}


    // With an explicit constructor 
    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }


    public void DisplayEntry()
    {

        Console.WriteLine($"Date: {_date} | Prompt: {_promptText}");
        Console.WriteLine($"Answer: {_entryText}");
        Console.WriteLine();
    }
}