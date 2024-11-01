using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the starting number (m): ");
        int m = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter the ending number (n): ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Mirror (palindrome) numbers between {m} and {n}:");
        for (int i = m; i <= n; i++)
        {
            if (IsMirrorNumber(i))
            {
                Console.WriteLine(i);
            }
        }
    }

    static bool IsMirrorNumber(int number)
    {
        string strNumber = number.ToString();
        char[] charArray = strNumber.ToCharArray();
        Array.Reverse(charArray);
        string reversedNumber = new string(charArray);
        return strNumber == reversedNumber;
    }
}