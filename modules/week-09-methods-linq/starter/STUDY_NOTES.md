# Week 9: Score Stats (Methods + LINQ) - Study Notes

**Name:** Cedar Quarmby

## Methods and Decomposition

**Why is it helpful to break a program into small methods?**
[Think about readability, testing, and debugging]

Answer: Separates everything when debugging, organization, can reduce repeated code

## LINQ (Stats + Method Chaining)

**Which LINQ methods did you use for basic statistics?**
[Examples: Min, Max, Average, Count with predicates]

Answer: I used Min, Max, Average, Count, OrderBy, OrderByDescending, and Where

**Which LINQ methods did you chain together for reports?**
[Examples: Where + OrderByDescending, OrderByDescending + Take]

Answer:
81 - OrderByDescending + Take
89 - Where + OrderByDescending
97 - Where + OrderByDescending

**Why is it helpful to put score logic in a class (ScoreReport) instead of keeping everything in Program?**
[Think about organization, reuse, and readability]

Answer: Organization increases maintainability. Everything related to scores is all in one place

## What I Learned

**Key takeaways from this week:**
[3-5 main things you learned]

1. Method chaining
2. Using var
3. OrderBy and OrderByDescending
4.
5.

**Which concept felt easiest (methods or LINQ) and why?**

Answer: Method

## Time Spent

**Total time:** 2 hours

**Breakdown:**

- Understanding the starter code: 1/2 hours
- Implementing the print methods: 1 hours
- LINQ method chaining: 1/4 hours
- Testing and debugging: 1/8 hours
- Writing documentation: 1/8 hours

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: Using string.Join() to create a string from a list of numbers

## Reflection

**What would you improve next time?**

Answer: Find more ways to use var

**How did methods make this program easier to work on?**

Answer: I didn't have to write a lot of it myself
