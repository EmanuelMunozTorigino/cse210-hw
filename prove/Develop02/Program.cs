using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("*** Welcome to the Journal program ***");
        Console.WriteLine();

        string answer = "";

        Journal myJournal = new Journal();

        PromptGenerator promptGenerator = new PromptGenerator();


        while (answer != "5")
        {

            //Console.WriteLine("Hello Develop02 World!");
            Console.WriteLine();
            Console.WriteLine("Please, select one of the following Options:");
            Console.WriteLine("1) Write some Thought");
            Console.WriteLine("2) Display the Journal");
            Console.WriteLine("3) Load the journal from a file");
            Console.WriteLine("4) Save the journal to a file");
            Console.WriteLine("5) Quit");
            Console.WriteLine();

            Console.Write("What would you like to do? ");
            answer = Console.ReadLine();
            Console.WriteLine();



            switch (answer)
            {
                case "1":

                    /* It was my first time doing it..

                    Entry entry = new Entry();
                    
                    DateTime theCurrentTime = DateTime.Now;
                    entry._date = theCurrentTime.ToShortDateString();


                    entry._promptText = promptGenerator.GetRandomPrompt();

                    Console.WriteLine(entry._promptText);

                    Console.Write("Answer: ");
                    entry._entryText = Console.ReadLine();
                    */

                    // Here with some modifications: 


                    DateTime theCurrentTime = DateTime.Now;
                    string date = theCurrentTime.ToString();

                    string question = promptGenerator.GetRandomPrompt();

                    Console.WriteLine(question);

                    Console.Write("Answer: ");
                    string entryAnswer = Console.ReadLine();

                    Entry entry = new Entry(date, question, entryAnswer);

                    myJournal.AddEntry(entry);

                    break;

                case "2":
                    myJournal.DisplayAll();

                    break;
                case "3":
                    Console.Write("Enter a file name (txt) to load the content: ");

                    string filenameLoad = Console.ReadLine();

                    myJournal.LoadFromFile(filenameLoad);

                    break;
                case "4":
                    Console.Write("Choose a file name (txt) to save this content: ");
                    string filenameSave = Console.ReadLine();

                    myJournal.SaveToFile(filenameSave);
                    break;
                case "5":
                    Console.WriteLine("The program finished");
                    break;
                default:
                    Console.WriteLine("you typed an incorrect option, try again");
                    break;
            }
        }

    }
}