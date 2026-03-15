using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    // This create an empty attributes entries that will hold all the user entries
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    { 
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
       foreach (Entry entry in _entries)
        {
            entry.Display();
        } 
    }
    
    public void saveToFile(string file)
    {
        using (StreamWriter saveFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                saveFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
    }
    // THe method load file from save file 
    public void loadFromFile(string file)
    {
        string[] fileload = System.IO.File.ReadAllLines(file);
        _entries.Clear();

        foreach (string line in fileload)
        {
            string[] parts = line.Split("|");
            Entry entry = new Entry();

            entry._date = parts[0];
            entry._promptText = parts[1];
            entry._entryText = parts[2];
            _entries.Add(entry);
        }
    }
    // This method keep track of the number of journal entries made and display the total
    public void countEntries()
    {
        Console.WriteLine($"You have written {_entries.Count} journal entries.");
    }
    

}