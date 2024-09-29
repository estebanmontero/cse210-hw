using System;

class Program
{
    static void Main(string[] args)
    {
        /*
            Grading scheme:
            A >= 90, B >= 80, C >= 70, D >= 60, F < 60
            The '+' is added if the last digit of the grade is >= 7, otherwise '-'.
            There's no 'A+' grade, only 'A'.
        */

        // Prompt the user to enter their grade
        Console.Write("Enter your grade (omit the '%' sign): ");
        string inputGrade = Console.ReadLine(); // Read the user's input

        // Try converting the user's input to an integer
        if (int.TryParse(inputGrade, out int studentGrade))
        {
            string letterGrade; // Variable to hold the final letter grade
            char plusOrMinus = studentGrade % 10 >= 7 ? '+' : '-'; // Determine if '+' or '-' should be added

            // Determine the letter grade based on the numeric grade
            if (studentGrade >= 90)
            {
                letterGrade = "A"; // No need to add '+' or '-' for 'A'
            }
            else if (studentGrade >= 80)
            {
                letterGrade = $"B{plusOrMinus}"; // Assign 'B' with '+' or '-'
            }
            else if (studentGrade >= 70)
            {
                letterGrade = $"C{plusOrMinus}"; // Assign 'C' with '+' or '-'
            }
            else if (studentGrade >= 60)
            {
                letterGrade = $"D{plusOrMinus}"; // Assign 'D' with '+' or '-'
            }
            else
            {
                letterGrade = "F"; // If the grade is below 60, assign 'F' without '+/-'
            }

            // Display the final letter grade and an appropriate message
            if (letterGrade == "F" || letterGrade.StartsWith("D"))
            {
                Console.WriteLine($"You got a {letterGrade}. Study more for the next time!");
            }
            else
            {
                Console.WriteLine($"You got a {letterGrade}. Congratulations , you passed!");
            }
        }
        else
        {
            // Notify the user if they entered something that's not a valid number
            Console.WriteLine("Please enter a valid number, not a word.");
        }
    }
}

