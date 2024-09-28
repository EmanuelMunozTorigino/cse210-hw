using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }

    public void SaveToFile(string filename)
    {

        Console.WriteLine($"Saving to '{filename}' file..");

        using (StreamWriter outputFile = new StreamWriter(filename))


            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date} ~|~ {entry._promptText} ~|~ {entry._entryText}");


            }

    }

    public void LoadFromFile(string filename)
    {
        Console.WriteLine("File succesfully loaded..");

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~|~");

            string _date = parts[0];
            string _promptText = parts[1];
            string _entryText = parts[2];
            Entry entry = new Entry(_date, _promptText, _entryText);

            _entries.Add(entry);
        }


    }

}