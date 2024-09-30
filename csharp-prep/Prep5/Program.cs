using System;

class Program
{
    static void Main(string[] args)
    {
        // Display a welcome message by calling the function
        DisplayWelcome();

        // Prompt the user for their name and store it in a variable
        string userName = PromptUserName();
        
        // Prompt the user for their favorite number and store it in a variable
        int favoriteNumber = PromptUserNumber();

        // Calculate the square of the user's favorite number and store the result
        int squaredNumber = SquareNumber(favoriteNumber);

        // Display the final result, showing the user's name and the squared number
        DisplayResult(userName, squaredNumber);

        // Function to display a welcome message to the user
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!"); // Simple greeting to the user
        }

        // Function to prompt the user for their name and return it as a string
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine(); // Read the user's input and store it in a variable
            return name; // Return the user's name for later use
        }

        // Function to prompt the user for their favorite number and return it as an integer
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            // Convert the user's input (string) to an integer using int.Parse
            int favoriteNumber = int.Parse(Console.ReadLine());
            return favoriteNumber; // Return the user's favorite number for calculation
        } 

        // Function to calculate the square of a given number and return the result
        static int SquareNumber(int number)
        {
            int square = number * number; // Multiply the number by itself to get the square
            return square; // Return the squared number
        }

        // Function to display the final message with the user's name and the squared number
        static void DisplayResult(string name, int square)
        {
            // Display the user's name and the result of squaring their favorite number
            Console.WriteLine($"{name}, the square of your number is {square}");
        } 
    }
}
