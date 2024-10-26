using System;

class ReflectionActivity : Activity
{
    private static readonly string[] Prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private static readonly string[] Questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience?",
        "What did you learn about yourself?",
        "How can you keep this experience in mind in the future?"
    };

    // Run  activity
    protected override void RunActivity()
    {
        Random random = new Random(); // Create random number generator
        Console.WriteLine(Prompts[random.Next(Prompts.Length)]); // Show random prompt
        ShowSpinner(3); // Pause for 3 seconds

        int timeElapsed = 0; // Track time elapsed

        // Continue until the specified duration is reached
        while (timeElapsed < GetDuration())
        {
            Console.WriteLine(Questions[random.Next(Questions.Length)]); // Show random question
            ShowSpinner(3); // Pause for 3 seconds
            timeElapsed += 3; // Increment time elapsed
        }
    }

    // Provide a description of the activity
    protected override string GetDescription()
    {
        return "This activity helps you reflect on times of strength and resilience.";
    }
    
}
