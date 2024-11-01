using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a character: ");
        char input;

        while (!char.TryParse(Console.ReadLine(), out input))
        {
            Console.WriteLine("Invalid input. Please enter a single character.");
            Console.Write("Enter a character: ");
        }

        Console.WriteLine("You entered: " + input);
    }
}