using System;

class Program
{
    static void Main()
    {
        int m = GetValidInteger("Enter the value of m: ");
        int n = GetValidInteger("Enter the value of n: ");

        // Validate that m is less than or equal to n
        if (m > n)
        {
            Console.WriteLine("Error: m should be less than or equal to n.");
            return;
        }

        Console.WriteLine($"Prime numbers between {m} and {n}:");
        for (int i = m; i <= n; i++)
        {
            if (IsPrime(i))
            {
                Console.WriteLine(i);
            }
        }
    }

    // Function to get a valid integer input from the user
    static int GetValidInteger(string prompt)
    {
        int result;
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();

            // Check if input is a valid integer
            if (int.TryParse(input, out result))
            {
                return result;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
    }

    // Function to check if a number is prime
    static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;
        if (number == 2)
            return true; // 2 is a prime number
        if (number % 2 == 0)
            return false; // Exclude even numbers greater than 2

        for (int i = 3; i <= Math.Sqrt(number); i += 2)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }
}