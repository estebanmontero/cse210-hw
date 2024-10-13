using System;

class Program
{
    static void Main(string[] args)
    {

        do
        {
            Console.Clear();
            Console.WriteLine($"Please select your preference from the list of scriptures below:");
            Console.Write("1. 2 Nephi 9:28-29  2. Alma 37:35\nEnter your choice here: ");
            string input = Console.ReadLine();
            int choice;

            try
            {
                choice = int.Parse(input);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue; 
            } 

            if (choice == 1)
            {
                Reference f1 = new Reference("2 Nephi", 9, 28, 29);
                string scriptureText = "O that cunning plan of the evil one! O the vainness, and the frailties, and the foolishness of men! " +
                    "When they are learned they think they are wise, and they hearken not unto the counsel of God, for they set it aside, supposing they know of themselves, " +
                    "wherefore, their wisdom is foolishness and it profiteth them not. And they shall perish.";
                
                Scripture scripture = new Scripture(f1, scriptureText);
                string response;

                // loop
                do
                {
                    Console.Clear();
                    Console.WriteLine(scripture.GetDisplayText());
                    Console.Write("\nPress 'ENTER' to hide words or type 'q' to quit: ");
                    response = Console.ReadLine().ToLower();

                    if (response == "q")
                    {
                        break;
                    }


                    if (scripture.IsCompletelyHidden())
                    {
                        Console.Clear();
                        Console.WriteLine(scripture.GetDisplayText());
                        Console.WriteLine("\nAll words have been hidden.");
                        break;
                    }


                    scripture.HideRandomWords(2);
                    
                } while (true);
            }
            else if (choice == 2)
            {
                Reference f2 = new Reference("Alma", 37, 35);
                string scriptureText = "O, remember, my son, and learn wisdom in thy youth; yea, learn in thy youth to keep the commandments of God.";
                
                Scripture scripture = new Scripture(f2, scriptureText);
                string response;


                do
                {
                    Console.Clear();
                    Console.WriteLine(scripture.GetDisplayText());
                    Console.Write("\nPress 'ENTER' to hide words or type 'q' to quit: ");
                    response = Console.ReadLine().ToLower();

                    if (response == "q")
                    {
                        break;
                    }


                    if (scripture.IsCompletelyHidden())
                    {
                        Console.Clear();
                        Console.WriteLine(scripture.GetDisplayText());
                        Console.WriteLine("\nAll words have been hidden.");
                        break;
                    }

                    scripture.HideRandomWords(2);
                    
                } while (true);
            }
            else
            {
                Console.WriteLine("Please restart and choose one of the options.");
            }


            Console.WriteLine("\nWould you like to start again? (Press 'Y' to restart or any other key to exit)");
            string restart = Console.ReadLine().ToLower();

            if (restart != "y")
            {
                break;
            }

        }
        
             while (true);
    }
}
