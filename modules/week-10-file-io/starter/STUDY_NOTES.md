# Week 10: Habit Tracker (File I/O) — Study Notes

**Name:** Cedar Quarmby

## File I/O — Reading

**What does `File.ReadAllLines` return, and how did you use it?**
[Think about the return type and what you did with each element]

Answer: It returns an array where each item is one line from the file

**Why is it important to skip blank lines when reading a CSV file?**
[What would happen if you tried to split an empty string on `','`?]

Answer: If you tried to split an empty string, there would be nothing to split and it would cause an error

## File I/O — Writing

**What does `File.WriteAllLines` do, and what arguments does it take?**
[Describe the path argument and what goes in the string array]

Answer: It adds a line to a file, or creates a file and adds a line to it. It takes the path and the lines you want to add

**What is `Select(...).ToArray()` doing in `SaveHabits`?**
[Break down the two steps: what does `Select` produce, and why call `ToArray()`?]

Answer: Select turns each item in the csv file into a string and ToArray() turns those strings into an array

## Exception Handling

**What is a `FileNotFoundException` and when does it occur?**
[Describe the scenario where C# throws this specific exception]

Answer: When the program can't find the file, either because it doesn't exist or there was a typo when it requested the path

**Why do we catch `FileNotFoundException` specifically instead of using `catch (Exception)`?**
[Think about what catching all exceptions can hide from you]

Answer: We only wanted to handle FileNotFoundException errors

## What I Learned

**Key takeaways from this week:**
[List 3 main things you learned]

1. How to edit/read a CSV file
2. How to purposely handle errors
3. Remembered that you can't have the prompt in the Console.ReadLine() like you can in Python

**What was the trickiest part of this assignment and how did you work through it?**

Answer: Fixing the numerous errors (lots of brain farts)

## Time Spent

**Total time:** 6 hours

**Breakdown:**

- Understanding the starter code and CSV formats: 1 hours
- Implementing LoadHabits: 1 hours
- Implementing PrintHabits / PrintSummary: 1 hours
- Implementing AddHabit / UpdateHabit / SaveHabits: 1 hours
- Testing and debugging: 1 hours
- Writing study notes: 1 hours

**Most time-consuming part:**

Answer: Procrastination
