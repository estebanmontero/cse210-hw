using System;

class Program
{
    static void Main(string[] args)
    {
        // Create instances of the necessary classes
        Journal journal = new Journal(); // Journal instance for managing entries
        PromptGenerator promptGenerator = new PromptGenerator(); // PromptGenerator instance for generating prompts
        string choice; // Variable to store user choice

        Console.WriteLine("Welcome to the Journal Program"); 

        // Loop
        {
            
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write an entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Load entries from a file");
            Console.WriteLine("4. Save entries to a file (journalrecord.txt)");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            
        
            choice = Console.ReadLine();

            // If-else statements 
            if (choice == "1") 
            {
                // to get a random prompt 
                string randomPrompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(randomPrompt); // Display the prompt

                Entry newEntry = new Entry(); // to create a new enrty
                Console.Write("> "); 
                newEntry.EntryText = Console.ReadLine(); 
                newEntry.Date = DateTime.Now.ToLongDateString(); 
                newEntry.Time = DateTime.Now.ToLongTimeString(); 
                newEntry.PromptText = randomPrompt; 

                journal.AddEntry(newEntry); 
            }
            else if (choice == "2") // Display all entries
            {
                journal.DisplayAll(); // Call method to display all entries
            }
            else if (choice == "3") 
            {
                Console.Write("Enter the file name (with .txt): "); 
                string fileName = Console.ReadLine(); 
                journal.LoadFromFile(fileName); // 
            }
            else if (choice == "4") 
            {
                journal.SaveToFile("journalrecord.txt"); 
                Console.WriteLine("Entries have been saved to journalrecord.txt."); 
            }
            else if (choice == "5") 
            {
                Console.WriteLine("Goodbye!"); 
            }
            else 
            {
                Console.WriteLine("Invalid choice. Please try again."); 
            }

            Console.WriteLine(); 
        }
        while (choice != "5"); 

    }

}