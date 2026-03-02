# Week 3: Personal Profile Card - Study Notes

**Name: Cedar Q**

## Understanding Variables and Data Types

**What are the four main data types you used in this assignment?**
[List string, int, double, and bool - explain what each stores and give examples from your profile card]

Answer: String, int, double, and bool

**Why did you use `double` for GPA instead of `int`?**
[Explain the difference and why decimal precision matters for GPA]

Answer: Because GPAs are a decimal-based system

**How did you convert the yes/no input into a boolean?**
[Explain the comparison operation you used]

Answer: I turned the string into lowercase and set the bool to be true if the string was equal to "y" or "yes"

## Data Modeling Decisions

**How did you organize the information into logical groups?**
[Explain why you grouped certain pieces of information together (personal, academic, etc.)]

Answer: I grouped it based on the order in the instructions

**Which pieces of information did you calculate rather than ask for?**
[List the derived data: birth year, years to graduation, height conversion, honor status, age in months]

Answer: Birth year, years until graduation, height in feet and inches, honor student or not, and age in months

**Why is it better to calculate birth year from age rather than ask for both?**
[Explain data consistency and reducing redundant input]

Answer: Asking for both increases the chance of user error, and given one of the variables we can find the other very easily

## Challenges and Solutions

**Biggest challenge with this assignment:**
[What was the hardest part? Type conversion, calculations, formatting, choosing data types?]

Answer: Type conversion

**How you solved it:**
[Explain your approach to overcoming the challenge]

Answer: Looked at previous assignment

**Most confusing concept:**
[What was hardest to understand? Type casting, modulus for height, boolean logic, or formatting?]

Answer: When dotnet got annoyed for double spaces in between lines (it's just how I organize comments and stuff)

## Type Conversion and Calculations

**How do you convert string input to a number?**
[Explain Parse methods: int.Parse(), double.Parse()]

Answer: Parse turns numerical strings into doubles, ints, or decimals

**What calculation did you use to convert height from inches to feet and inches?**
[Explain: feet = inches / 12, remaining = inches % 12]

Answer: I divided the height in inches by 12 and rounded down and got the remainder of dividing the two and rounded that

**How did you determine if someone is an honor student?**
[Explain the boolean comparison: gpa >= 3.5]

Answer: If gpa >= 3.5 then that outputs true, if it's not then it's false

## Output Formatting

**How did you format the GPA to show exactly 2 decimal places?**
[Explain the :F2 format specifier]

Answer: The :F2 format specifier automatically makes the variable (double, int, or decimal) appear with 2 decimal places when places like so {variable:F2}

**How did you display different text based on whether someone is full-time or part-time?**
[Explain the conditional/ternary operator you used]

Answer: There is a y/n input and if the user enters 'y' or 'yes' then the bool displays as 'True' and if they enter anything other than 'y' or 'yes' then it displays as 'False'

**What techniques did you use to make the output look organized?**
[Discuss alignment, spacing, section headers, borders]

Answer: I used \n and \". I also added headers and organized it in a user-friendly manner

## Real-World Data Modeling

**What other calculated fields could you add to a profile?**
[Think of other derived data: BMI from height/weight, time to birthday, etc.]

Answer: Registered with disability services for accomidations or not, class schedule

**Why is choosing the right data type important in real applications?**
[Explain memory, precision, and type safety]

Answer: Clarity and efficiency

**How does this profile card relate to real-world applications?**
[Think about social media profiles, job applications, student records systems]

Answer: Data is collected about users for almost every application that has an account or profile system, and the data about the user will depend on the purpose of the application

## What I Learned

**Key takeaways from this week:**
[What are the 3-5 most important things you learned about variables and data modeling?]

1. You can use collected data to calculate other data without having to ask for it
2. The way C# works is very similar to JS and Python, which makes learning it way easier and faster
3.
4.
5.

**Which data type was most challenging to work with and why?**
[Reflect on your experience with string, int, double, or bool]

Answer: Bool, because you had to turn strings into True or False. Despite being the most difficult one, it was also quite easy

**How does understanding data types help you write better programs?**
[Explain the benefits of type safety and appropriate data representation]

Answer: Using the most efficient data type for different things (mostly just int and double) can make output more or less precise as required

## Testing and Debugging

**What test cases did you use to verify your calculations?**
[List different inputs you tested - edge cases, typical values, etc.]

Answer: (fullName) Jeremy Bond Samuels - (homeTown) Anacortes, Washington - (major) Theatre - (gpa) 3.2 - (graduationYear) 2027 - (fullTime) Yes - (age) 26 - (heightInches) 72

**What bugs or errors did you encounter and fix?**
[Describe any type conversion errors, calculation mistakes, or formatting issues]

Answer: Incorrectly calculating the height in feet and inches

**How did you validate that your data types were correct?**
[Explain how you checked that GPA, heights, ages worked correctly]

Answer: I tested with different numbers and decimals

## Time Spent

**Total time:** [2 hours]

**Breakdown:**

-   Understanding data types and planning variables: [5 minutes]
-   Collecting user input with correct types: [10 minutes]
-   Implementing calculations: [25 minutes]
-   Formatting output: [20 minutes]
-   Testing and debugging: [20 minutes]
-   Writing documentation: [40 minutes]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: Study notes

## Reflection

**What would you do differently if you started over?**
[Consider variable names, calculation order, organization, etc.]

Answer: Remember to do study notes on the first commit and read the TODO comments a little more thoroughly

**How does proper data modeling make programs easier to maintain?**
[Think about readability, consistency, and reducing errors]

Answer: Using the wrong data types produces errors, so using the correct ones is key

**What real-world system would you like to model next?**
[Shopping cart, game character, recipe calculator, etc.]

Answer: Some sort of chat application, like texting or discord
