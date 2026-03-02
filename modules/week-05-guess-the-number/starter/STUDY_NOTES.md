# Week 5: Guess the Number - Study Notes

**Name: Cedar Q**

## Loop Types

**How is a `do-while` loop different from a `while` loop?**
[Explain when each loop is best used]

Answer: Do-while has the while (parameters) at the end instead of at the start, since it does the stuff in the loop before checking the parameters. Once it checks the parameters, it either does the loop again or stops.

**Where did you use a `do-while` loop in this assignment and why?**
[Describe the input validation use]

Answer: I used a do-while in the input validation function so that it would TryParse() the input and then check if it was invalid

**Where did you use a `while` loop and why?**
[Describe the guessing loop]

Answer: I used a while loop to check if the guess was the correct number or not

**Where did you use a `for` loop and why?**
[Describe the rounds loop]

Answer: I used a for loop to check when the number of rounds exceeded the maximum

## Input Validation

**Why did you create a helper method for input validation?**
[Explain how it avoids repeating code for max value and rounds]

Answer: Functions or helper methods prevent unnesessary code repetition

**How did you make sure the max value was between 10 and 100?**
[Explain your range check logic]

Answer: I made sure the max value was between 10 and 100 by using the ReadIntInRange() function and giving it the min and max the input needed to be in

**How did you make sure the number of rounds was between 1 and 3?**
[Explain your range check logic]

Answer: Same thing as the max value but with 1 and 3 and a different variable

**How did you handle invalid input (non-numbers)?**
[Explain how int.TryParse works]

Answer: If the TryParse() failed, the do-while loop would go through again and tell the user there was an error before asking for input again

## Guessing Logic

**How did you compare the guess to the secret number?**
[Explain the if/else logic for too low, too high, and correct]

Answer: If the number was too high or too low, it told the user and asked for another input. If it was correct, it told the user and ended the while and for loops.

**How did you count the number of guesses?**
[Explain where you incremented the counter]

Answer: Each time the user guesses, the guessCount goes up by 1

## Random Numbers

**How did you generate the secret number?**
[Explain Random and Next(min, max)]

Answer: Random.Next() outputs a number within a certain range

**Why does `Random.Next(1, max + 1)` include the max value?**
[Explain why +1 is needed]

Answer: If it was (1, max) then it would include the number right below max but not max itself, so max + 1 makes sure it includes max

## Testing and Debugging

**What inputs did you test to confirm your loops worked correctly?**
[List several test cases]

Answer: I tested numbers that were WAY too high or too low before testing closer numbers for each input

**What bugs or errors did you encounter and fix?**
[Describe any logic or loop errors]

Answer: For some reason, when I added the "Invalid input. Please try again" to ReadIntInRange(), it wouldn't display. I added the first variable so that it would only display if the TryParse() failed

## What I Learned

**Key takeaways from this week:**
[3-5 main things you learned]

1. Do-while loops
2. For loops (they look different than Python but the logic is still the same)
3. How to make functions/methods
4.
5.

**Which loop felt most natural to use and why?**

Answer: While and if, they're basically the same as Python/JS

## Time Spent

**Total time:** [2 hours]

**Breakdown:**

- Planning the loops: [30 minutes]
- Input validation: [40 minutes]
- Guessing logic: [20 minutes]
- Testing and debugging: [15 minutes]
- Writing documentation: [5 minutes]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: Writing the ReadIntInRange() do-while loop, I didn't see the requirement for the do-while loop until I had finished everything else because I put the function at the top and the instructions for it were at the bottom

## Reflection

**What would you do differently next time?**

Answer: I would be faster, because I understand C# loops better now

**How did using three different loop types improve your understanding of repetition?**

Answer: I got a better understanding on the different loop types, mostly the for loop
