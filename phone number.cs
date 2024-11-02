using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter a 10-digit number:");

        string input = Console.ReadLine();

        if (IsValidNumber(input))
        {
            Console.WriteLine("The number is valid.");
        }
        else
        {
            Console.WriteLine("The number is not valid.");
        }
    }

    static bool IsValidNumber(string number)
    {
        // Check if the input is exactly 10 characters long and contains only digits
        if (number.Length != 10 || !IsAllDigits(number))
        {
            return false;
        }

        // Check if the first digit is '0'
        if (number[0] != '0')
        {
            return false;
        }

        // Check if there are at least two different digits
        return HasAtLeastTwoDifferentDigits(number);
    }

    static bool IsAllDigits(string number)
    {
        foreach (char c in number)
        {
            if (!char.IsDigit(c))
            {
                return false;
            }
        }
        return true;
    }

    static bool HasAtLeastTwoDifferentDigits(string number)
    {
        HashSet<char> uniqueDigits = new HashSet<char>(number);
        return uniqueDigits.Count > 1; // True if there are at least 2 different digits
    }
}