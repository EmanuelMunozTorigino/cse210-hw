public class Activity {
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity () {

    }

    public Activity (string name, string description, int duration) {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage() {
        Console.WriteLine($"Welcome to the {_name} Activity");
    }

    public void DisplayEndingMessage() {

}

    public void ShowSpinner(int seconds) {

    }

}