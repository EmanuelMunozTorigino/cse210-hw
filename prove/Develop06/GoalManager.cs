using System.Formats.Asn1;
using System.Xml.Serialization;

public class GoalManager
{

    private List<Goal> _goals;
    private int _score;


    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }


    public void Start()
    {
        string menu = ("""
Menu options:
  1. Create New Goal
  2. List Goals
  3. Save Goals
  4. Load Goals
  5. Record Event
  6. Quit
""");


        string choice = "-1";

        while (choice != "6")
        {

            Console.WriteLine();

            DisplayPlayerInfo();    // Called the method to display the current score

            Console.WriteLine();

            Console.WriteLine(menu);
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            switch (choice)
            {

                case "1":
                    {
                        CreateGoal();
                        break;
                    }
                case "2":
                    {
                        ListGoalDetails();
                        break;
                    }
                case "3":
                    {
                        Console.Write("Choose a file name (txt) to save the personal Goals: ");
                        string filenameSave = Console.ReadLine();
                        SaveGoals(filenameSave);
                        break;
                    }
                case "4":
                    {
                        Console.Write("Enter a file name (txt) to load the Goals details: ");

                        string filenameLoad = Console.ReadLine();

                        LoadGoals(filenameLoad);
                        break;
                    }
                case "5":
                    {
                        ListGoalNames();
                        break;
                    }
                case "6":
                    break;

                default:
                    {
                        Console.WriteLine("The choice that you type doesn't exist");
                        Console.WriteLine("Try again.");
                        break;
                    }
            }
        }

    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames()
    {
        int count = 1;
        Console.WriteLine("The Goals are:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal);
            Console.WriteLine($"{count}. {goal.GetShortName()}");
            count++;
        }

    }

    public void ListGoalDetails()
    {
        int index = 1;
        Console.WriteLine("The goals are:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{index}. {goal.GetDetailsString()}");
            index++;
        }
    }

    public void CreateGoal()
    {

        Console.WriteLine("""
The types of Goals are:
  1. Simple Goal
  2. Eternal Goal
  3. Checklist Goal
""");
        Console.Write("Which type of goal would you like to create? ");
        string goalToCreate = Console.ReadLine();

        switch (goalToCreate)
        {
            case "1":
                {
                    Console.Write("What is the name of your Goal? ");
                    string name = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string description = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    string points = Console.ReadLine();
                    SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                    _goals.Add(simpleGoal);
                    break;
                }
            case "2":
                {
                    Console.Write("What is the name of your Goal? ");
                    string name = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string description = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    string points = Console.ReadLine();
                    EternalGoal eternalGoal = new EternalGoal(name, description, points);
                    _goals.Add(eternalGoal);
                    break;
                }
            case "3":
                {
                    Console.Write("What is the name of your Goal? ");
                    string name = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string description = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    string points = Console.ReadLine();
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int target = int.Parse(Console.ReadLine());
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int bonus = int.Parse(Console.ReadLine());
                    checklistGoal checklistGoal = new checklistGoal(name, description, points, target, bonus);
                    _goals.Add(checklistGoal);
                    break;
                }
            default:
                {
                    Console.WriteLine("You don't type a correct choice");
                    Console.WriteLine("Try again.");
                    break;
                }
        }
    }

    public void RecordEvent()
    {
        ListGoalNames();

        Console.Write("Which goal did you accomplish? ");

        int answer = int.Parse(Console.ReadLine());


        foreach (Goal goal in _goals)
        {
            goal[1]


        }


        Console.WriteLine($"You now have {_score} points");
    }

    public void SaveGoals(string filename)
    {

        Console.WriteLine($"Saving to '{filename}' file..");

        using (StreamWriter outputFile = new StreamWriter(filename))
        {

            outputFile.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }


    }

    public void LoadGoals(string filename)
    {
        Console.WriteLine("File succesfully loaded..");

        string[] lines = System.IO.File.ReadAllLines(filename);

        int count = 0;
        foreach (string line in lines)
        {
            if (count == 0)
            {
                _score = int.Parse(line);
                count++;
                continue;
            }

            string[] Twoparts = line.Split(":");
            string goalName = Twoparts[0];

            switch (goalName)
            {
                case "SimpleGoal":
                    {
                        string[] parts = Twoparts[1].Split(",");
                        string name = parts[0];
                        string description = parts[1];
                        string points = parts[2];
                        SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                        _goals.Add(simpleGoal);

                        break;
                    }
                case "EternalGoal":
                    {
                        string[] parts = Twoparts[1].Split(",");
                        string name = parts[0];
                        string description = parts[1];
                        string points = parts[2];
                        EternalGoal eternalGoal = new EternalGoal(name, description, points);
                        _goals.Add(eternalGoal);
                        break;
                    }
                case "ChecklistGoal":
                    {
                        string[] parts = Twoparts[1].Split(",");
                        string name = parts[0];
                        string description = parts[1];
                        string points = parts[2];
                        int bonus = int.Parse(parts[3]);
                        int target = int.Parse(parts[4]);
                        checklistGoal checklistGoal = new checklistGoal(name, description, points, target, bonus);
                        _goals.Add(checklistGoal);
                        break;
                    }
                default:
                    Console.WriteLine("Goal type not found");
                    break;
            }
        }
    }
}