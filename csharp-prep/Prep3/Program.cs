using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a random number generator
        Random rand = new Random();
        
        // Generate a random number between 1 and 99 (inclusive)
        int magicNum = rand.Next(1, 100);

        // Variable to store the user's guess, initialized to a value that cannot be the answer
        int userGuess = -1;

        // Loop until the user guesses the correct number
        while (userGuess != magicNum)
        {
            // Ask the user for their guess
            Console.Write("What is your guess? ");
            
            // Read the user's input and convert it to an integer
            string guessInput = Console.ReadLine();
            userGuess = int.Parse(guessInput);

            // Compare the guess with the random number
            if (magicNum > userGuess)
            {
                // Tell the user to guess higher if the random number is greater
                Console.WriteLine("Higher");
            }
            else if (magicNum < userGuess)
            {
                // Tell the user to guess lower if the random number is smaller
                Console.WriteLine("Lower");
            }
            else
            {
                // Inform the user that they guessed correctly
                Console.WriteLine("Congrats. You guessed the number!");
            }
        }
    }
}
