# Week 6: Text Menu App - Study Notes

**Name: Cedar Q**

## Loop Types

**How is a `do-while` loop different from a `while` loop?**
[Explain when each loop is best used]

Answer: While loops check the parameter first and then execute, do-whiles execute first and then check the parameters for future execution

**Where did you use a `do-while` loop in this assignment and why?**
[Describe how you validated the menu choice and numeric inputs]

Answer: ReadIntInRange and ReadDouble for validating int and double inputs

**Where did you use a `while` loop and why?**
[Describe the menu loop and why it repeats]

Answer: To

**Where did you use a `for` loop and why?**
[If you didn’t use a for loop, explain why it wasn’t needed]

Answer: We didn't use a for loop because we didn't have any scenarios where we needed one

## Input Validation

**Why did you create a helper method for input validation?**
[Explain how it avoids repeating code for multiple prompts]

Answer: To prevent repetitive code

**How did you validate the menu choice (1–6)?**
[Explain your range check logic and do-while loop]

Answer: I used ReadIntInRange() to make sure it was in the correct boundaries

**How did you handle invalid input (non-numbers)?**
[Explain how int.TryParse and double.TryParse work]

Answer: I placed int/double.TryParse in my validator functions (ReadIntInRange and ReadDouble)

## String Operations

**Which string methods did you use across the different menu options?**
[List key methods like Trim, ToUpper, ToLower, Replace, Split, Join, Contains, PadLeft, PadRight, and formatting techniques]

Answer: All of the above

**Which four string methods did you demonstrate in Option 6 (String Analysis)?**
[Explain Equals with StringComparison, Substring, EndsWith, and IndexOf]

Answer: I'm not sure how to explain it

**What's the difference between string concatenation and interpolation?**
[Explain when you used each approach and which you prefer]

Answer: I personally prefer interpolation because it is more space efficient, but concatenation operates the same it does in Python and JS

## What I Learned

**Key takeaways from this week:**
[3-5 main things you learned]

1. How string methods work in C#
2. Switch statements
3. Column formatting
4.
5.

**Which loop felt most natural to use and why?**

Answer: While, while this parameter is true do this thing

## Time Spent

**Total time:** [6 hours]

**Breakdown:**

- Planning the loops: [1 hours]
- Input validation: [1 hours]
- String formatting: [1 hours]
- Testing and debugging: [2 hours]
- Writing documentation: [1 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: Understanding how things work so I could use them

## Reflection

**What would you do differently next time?**

Answer: Start earlier

**How did using three different loop types improve your understanding of repetition?**

Answer: I got a better understanding
