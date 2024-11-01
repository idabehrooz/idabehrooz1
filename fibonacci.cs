using System;

public class Program
{
    // Function to check if a number is a perfect square
    static bool IsPerfectSquare(int x)
    {
        int s = (int)Math.Sqrt(x);
        return (s * s == x);
    }

    // Function to check if a number is a Fibonacci number
    static bool IsFibonacci(int n)
    {
        // A number is Fibonacci if and only if one or both of (5*n*n + 4) or (5*n*n - 4) is a perfect square
        return IsPerfectSquare(5 * n * n + 4) || IsPerfectSquare(5 * n * n - 4);
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (IsFibonacci(n))
        {
            Console.WriteLine($"{n} is a Fibonacci number.");
        }
        else
        {
            Console.WriteLine($"{n} is not a Fibonacci number.");
        }
    }
}