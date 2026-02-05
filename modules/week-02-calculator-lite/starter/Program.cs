using System.Diagnostics.CodeAnalysis;

namespace CalculatorLite;

public class Program
{
    public static void Main(string[] args)
    {
        // ---- VARIABLES ---- ///
        int totalCalcs = 0;
        double num1;
        double num2;
        string userName;

        // ---- INTRO ---- ///
        Console.WriteLine("=== Calculator Lite ===\n");

        Console.WriteLine("Enter your name: ");
        userName = Console.ReadLine();
        Console.WriteLine($"Hello, {userName}.");

        Console.WriteLine("Use decimal precision? (y/n) ");
        string decPresChoice = Console.ReadLine();
        bool decPres = decPresChoice == "yes" || decPresChoice == "y";

        // -- Number inputs -- //
        Console.WriteLine("What is the first number? ");
        num1 = decPres ? double.Parse(Console.ReadLine()) : int.Parse(Console.ReadLine());

        Console.WriteLine("What is the second number? ");
        num2 = decPres ? double.Parse(Console.ReadLine()) : int.Parse(Console.ReadLine());

        // ---- MATH ---- ///

        // -- Calculate -- //
        double sum = num1 + num2;
        double diff = num1 - num2;
        double prod = num1 * num2;
        double avg = (num1 + num2) / 2;
        double percentDiff = (num1 - num2) / num1 * 100;

        double quotient = 0;
        double remainder = 0;

        totalCalcs += 5;

        // Check num2 is 0 before divide
        if (num2 == 0)
        {
            Console.WriteLine("Cannot divide, num2 is zero.");
        }
        else
        {
            quotient = num1 / num2;
            remainder = num1 % num2;
            totalCalcs += 2;
        }

        // -- Display -- //
        if (decPres)
        {
            Console.WriteLine($"Addition: {sum:F2}");
            Console.WriteLine($"Subtraction: {diff:F2}");
            Console.WriteLine($"Multiplication: {prod:F2}");
            if (num2 != 0)
            {
                Console.WriteLine($"Division: {quotient:F2}");
                Console.WriteLine($"Remainder: {remainder:F2}");
            }

            Console.WriteLine($"Average: {avg:F2}");
            Console.WriteLine($"Percentage difference: {percentDiff:F2}%");
        }
        else
        {
            Console.WriteLine($"Addition: {sum:F0}");
            Console.WriteLine($"Subtraction: {diff:F0}");
            Console.WriteLine($"Multiplication: {prod:F0}");
            if (num2 != 0)
            {
                Console.WriteLine($"Division: {quotient:F0}");
                Console.WriteLine($"Remainder: {remainder:F0}");
            }

            Console.WriteLine($"Average: {avg:F0}");
            Console.WriteLine($"Percentage difference: {percentDiff:F0}%");
        }

        Console.WriteLine($"\n Performed {totalCalcs} calculations for {userName}.");
        Console.WriteLine("\nThank you for using Calculator Lite.");
    }
}
