/*******************************************************************************
 * Course: DEV 110
 * Instructor: Zak Brinlee
 * Term: Winter 2026
 *
 * Programmer: Cedar Quarmby
 * Assignment: Week 10: Habit Tracker (File I/O)
 *
 * What does this program do?:
 * A menu-driven Habit Tracker that loads habits from a CSV file and lets you
 * view, add, update, and save your habits back to disk.
 * ******************************************************************************/

using System.Globalization;
using System.Linq;
using System.Net;
using System.Xml.Linq;

namespace HabitTracker;

public class Program
{
    public static void Main(string[] args)
    {
        // --- Main Menu --- //
        Console.WriteLine("=== Habit Tracker: File I/O ===");
        Console.WriteLine();

        // - Prompt for the path to the habits CSV file
        Console.Write("Enter habits file path: ");
        string path = (Console.ReadLine() ?? string.Empty).Trim();
        Console.WriteLine();

        // - See line 86 for LoadHabits()
        List<Habit> habits = LoadHabits(path);

        Console.WriteLine();

        // - Menu loop, keeps running until the user chooses 'Save & Quit'
        bool running = true;
        while (running)
        {
            Console.WriteLine("--- Menu ---");
            Console.WriteLine("1. View Habits");
            Console.WriteLine("2. View Summary");
            Console.WriteLine("3. Add Habit");
            Console.WriteLine("4. Update Habit");
            Console.WriteLine("5. Save & Quit");

            // - See line 220 for ReadIntInRange()
            int choice = ReadIntInRange("Choice (1-5): ", 1, 5);
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    // - See line 119 for PrintHabits()
                    PrintHabits(habits);
                    break;
                case 2:
                    // - See line 130 for PrintSummary()
                    PrintSummary(habits);
                    break;
                case 3:
                    // - See line 147 for AddHabit()
                    AddHabit(habits);
                    break;
                case 4:
                    // - See line 173 for UpdateHabit()
                    UpdateHabit(habits);
                    break;
                case 5:
                    // - See line 211 for SaveHabits()
                    SaveHabits(path, habits);
                    running = false;
                    break;
            }

            Console.WriteLine();
        }

        Console.WriteLine("Goodbye!");
    }

    private static List<Habit> LoadHabits(string path)
    {
        // -- Reads a CSV file where each line is: Name,Status,Frequency

        List<Habit> habits = new List<Habit>();
        try
        {
            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                if (!string.IsNullOrWhiteSpace(line))
                {
                    string[] parts = line.Split(",");
                    string name = parts[0].Trim();
                    string status = parts[1].Trim();
                    string frequency = parts[2].Trim();
                    bool isCompleted = status.ToLower() == "done";

                    var habit = new Habit(name, isCompleted, frequency);
                    habits.Add(habit);
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"Error: File not found — {path}");
        }

        return habits;
    }

    private static void PrintHabits(List<Habit> habits)
    {
        // -- Prints all habit names, completion, and frequency

        Console.WriteLine("--- Your Habits ---");
        foreach (var habit in habits)
        {
            habit.DisplayInfo();
        }
    }

    private static void PrintSummary(List<Habit> habits)
    {
        // -- Prints LINQ-based summary stats grouped by frequency

        Console.WriteLine("--- Summary ---");
        int dailyCount = habits.Count(h => h.Frequency == "daily");
        int dailyCompletedCount = habits.Count(h => h.Frequency == "daily" && h.IsCompleted);
        double dailyCompletedPercent = (double)dailyCompletedCount / dailyCount * 100;

        int weeklyCount = habits.Count(h => h.Frequency == "weekly");
        int weeklyCompletedCount = habits.Count(h => h.Frequency == "weekly" && h.IsCompleted);
        double weeklyCompletedPercent = (double)weeklyCompletedCount / weeklyCount * 100;

        Console.WriteLine($"Daily:   {dailyCompletedCount}/{dailyCount} completed ({dailyCompletedPercent:F1}%)");
        Console.WriteLine($"Weekly:  {weeklyCompletedCount}/{weeklyCount} completed ({weeklyCompletedPercent:F1}%)");
    }

    private static void AddHabit(List<Habit> habits)
    {
        // -- Prompts the user for a name and frequency, then adds a new habit to the list

        Console.WriteLine("--- Add Habit ---");
        Console.WriteLine("Habit name: ");
        string habitName = Console.ReadLine().Trim();

        Console.WriteLine("Frequency ((D)aily or (W)eekly): ");
        string habitFrequencyRaw = Console.ReadLine().Trim().ToUpper();
        string habitFrequency;

        if (habitFrequencyRaw == "D")
        {
            habitFrequency = "daily";
        }
        else
        {
            habitFrequency = "weekly";
        }

        var newHabit = new Habit(habitName, false, habitFrequency);
        habits.Add(newHabit);
        Console.WriteLine($"Added: {habitName} ({habitFrequency})");
    }

    private static void UpdateHabit(List<Habit> habits)
    {
        // -- Shows a numbered list of habits, lets the user pick one, optionally rename it, and toggles its completion status.

        if (habits.Count == 0)
        {
            Console.WriteLine("No habits to update.");
            return;
        }
        else
        {
            Console.WriteLine("--- Update Habit ---");
            int habitsNumber = 1;

            foreach (var habit in habits)
            {
                Console.WriteLine($"{habitsNumber}. {habit.Name}");
                habitsNumber += 1;
            }

            // - See line 219 for ReadIntInRange()
            int habitIndex = ReadIntInRange("Enter a habit number: ", 1, habits.Count);
            var chosenHabit = habits[habitIndex - 1];

            Console.WriteLine($"New habit name (press [ENTER] to keep '{chosenHabit.Name}'):");
            string newHabitName = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(newHabitName))
            {
                chosenHabit.Name = newHabitName;
            }

            string completed = chosenHabit.IsCompleted ? "completed" : "pending";
            chosenHabit.IsCompleted = !chosenHabit.IsCompleted;
            Console.WriteLine($"Updated: {chosenHabit.Name} — now {completed}");
        }
    }

    private static void SaveHabits(string path, List<Habit> habits)
    {
        // -- Writes the habit list back to the CSV file

        string[] csvLines = habits.Select(h => $"{h.Name},{(h.IsCompleted ? "done" : "pending")},{h.Frequency}").ToArray();
        File.WriteAllLines(path, csvLines);
        Console.WriteLine($"Habits saved to {path}.");
    }

    private static int ReadIntInRange(string prompt, int min, int max)
    {
        // -- Reads integer input, repeating until a valid value is entered
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
}

