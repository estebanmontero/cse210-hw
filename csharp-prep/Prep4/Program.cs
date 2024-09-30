using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userInput = -1;

        while (userInput != 0)
        {
            Console.Write("Enter a number (or 0 to stop): ");
            string input = Console.ReadLine();
            
            // Use TryParse for safer input conversion
            if (int.TryParse(input, out userInput))
            {
                if (userInput != 0)
                {
                    numbers.Add(userInput);
                }
            }
            else
            {
                // If input is invalid, prompt the user again
                Console.WriteLine("Please enter a valid number.");
            }
        }

        if (numbers.Count > 0) // Only calculate if there are numbers
        {
            int totalSum = 0;
            foreach (int number in numbers)
            {
                totalSum += number;
            }
            Console.WriteLine($"The sum is: {totalSum}");
            float average = ((float)totalSum) / numbers.Count;
            Console.WriteLine($"The average is: {average}");

            int highest = int.MinValue;
            int lowest = int.MaxValue;
            foreach (int number in numbers)
            {
                if (number > highest) highest = number;
                if (number < lowest) lowest = number;
            }
            Console.WriteLine($"The highest number is: {highest}");
            Console.WriteLine($"The lowest number is: {lowest}");
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}
