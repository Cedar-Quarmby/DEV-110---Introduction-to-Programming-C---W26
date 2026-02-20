/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Programmer: Cedar Quarmby
- Assignment: Week 6: Text Menu App
-
- What does this program do?:
- Runs a text-heavy menu app that demonstrates string formatting and output patterns.
- */

using System.Reflection;

namespace TextMenuApp;

public class Program
{
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
    private static double ReadDouble(string prompt)
    {
        double value = 0;
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
            isValid = double.TryParse(rawValue, out value);
        } while (!isValid);
        return value;
    }

    public static void Main(string[] args)
    {
        string title = "Text Menu Studio";
        string subtitle = "Strings + Console Output Patterns";
        string divider = new string('=', 48);
        Console.WriteLine(divider);
        Console.WriteLine(title.ToUpper());
        Console.WriteLine(subtitle);
        Console.WriteLine(divider);

        int choice = 0;
        int boxSpaces = 40;

        while (choice != 6)
        {
            Console.WriteLine("Please enter the number related to the desired option.");
            Console.WriteLine("- 1) Greeting Card\n- 2) Name Tag Formatter\n- 3) Phrase Analyzer\n- 4) Fancy Receipt Line\n- 5) Menu Banner Builder\n- 6) Exit");

            choice = ReadIntInRange(null, 1, 6);

            switch (choice)
            {
                case 1:
                    Console.WriteLine($"\n{divider}\nOPTION 1: Greeting Card\n");
                    Console.WriteLine("Enter your name: ");
                    string name = Console.ReadLine().Trim();
                    string nameUpper = name.ToUpper();
                    Console.WriteLine("Enter a short message: ");
                    string message = Console.ReadLine();
                    int nameLength = name.Length;
                    int messageLength = message.Length;
                    if (nameLength > 40 && 40 > messageLength)
                    {
                        boxSpaces = nameLength += 40;
                    }
                    else if (messageLength > 40 && 40 > nameLength)
                    {
                        boxSpaces = messageLength += 40;
                    }
                    Console.WriteLine(new string('-', boxSpaces + 2));
                    Console.WriteLine(string.Format("| Name: {0}", name).PadRight(boxSpaces) + " |");
                    Console.WriteLine(string.Format("| Uppercase name: {0}", nameUpper).PadRight(boxSpaces) + " |");
                    Console.WriteLine(string.Format("| Message: {0}", message).PadRight(boxSpaces) + " |");
                    Console.WriteLine(new string('-', boxSpaces + 2));
                    break;

                case 2:
                    Console.WriteLine($"\n{divider}\nOPTION 2: Name Tag Formatter\n");
                    Console.WriteLine("Enter your first name: ");
                    string firstName = Console.ReadLine().Trim();
                    Console.WriteLine("Enter your last name: ");
                    string lastName = Console.ReadLine().Trim();
                    string fullName = firstName + " " + lastName;
                    string initials = firstName[0].ToString() + lastName[0].ToString();
                    int fullNameLength = fullName.Length;
                    if (fullNameLength > 40)
                    {
                        boxSpaces = fullNameLength += 40;
                    }
                    Console.WriteLine(new string('-', boxSpaces + 2));
                    Console.WriteLine(string.Format("| Full name: {0}", fullName).PadRight(boxSpaces) + " |");
                    Console.WriteLine(string.Format("| Initials: {0}", initials).PadRight(boxSpaces) + " |");
                    Console.WriteLine(string.Format("| Uppercase initials: {0}", initials.ToUpper()).PadRight(boxSpaces) + " |");
                    Console.WriteLine(new string('-', boxSpaces + 2));
                    break;

                case 3:
                    Console.WriteLine($"\n{divider}\nOPTION 3: Phrase Analyzer\n");
                    Console.WriteLine("Enter a phrase: ");
                    string phrase = Console.ReadLine().Trim();
                    int phraseLength = phrase.Length;
                    bool phraseHasA = phrase.ToLower().Contains("a");
                    string phraseDashed = phrase.Replace(" ", "-");
                    string phraseWords = string.Join(", ", phrase.Split());
                    int phraseWordsLength = phraseWords.Length;
                    if (phraseWordsLength > 40)
                    {
                        boxSpaces = phraseWordsLength += 40;
                    }
                    Console.WriteLine(new string('-', boxSpaces + 2));
                    Console.WriteLine(string.Format("| Phrase length: {0}", phraseLength).PadRight(boxSpaces) + " |");
                    Console.WriteLine(string.Format("| Phrase contains A: {0}", phraseHasA).PadRight(boxSpaces) + " |");
                    Console.WriteLine(string.Format("| Phrase with dashes: {0}", phraseDashed).PadRight(boxSpaces) + " |");
                    Console.WriteLine(string.Format("| Phrase words list: {0}", phraseWords).PadRight(boxSpaces) + " |");
                    Console.WriteLine(new string('-', boxSpaces + 2));
                    break;

                case 4:
                    Console.WriteLine($"\n{divider}\nOPTION 4: Fancy Receipt Line\n");
                    Console.WriteLine("Enter item name: ");
                    string itemName = Console.ReadLine().Trim();
                    Console.WriteLine("Enter item price: ");
                    double itemPrice = ReadDouble(Console.ReadLine());
                    Console.WriteLine("Enter item quantity: ");
                    double itemQuantity = ReadDouble(Console.ReadLine());
                    double totalPrice = itemPrice * itemQuantity;
                    Console.WriteLine(new string('-', boxSpaces + 2));
                    Console.WriteLine(string.Format("| {0,-20} {1,4} {2,9:C2} |", itemName, itemQuantity, totalPrice));
                    Console.WriteLine(new string('-', boxSpaces + 2));
                    break;

                case 5:
                    Console.WriteLine($"\n{divider}\nOPTION 5: Menu Banner Builder\n");
                    Console.WriteLine("Enter a title: ");
                    string titleInput = Console.ReadLine();
                    Console.WriteLine("Enter a subtitle: ");
                    string subtitleInput = Console.ReadLine();
                    int width = ReadIntInRange("Enter width (30-60): ", 30, 60);
                    string border = new string('=', width);
                    string titleInputUpper = titleInput.ToUpper();
                    string centeredTitle = title.PadLeft((width + title.Length) / 2);
                    string centeredSubtitle = subtitleInput.PadLeft((width + subtitleInput.Length) / 2);
                    Console.WriteLine("\nAlignment Examples:\n");
                    Console.WriteLine("Centered:");
                    Console.WriteLine(centeredTitle);
                    Console.WriteLine("\nLeft:");
                    Console.WriteLine(title);
                    Console.WriteLine("\nRight:");
                    Console.WriteLine(title.PadLeft(width));
                    break;

                case 6:
                    Console.WriteLine($"\n{divider}\nOPTION 6: Exit with String Analysis\n");
                    Console.WriteLine("Enter a closing word: ");
                    string closingWord = Console.ReadLine();
                    bool isGoodbye = closingWord.Equals("goodbye", StringComparison.OrdinalIgnoreCase);
                    Console.WriteLine($"Equals 'goodbye' (ignore case): {isGoodbye}");
                    string firstThree = closingWord.Length >= 3 ? closingWord.Substring(0, 3) : "(too short)";
                    Console.WriteLine($"First 3 characters: {firstThree}");
                    bool endsWithBang = closingWord.EndsWith("!");
                    Console.WriteLine($"Ends with '!': {endsWithBang}");
                    int spaceIndex = closingWord.IndexOf(' ');
                    Console.WriteLine($"Index of first space: {spaceIndex}");

                    Console.WriteLine("Goodbye.");
                    break;
            }
            Console.WriteLine();
        }
    }
}
