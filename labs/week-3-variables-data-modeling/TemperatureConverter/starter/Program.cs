using Microsoft.VisualBasic;

namespace TemperatureConverter;

public class Program
{
    public static void Main(string[] args)
    {
        // -- Intro -- //
        Console.WriteLine("=== Temperature Converter ===\n");

        Console.WriteLine("Please enter your name: ");
        string userName = Console.ReadLine();
        Console.WriteLine($"Hello, {userName}! Let's convert some temperatures.\n");

        Console.WriteLine("Show detailed calculations? (y/n): ");
        string detailChoice = Console.ReadLine().ToLower();
        // Check input is valid
        while (detailChoice != "yes" && detailChoice != "y" && detailChoice != "no" && detailChoice != "n")
        {
            Console.WriteLine("Please enter a valid input.");
            Console.WriteLine("Show detailed calculations? (y/n): ");
            detailChoice = Console.ReadLine().ToLower();
        }
        bool showDetails = detailChoice == "yes" || detailChoice == "y";

        Console.WriteLine("Enter a temperature value: ");
        double inputTemp;
        bool isValid = double.TryParse(Console.ReadLine(), out inputTemp);
        while (!isValid)
        {
            Console.WriteLine("Please enter a valid input.");
            Console.WriteLine("Enter a temperature value: ");
            isValid = double.TryParse(Console.ReadLine(), out inputTemp);
        }

        Console.WriteLine("Is this temperature in Fahrenheit or Celcius? (f/c): ");
        string conversionChoice = Console.ReadLine().ToUpper();
        // Check input is valid
        while (conversionChoice != "CELCIUS" && conversionChoice != "C" && conversionChoice != "FAHRENHEIT" && conversionChoice != "F")
        {
            Console.WriteLine("Please enter a valid input.");
            Console.WriteLine("Is this temperature in Fahrenheit or Celcius? (f/c): ");
            conversionChoice = Console.ReadLine().ToUpper();
        }

        int conversionCount = 0;

        Console.WriteLine("\n=== Conversion Results ===\n");

        // -- Celcius to Fahrenheit -- //

        if (conversionChoice == "C" || conversionChoice == "CELCIUS")
        {
            double convertedTemp = (inputTemp * (9.0 / 5.0)) + 32;

            conversionCount++;

            Console.WriteLine($"Temperature in Celsius: {inputTemp:F2}°C");
            Console.WriteLine($"Temperature in Fahrenheit: {convertedTemp:F2}°F");

            if (showDetails)
            {
                Console.WriteLine($"\nFormula used: F = (C × (9 / 5)) + 32");
                Console.WriteLine($"Calculation: ({inputTemp:F2} × (9 / 5)) + 32 = {convertedTemp:F2}");
            }

            Console.WriteLine("\n=== Temparature Analysis ===\n");

            double diffFromFreezing = inputTemp - 0.0;
            double diffFromBoiling = 100.0 - inputTemp;
            Console.WriteLine($"Difference from water freezing point (0°C): {diffFromFreezing:F2}°C");
            Console.WriteLine($"Difference from water boiling point (100°C): {diffFromBoiling:F2}°C");

            if (0.0 > inputTemp)
            {
                Console.WriteLine("Status: Ice (below freezing)");
            }
            else if (100.0 > inputTemp && inputTemp > 0.0)
            {
                Console.WriteLine("Status: Liquid (above freezing and below boiling)");
            }
            else
            {
                Console.WriteLine("Status: Gas (above boiling)");
            }
        }

        // -- Fahrenheit to Celcius -- //

        else if (conversionChoice == "F" || conversionChoice == "FAHRENHEIT")
        {
            double convertedTemp = (inputTemp - 32) * (9.0 / 5.0);

            conversionCount++;

            Console.WriteLine($"Temperature in Celsius: {convertedTemp:F2}°C");
            Console.WriteLine($"Temperature in Fahrenheit: {inputTemp:F2}°F");

            if (showDetails)
            {
                Console.WriteLine($"\nFormula used: C = (F - 32) × (5 / 9)");
                Console.WriteLine($"Calculation: ({inputTemp:F2} - 32) * (9 / 5) = {convertedTemp:F2}");
            }

            Console.WriteLine("\n=== Temparature Analysis ===\n");

            double diffFromFreezing = inputTemp - 32.0;
            double diffFromBoiling = 212.0 - inputTemp;
            Console.WriteLine($"Difference from water freezing point (32°F): {diffFromFreezing:F2}°F");
            Console.WriteLine($"Difference from water boiling point (212°F): {diffFromBoiling:F2}°F");

            if (32.0 > inputTemp)
            {
                Console.WriteLine("Status: Ice (below freezing)");
            }
            else if (212.0 > inputTemp && inputTemp > 32.0)
            {
                Console.WriteLine("Status: Liquid (above freezing and below boiling)");
            }
            else
            {
                Console.WriteLine("Status: Gas (above boiling)");
            }
        }

        if (conversionCount > 0)
        {
            Console.WriteLine($"Performed {conversionCount} temperature conversion(s) for {userName}.");
        }

        Console.WriteLine("Thank you for using Temperature Converter.");
    }
}
