

public class Comment
{
    private string _personName;
    private string _comment;


    public Comment(string personName, string comment)
    {
        _personName = personName;
        _comment = comment;

    }

    public void DisplayComment()
    {
        Console.WriteLine($"{_personName} - {_comment}");
    }

}