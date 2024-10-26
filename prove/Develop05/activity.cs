using System;
using System.Threading;

class Activity
{
    private int _duration; // Duration of the activity in seconds

    public void Start(int duration)
    {
        _duration = duration; // Set the duration
        DisplayStartingMessage(); // Show starting message
        ShowCountDown(3); // Show countdown before starting
        RunActivity(); // Run the specific activity
        DisplayEndingMessage(); // Show ending message
    }

    protected virtual void RunActivity() { }

    protected int GetDuration() => _duration;

    protected void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\rStarting in... {i} "); // Display countdown
            Thread.Sleep(1000); // Pause for 1 second
        }
        Console.WriteLine(); // Move to the next line
    }

    protected void ShowSpinner(int seconds)
    {
        string[] spinner = { "/", "-", "\\", "|" }; // Spinner characters
        int counter = 0;
        for (int i = 0; i < seconds * 2; i++)
        {
            Console.Write($"\r{spinner[counter++ % 4]} "); // Rotate spinner
            Thread.Sleep(500); // Pause for 0.5 seconds
        }
        Console.WriteLine(); 
    }

    // Display the starting message for the activity
    protected void DisplayStartingMessage()
    {
        Console.WriteLine($"{GetType().Name} Activity"); 
        Console.WriteLine(GetDescription()); 
        Console.WriteLine("Prepare to begin..."); 
    }

    // Abstract method to get the description of the activity
    protected virtual string GetDescription() => "No description available.";

    // Display the ending message for the activity
    protected void DisplayEndingMessage()
    {
        Console.WriteLine("Great job! You have completed the activity.");
        Console.WriteLine($"You spent {_duration} seconds on it.");
        ShowSpinner(3); 
    }
}

