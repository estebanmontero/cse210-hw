using System;
using System.Collections.Generic;

class ListingActivity : Activity
{
    private static readonly string[] Prompts = {
        "Who are people that you appreciate?",
        "What are your personal strengths?",
        "Who have you helped this week?",
        "Who are some of your personal heroes?"
    };

    // Run activity
    protected override void RunActivity()
    {
        Random random = new Random(); 
        Console.WriteLine(Prompts[random.Next(Prompts.Length)]); 
        ShowSpinner(3); // Pause for 3 seconds

        int count = 0; 
        int timeElapsed = 0; 
        Console.WriteLine("Start listing items (Press Enter after each item):");

        
        while (timeElapsed < GetDuration())
        {
            Console.ReadLine(); // Wait for user to press Enter
            count++; // Increment count
            timeElapsed += 2; // Assume each item takes 2 seconds to list
            ShowSpinner(2); // Pause for 2 seconds
        }
        Console.WriteLine($"\nYou listed {count} items."); // Display total items listed
    }

    // Provide a description of the activity
    protected override string GetDescription()
    {
        return "This activity helps you reflect on the good things in your life by listing them.";
    }
}

