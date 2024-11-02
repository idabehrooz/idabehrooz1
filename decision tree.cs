using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Decision Tree!");
        Console.WriteLine("Please answer the following questions with 'yes' or 'no'.");

        // First question
        string answer1 = AskQuestion("Do you like outdoor activities?");
        
        // Second question
        string answer2 = AskQuestion("Do you enjoy cooking?");
        
        // Third question
        string answer3 = AskQuestion("Do you prefer reading books over watching movies?");

        // Decision making based on the answers
        if (answer1.Equals("yes", StringComparison.OrdinalIgnoreCase) && answer2.Equals("yes", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("You should try cooking outdoors, like a barbecue!");
        }
        else if (answer1.Equals("yes", StringComparison.OrdinalIgnoreCase) && answer3.Equals("yes", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("You should read a book while enjoying the outdoors!");
        }
        else if (answer2.Equals("yes", StringComparison.OrdinalIgnoreCase) && answer3.Equals("yes", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("You should join a cooking class that includes a book club!");
        }
        else if (answer1.Equals("no", StringComparison.OrdinalIgnoreCase) && answer2.Equals("no", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("You might enjoy watching movies or series at home!");
        }
        else
        {
            Console.WriteLine("You have diverse interests! Explore different activities!");
        }

        Console.WriteLine("Thank you for participating!");
    }

    static string AskQuestion(string question)
    {
        Console.WriteLine(question);
        string answer = Console.ReadLine();
        while (answer.Equals("yes", StringComparison.OrdinalIgnoreCase) == false && 
               answer.Equals("no", StringComparison.OrdinalIgnoreCase) == false)
        {
            Console.WriteLine("Please answer with 'yes' or 'no'.");
            answer = Console.ReadLine();
        }
        return answer;
    }
}