# Week 8: Mad Libs (Structure + Debugging) - Study Notes

**Name:** Cedar Quarmby

## Program Structure

**What helper methods did you create (and what does each one do)?**
[List your methods and briefly describe each]

Answer:
ChooseTemplate() gets the user to select a template and adds the related questions to an array
CollectWords() prints each question and uses ReadNonEmptyString() to validate input, then adding the input to an array
ReadYesNo() prints the prompt and validates y/n input
ReadIntInRange() prints the prompt and validates int input
ReadNonEmptyString() prints the prompt and validates int input
GenerateStory() checks if the input words array is the same length as the questions array and uses FormatStory() to add words to the template sentence
FormatStory() adds input words to the sentence related to the chosen template


**Why is it helpful to move code out of `Main` and into helper methods?**
[Explain how this improves readability and reduces bugs]

Answer: Separates everything when debugging, organization, can reduce repeated code

## Data Modeling

**What is the purpose of the `StoryTemplate` class in this assignment?**
[Explain what data it stores and why]

Answer: It stores the selected story name, questions, and template sentence

**How did using a template make it easier to support two different stories?**
[Explain how the same logic can work with different prompts/text]

Answer: It was easier than having an if statement with a lot of values and Console.ReadLine()s

## Testing and Debugging

**Where did you set a breakpoint while debugging this program (what line or method)?**
[Be specific - example: inside GenerateStory, at the beginning of CollectWords, etc.]

Answer: Line 177 `isValid = !string.IsNullOrWhiteSpace(value);`

**What did you learn from stepping through your code line by line?**
[Describe how watching execution helped you understand flow or find bugs]

Answer: I learned how to use the VSC debugger and I found a logic error

**What bug or logic mistake did you encounter (and how did you fix it)?**
[Describe a real issue you ran into and how breakpoints/stepping helped]

Answer: I didn't put a ! on line 177 and it kept saying my input was empty when it wasn't. That is the only error I had

## What I Learned

**Key takeaways from this week:**
[3 main things you learned]

1. IsNullOrWhiteSpace returns true if it IS null or whitespace, so you need to have a !
2. How to use functions across files
3. How to make code more efficient with classes and functions

**What part of this assignment helped you understand program structure the most?**
[Breaking into methods, using public/private methods, separating concerns, etc.]

Answer: Placing the StoryTemplate in its own class keeps its responsibilities separate and encapsulated, rather than mixing them into the main program

## Time Spent

**Total time:** [4 hours]

**Breakdown:**

- Planning structure (methods/classes): [1.5 hours]
- Input validation: [1 hours]
- Story templates + formatting: [1 hours]
- Testing and debugging: [0 hours]
- Writing documentation: [0.5 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: Understanding how to format the template text

## Reflection

**What would you improve if you had more time?**
[Ideas: more templates, better formatting, more validation, etc.]

Answer: More templates, more questions

**How did breaking your program into smaller parts help you debug?**
[Explain the connection between structure and debugging]

Answer: It was easier to identify where in the program the error was
