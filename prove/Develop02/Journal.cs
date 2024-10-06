using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    // List to store journal entries
    private List<Entry> _entries = new List<Entry>();

    // Method to add a new entry
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
        Console.WriteLine("Your entry has been added to your Journal.");
    }

    // Method to display all entries
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display(); // Call the Display method of each Entry
        }
        Console.WriteLine("\nIncrease your console size to get the best view.");
    }

    // Method to save entries to a file
    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file, true)) // Append mode
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry.Date},{entry.Time},{entry.PromptText},{entry.EntryText}"); 
            }
        }
        Console.WriteLine("Your entries have been saved.");
    }

    // Method to load entries from a file
    public void LoadFromFile(string file)
    {
        if (File.Exists(file))
        {
            string[] lines = File.ReadAllLines(file); // Read all lines from the file
            foreach (string line in lines)
            {
                string[] parts = line.Split(','); // Split the line into parts

                if (parts.Length == 4) 
                {
                    Entry entry = new Entry();
                    entry.Date = parts[0]; 
                    entry.Time = parts[1]; 
                    entry.PromptText = parts[2]; 
                    entry.EntryText = parts[3]; 
                    _entries.Add(entry); 
                }
            }
            Console.WriteLine("Entries have been loaded from the file.");
        }
        else
        {
            Console.WriteLine("File not found."); 
        }
    }
}
