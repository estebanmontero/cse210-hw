using System;
using System.Threading;

class BreathingActivity : Activity
{
    // Run  activity
    protected override void RunActivity()
    {
        int timeElapsed = 0; // Track time elapsed

        // Continue until the specified duration is reached
        while (timeElapsed < GetDuration())
        {
            Console.WriteLine("Breathe in..."); // Prompt to breathe in
            ShowSpinner(3); // Pause for 3 seconds
            timeElapsed += 3; // Increment time elapsed

            Console.WriteLine("Breathe out..."); // Prompt to breathe out
            ShowSpinner(3); // Pause for 3 seconds
            timeElapsed += 3; // Increment time elapsed
        }
    }

    // Provide a description of the activity
    protected override string GetDescription()
    {
        return "This activity will help you relax by guiding you through breathing in and out slowly.";
    }
}
