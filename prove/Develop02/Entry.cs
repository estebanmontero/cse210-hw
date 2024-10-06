using System;

public class Entry
{
    // Properties to hold the date, time, prompt text, and entry text of the journal entry
    public string Date { get; set; } 
    public string Time { get; set; } 
    public string PromptText { get; set; } = ""; 
    public string EntryText { get; set; } = "";

    // Method to display the entry details in a formatted manner
    public void Display()
    {
        Console.WriteLine($"\nDATE: {Date}\nTIME: {Time}\nPROMPT: {PromptText}\nENTRY: {EntryText}");
    }
}
