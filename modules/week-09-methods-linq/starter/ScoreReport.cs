/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Programmer: Cedar Quarmby
- Assignment: Week 9: Score Stats (Methods + LINQ)
-
- What does this program do?:
- Defines a ScoreReport class students complete using LINQ methods.
- */

using System.Globalization;
using System.Linq;

namespace ScoreStats;

internal class ScoreReport
{
    private readonly int[] _scores;

    public ScoreReport(int[] scores, int threshold)
    {
        _scores = scores;
        Threshold = threshold;
    }

    public int Threshold { get; }

    public int Count => _scores.Length;

    public void PrintReport()
    {
        // - See line 56
        PrintBasicStats();

        // - See line 65
        PrintPassingFailingCounts();
        Console.WriteLine();

        // - See line 72
        PrintScoresSorted();

        // - See line 80
        PrintTopScores(3);

        // - See line 88
        PrintPassingScores();

        // - See line 96
        PrintFailingScores();
    }

    private void PrintBasicStats()
    {
        // - Prints total number of scores entered, lowest score, highest score, and average score
        Console.WriteLine($"Count: {_scores.Length}");
        Console.WriteLine($"Min: {_scores.Min()}");
        Console.WriteLine($"Max: {_scores.Max()}");
        Console.WriteLine($"Average {_scores.Average():F1}");
    }

    private void PrintPassingFailingCounts()
    {
        // - Prints total number of scores passing or failing
        Console.WriteLine($"Passing (>={Threshold}): {_scores.Count(score => score >= Threshold)}");
        Console.WriteLine($"Failing (<{Threshold}): {_scores.Count(score => score < Threshold)}");
    }

    private void PrintScoresSorted()
    {
        // - Prints all scores entered in ascending order
        var sorted = _scores.OrderBy(score => score);
        string sortedScores = string.Join(", ", sorted);
        Console.WriteLine($"Sorted (asc): {sortedScores}");
    }

    private void PrintTopScores(int topCount)
    {
        // - Prints top x scores
        var top = _scores.OrderByDescending(score => score).Take(topCount);
        string topScores = string.Join(", ", top);
        Console.WriteLine($"Top {topCount}: {topScores}");
    }

    private void PrintPassingScores()
    {
        // - Prints all passing scores
        var passing = _scores.Where(score => score >= Threshold).OrderByDescending(score => score);
        string passingScores = string.Join(", ", passing);
        Console.WriteLine($"Passing scores (desc): {passingScores}");
    }

    private void PrintFailingScores()
    {
        // - Prints all failing scores
        var failing = _scores.Where(score => score < Threshold).OrderByDescending(score => score);
        string failingScores = string.Join(", ", failing);
        Console.WriteLine($"Failing scores (desc): {failingScores}");
    }
}
