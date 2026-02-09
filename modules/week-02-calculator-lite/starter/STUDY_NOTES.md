# Week 2: Calculator Lite - Study Notes

**Name: Cedar Q**

## Understanding Data Types

**What are the four data types you used in this assignment?**
[List each data type (string, bool, int, double) and explain what kind of data each one stores]

Answer:
int - Just int, any whole number
double - Stuff with one decimal, like 45.6 or 2.1. Double can also output to look like int
decimal - Stuff with any number of decimals, like 103.7 or 3.14195
bool - True or false values
string - Just string, anything in between double/single quotes

**Why did we use `double` instead of `int` for the calculations?**
[Explain the difference between int and double, and why double is better for this calculator]

Answer: Because we needed decimal places and ints don't support them

**How do you convert a string to a boolean?**
[Explain how you converted the user's "yes/no" input into a true/false value]

Answer: If the string = "yes" or "y", then the bool = True

## Challenges and Solutions

**Biggest challenge with this assignment:**
[What was the hardest part? Understanding data types, getting user input, performing calculations, formatting output, or handling division by zero?]

Answer: Resisting the urge to make sure all the input was valid. It's completely possible for the user to input "potato" instead of a number when prompted, but the validation got a bit too complicated so I got rid of it.

**How you solved it:**
[Explain what you did to overcome the challenge - reviewed documentation, asked for help, tested different approaches, etc.]

Answer: I had a proffessional lead develepor (aka my dad) assist me when I got stuck on some things. Overall it was relatively easy, considering my previous coding experience.

**Most confusing concept:**
[What was hardest to understand? Parsing input, modulus operator, percentage formula, conditional formatting, or something else?]

Answer: Using double vs int

## Understanding Arithmetic Operations

**What is the difference between the modulus operator (%) and division (/)?**
[Explain what each operator does and give an example]

Answer: Modulo operator gets the remainder of a / b

**How do you calculate the average of two numbers?**
[Write the formula in your own words]

Answer: Add all the numbers together and then divide them by the total count of numbers

**What is the formula for percentage difference?**
[Explain the formula you used: ((num1 - num2) / num1) * 100]

Answer: We subtract the second number from the first number, then divide by the first number, and multiply by 100 to get a percentage.

## Input and Output

**How do you read user input in C#?**
[Explain what Console.ReadLine() does and what type of data it returns]

Answer: Console.ReadLine() reads the user input and outputs a string.

**How do you convert string input to a number?**
[Explain the Parse methods you used, like double.Parse()]

Answer: I used int.Parse() to convert strings to whole numbers and double.Parse() to convert strings to numbers with decimal places

**What is string interpolation and how did you use it?**
[Explain the $ symbol and curly braces {} in Console.WriteLine()]

Answer: I used string interpolation to insert variables directly into the output, without needing to use concatentation.

## Conditional Logic

**How do you format numbers with 2 decimal places vs whole numbers?**
[Explain the :F2 and :F0 format specifiers]

Answer: :F2 displays 2 decimal places of a number when outputting to console

**Why is it important to check for division by zero?**
[Explain what happens if you try to divide by zero and how you handled it]

Answer: If you divide by zero it throws an error, so I used an if statement to check if num2 is 0 before dividing

**How did you use the boolean variable to control formatting?**
[Explain how you used if/else to format output differently based on user preference]

Answer: I checked the decimal preference and used a differerent format for the number output.

## What I Learned

**Key takeaways from this week:**
[What are the 3-5 most important things you learned?]

1. String interpolation with $"{}"
2. Converting strings to booleans
3. Converting strings to integers
4. Converting strings to doubles
5. The difference between Parse() and TryParse()

**Which data type concept was most useful?**
[Explain which data type (string, bool, int, or double) you found most interesting and why]

Answer: Double was the most useful for this assignment because of the math

**How does conditional formatting improve user experience?**
[Why is it helpful to let users choose decimal precision?]

Answer: It allows users to choose the formatting they like

## Testing and Debugging

**What test cases did you use to verify your program works?**
[List the different inputs you tested - positive numbers, negative numbers, decimals, zero, etc.]

Answer: I tested with negative numbers, zero and decimal places. I also tested with strings, but it broke :(

**What bugs or errors did you encounter and fix?**
[Describe any errors you got and how you fixed them]

Answer: Trying to use double.Prarse() and assign to an int didn't work. Had to use double everywhere. Also trying to add to an unassigned variable.

## Time Spent

**Total time:** 3.5 hours

**Breakdown:**

-   Understanding data types: [0.25 hours]
-   Reading and parsing user input: [0.75 hours]
-   Implementing arithmetic operations: [0.25 hours]
-   Adding conditional formatting: [0.25 hours]
-   Handling division by zero: [0.25 hours]
-   Testing and debugging: [1 hours]
-   Writing documentation: [0.75 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: Testing and debugging. I got stack for a while with unassigned variables.

## Reflection

**What would you do differently next time?**
[What would you change in your approach or code?]

Answer: I would pay more attention to the number types being used. I would make sure to assign initial values.

**How does this assignment prepare you for more complex programs?**
[Why are these skills important for future programming tasks?]

Answer: I have a better foundation to learn C# (and other languages) in the future.
