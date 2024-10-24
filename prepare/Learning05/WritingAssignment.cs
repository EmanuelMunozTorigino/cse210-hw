public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        //return $"{_title} by {GetStudentName()}";

        // A better, understandable and readable way..
        string studentName = GetStudentName();
        return $"{_title} by {studentName}";
    }


}