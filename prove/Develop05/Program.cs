using System;

class Program
{
    static void Main()
    {
        while (true) //  loop  menu
        {
            Console.Clear(); 
            Console.WriteLine("Welcome to the Wellness Activity Program!");
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice (1-4): ");
            string choice = Console.ReadLine(); // Get user choice

            if (choice == "4") break; // Exit the loop if user chooses to exit

            Console.Write("Enter the duration for this activity in seconds: ");
            if (int.TryParse(Console.ReadLine(), out int duration)) // Try to parse input
            {
                Console.Clear(); 
                Activity activity = choice switch // Input
                {
                    "1" => new BreathingActivity(),
                    "2" => new ReflectionActivity(),
                    "3" => new ListingActivity(),
                    _ => null
                };

                if (activity != null) // Activity was selected
                {
                    activity.Start(duration); // Start the activity
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid duration.");
            }
        }
    }
}


