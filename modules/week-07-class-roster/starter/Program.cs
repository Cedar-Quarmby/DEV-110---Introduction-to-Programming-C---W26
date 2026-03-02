/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Programmer: Cedar Quarmby
- Assignment: Week 7: Class Roster Builder (Arrays)
-
- What does this program do?:
- Builds a class roster using parallel arrays and a simple menu.
- */

namespace ClassRoster;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Class Roster ===");
        Console.WriteLine();

        int rosterCapacity = 3;
        string[] rosterNames = new string[rosterCapacity];
        int[] rosterCredits = new int[rosterCapacity];

        int count = 0;
        int choice = 0;

        while (choice != 4)
        {
            Console.WriteLine("1) Add multiple students");
            Console.WriteLine("2) Print class roster");
            Console.WriteLine("3) Print roster (sorted)");
            Console.WriteLine("4) Exit");

            choice = ReadIntInRange("Please choose an option: ", 1, 4);

            switch (choice)
            {
                case 1:
                    if (count == rosterCapacity)
                    {
                        Console.WriteLine("Roster is full. Cannot add more students.");
                    }
                    else
                    {
                        int remainingSlots = rosterCapacity - count;

                        int toAdd = ReadIntInRange($"How many students do you want to add? (1-{remainingSlots}): ", 1, remainingSlots);

                        string[] newNames = new string[toAdd];
                        int[] newCredits = new int[toAdd];

                        for (int i = 0; i < toAdd; i++)
                        {
                            Console.Write($"Enter name for student {i + 1}: ");
                            newNames[i] = Console.ReadLine() ?? "";

                            newCredits[i] = ReadIntInRange($"Enter credits for {newNames[i]} (0-200): ", 0, 200);
                        }

                        for (int i = 0; i < toAdd; i++)
                        {
                            rosterNames[count] = newNames[i];
                            rosterCredits[count] = newCredits[i];
                            count++;
                        }

                        Console.WriteLine("Students added.");
                    }
                    Console.WriteLine();
                    break;

                case 2:
                    if (count == 0)
                    {
                        Console.WriteLine("Roster is empty.");
                    }
                    else
                    {
                        string[] lines = BuildRosterLines(rosterNames, rosterCredits, count);
                        Console.WriteLine("Class Roster:");
                        foreach (string line in lines)
                        {
                            Console.WriteLine(line);
                        }
                    }
                    Console.WriteLine();
                    break;

                case 3:
                    if (count == 0)
                    {
                        Console.WriteLine("Roster is empty.");
                    }
                    else
                    {
                        int sortChoice = ReadIntInRange("Sort by:\n1) Name\n2) Credits\n", 1, 2);
                        CopyUsedRoster(rosterNames, rosterCredits, count, out string[] sortedNames, out int[] sortedCredits);

                        if (sortChoice == 1)
                        {
                            Array.Sort(sortedNames, sortedCredits, StringComparer.OrdinalIgnoreCase);
                        }
                        else
                        {
                            Array.Sort(sortedCredits, sortedNames);
                        }

                        Console.WriteLine("Class Roster (Sorted):");
                        string[] lines = BuildRosterLines(sortedNames, sortedCredits, count);

                        foreach (string line in lines)
                        {
                            Console.WriteLine(line);
                        }
                    }
                    Console.WriteLine();
                    break;

                case 4:
                    Console.WriteLine("Goodbye.");
                    break;
            }
        }

        Console.WriteLine("(Starter project) Follow the TODO steps in Program.cs.");
    }

    private static int ReadIntInRange(string prompt, int min, int max)
    {
        int value;
        bool isValid;

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

            Console.Write(prompt);
            string input = Console.ReadLine() ?? string.Empty;
            isValid = int.TryParse(input, out value);
        }
        while (!isValid || value < min || value > max);

        return value;
    }

    private static string[] BuildRosterLines(string[] names, int[] credits, int count)
    {
        string[] rosterLines = new string[count];

        for (int i = 0; i < count; i++)
        {
            rosterLines[i] = $"{names[i]} - {credits[i]} credits";
        }

        return rosterLines;
    }

    private static void CopyUsedRoster(string[] sourceNames, int[] sourceCredits, int count, out string[] names, out int[] credits)
    {
        names = new string[count];
        credits = new int[count];

        for (int i = 0; i < count; i++)
        {
            names[i] = sourceNames[i];
            credits[i] = sourceCredits[i];
        }
    }
}
