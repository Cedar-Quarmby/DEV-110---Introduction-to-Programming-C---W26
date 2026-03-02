using System.Security.Cryptography;
using System.Threading.Tasks.Dataflow;

namespace GuessTheNumber;

public class Program
{
    // ---- INPUT VALIDATION ---- //
    private static int ReadIntInRange(string prompt, int min, int max)
    {
        int value = 0;
        bool isValid = false;
        Console.WriteLine(prompt);
        bool first = true;
        do
        {
            if (first)
            {
                first = false;
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again. ");
            }
            string rawValue = Console.ReadLine();
            isValid = int.TryParse(rawValue, out value);
        } while (!isValid || value < min || value > max);
        return value;
    }

    public static void Main(string[] args)
    {
        // ---- INTRO ---- //
        Console.WriteLine("=== Guess the Number: Loop Trio ===\n");

        int maxValue = ReadIntInRange("Please enter a maximum value (10-100): ", 10, 100);
        int rounds = ReadIntInRange("How many rounds? (1-3): ", 1, 3);

        // ---- RUN GAME ---- //
        for (int round = 1; round <= rounds; round++)
        {
            Console.WriteLine($"\nRound {round} of {rounds}");

            // -- Generate random number -- //
            Random randomNum = new Random(maxValue + round);
            int secretNum = randomNum.Next(1, maxValue + 1);

            int guess = 0;
            int guessCount = 0;

            // -- Guessing number -- //
            while (guess != secretNum)
            {
                Console.WriteLine($"Guess a number (1-{maxValue}): ");
                if (!int.TryParse(Console.ReadLine(), out guess))
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }

                guessCount += 1;
                if (guess > secretNum)
                {
                    Console.WriteLine("Too high, try again");
                }
                else if (secretNum > guess)
                {
                    Console.WriteLine("Too low, try again");
                }
                else
                {
                    Console.WriteLine($"Correct. You got it in {guessCount} guesses");
                }
            }
        }
        Console.WriteLine("All rounds completed. Restart program to play again.");
    }
}
