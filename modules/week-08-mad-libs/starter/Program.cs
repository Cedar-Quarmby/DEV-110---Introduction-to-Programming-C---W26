/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Programmer: Cedar Quarmby
- Assignment: Week 8: Mad Libs (Structure + Debugging)
-
- What does this program do?:
- Runs a two-template Mad Libs app that practices structure and debugging.
- */

using System.Reflection;
using System.Xml.Serialization;

namespace MadLibs;

public class Program
{
    public static void Main(string[] args)
    {
        // ---- Intro ---- //
        Console.WriteLine("=== Mad Libs: Structure + Debugging ===");
        Console.WriteLine();

        // ---- Main loop ---- //
        bool playAgain;
        do
        {
            // - See line 50
            StoryTemplate template = ChooseTemplate();
            Console.WriteLine();

            // - See line 90
            string[] words = CollectWords(template);

            // - See StoryTemplate.cs, line 32
            string story = template.GenerateStory(words);
            Console.WriteLine(story);
            Console.WriteLine();

            // - See line 106
            playAgain = ReadYesNo("Play again? (y/n): ");
            Console.WriteLine();
        } while (playAgain);
    }

    private static StoryTemplate ChooseTemplate()
    {
        Console.WriteLine("1) Debugging at the Zoo");
        Console.WriteLine("2) The Standup Meeting");
        int choice = ReadIntInRange("Please enter 1 or 2: ", 1, 2);

        // -- Put the questions related to the selected prompt in an array -- //
        StoryTemplate template = choice == 1 ?
            new StoryTemplate(
                "Debugging at the Zoo",
                new string[]
                {
                    "Enter an adjective (description word): ",
                    "Enter the plural form of an animal: ",
                    "Enter a verb (action word) ending in -ing: ",
                    "Enter a programming language: ",
                    "Enter a debugging tool (ex: breakpoint): ",
                    "Enter a number: ",
                    "Enter an emotion: ",
                    "Enter an exclamation (ex: wow): "
                },
                "Today I visited the {0} zoo. I saw {1} {2} while writing {3}. I used a {4} {5} times until the bug disappeared. I felt {6} and yelled, \"{7}!\""
            ) :
            new StoryTemplate(
                "The Standup Meeting",
                new string[] {
                    "Enter a name:",
                    "Enter an adjective (description word):",
                    "Enter a noun (person, place, or thing):",
                    "Enter a verb (action word, past tense):",
                    "Enter a number:",
                    "Enter a plural noun:",
                    "Enter a type of bug (programming bug, ex: syntax error):",
                    "Enter a snack:",
                },
                "During standup, {0} gave a {1} update about the {2}. They {3} for {4} hours fixing {5}, but were blocked by a {6}. Afterward, everyone celebrated with {7}."
            );
        return template;
    }

    private static string[] CollectWords(StoryTemplate template)
    {
        Logger.Info("Word collection starting");
        // - Makes the array holding the input words the length of the prompts array (always 8)
        string[] words = new string[template.Prompts.Length];
        for (int i = 0; template.Prompts.Length > i; i += 1)
        {
            string prompt = template.Prompts[i];
            // - See line 161
            string word = ReadNonEmptyString(prompt);
            words[i] = word;
        }
        Console.WriteLine();
        return words;
    }

    private static bool ReadYesNo(string prompt)
    {
        // - Validates y/n input
        bool value = false;
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
            string rawValue = Console.ReadLine().ToLower();
            if (rawValue == "y" || rawValue == "yes")
            {
                isValid = true;
                value = true;
            }
            else if (rawValue == "n" || rawValue == "no")
            {
                isValid = true;
                value = false;
            }
        } while (!isValid);
        return value;
    }

    private static int ReadIntInRange(string prompt, int min, int max)
    {
        // - Validates int input
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

    private static string ReadNonEmptyString(string prompt)
    {
        // - Validates string input
        string value = "";
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
                Console.WriteLine("Empty input. Please try again. ");
            }
            value = Console.ReadLine();
            isValid = !string.IsNullOrWhiteSpace(value);
        } while (!isValid);
        return value;
    }
}
