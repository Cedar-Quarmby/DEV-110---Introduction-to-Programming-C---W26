namespace ProfileCard;

public class Program
{
    public static void Main(string[] args)
    {
        // ---- INTRO ---- //

        Console.WriteLine("╔════════════════════════════════════════════╗");
        Console.WriteLine("║            STUDENT PROFILE CARD            ║");
        Console.WriteLine("╚════════════════════════════════════════════╝\n");

        // - Collect Personal Information - //

        Console.WriteLine("Please enter your full name: ");
        string fullName = Console.ReadLine();

        Console.WriteLine("Please enter your hometown (city, state): ");
        string homeTown = Console.ReadLine();

        // - Collect Academic Information - //

        Console.WriteLine("Please enter your major: ");
        string major = Console.ReadLine();

        Console.WriteLine("Please enter your GPA: ");
        double gpa = double.Parse(Console.ReadLine());

        Console.WriteLine("Please enter your graduation year: ");
        int graduationYear = int.Parse(Console.ReadLine());

        Console.WriteLine("Are you a full time student (y/n)? ");
        string isFullTimeString = Console.ReadLine().ToLower();
        bool isFullTime = isFullTimeString == "yes" || isFullTimeString == "y";

        // - Collect Additional Info - //

        Console.WriteLine("Please enter your age: ");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter your height in inches: ");
        double heightInches = double.Parse(Console.ReadLine());

        // ---- CALCULATE EXTRA INFO ---- //

        int birthYear = 2026 - age;
        int yearsUntilGraduation = graduationYear - 2026;

        double heightSoloFeet = Math.Floor(heightInches / 12);
        double heightSoloInches = Math.Floor(heightInches % 12);

        bool isHonorStudent = gpa >= 3.5;
        int ageMonths = age * 12;

        // ---- DISPLAY INFO ---- //

        Console.WriteLine("\n\n═══════════════════════════════════════════");
        Console.WriteLine("PERSONAL INFORMATION\n");
        Console.WriteLine($"Full Name: {fullName}");
        Console.WriteLine($"Hometown: {homeTown}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Height (in inches): {heightInches}");

        Console.WriteLine("\nACADEMIC INFORMATION\n");
        Console.WriteLine($"Major: {major}");
        Console.WriteLine($"GPA: {gpa}");
        Console.WriteLine($"Graduation Year: {graduationYear}");
        Console.WriteLine($"Full time: {isFullTime}");

        Console.WriteLine("\nCALCULATED STATISTICS\n");
        Console.WriteLine($"Birth Year: {birthYear}");
        Console.WriteLine($"Years until Graduation: {yearsUntilGraduation}");
        Console.WriteLine($"Height (in feet and inches): {heightSoloFeet}'{heightSoloInches}\"");
        Console.WriteLine($"Honor Student: {isHonorStudent}");
        Console.WriteLine($"Age in Months: {ageMonths}");

        Console.WriteLine("\n═══════════════════════════════════════════");
        Console.WriteLine("Profile complete! Good luck with your studies!");
    }
}
