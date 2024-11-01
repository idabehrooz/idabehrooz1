using System;

class Program
{
    static void Main()
    {
        int number = 0; // Initialize the variable
        bool isValidInput = false;

        while (!isValidInput)
        {
            Console.Write("Please enter a number: ");
            string input = Console.ReadLine();

            // Try to parse the input to an integer
            isValidInput = int.TryParse(input, out number);

            if (!isValidInput)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        // At this point, we know 'number' has a valid value
        Console.WriteLine($"You entered the number: {number}");
    }
}