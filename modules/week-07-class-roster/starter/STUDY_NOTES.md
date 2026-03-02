# Week 7: Class Roster Builder (Arrays) - Study Notes

**Name: Cedar Q**

## Arrays and `count`

**What are “parallel arrays” and how did you use them in this assignment?**
[Explain how rosterNames and rosterCredits stay lined up by index]

Answer: Parallel arrays are two arrays with the same number of items in each and relate to one another. Each index in rosterNames corresponds to the same index in rosterCredits

**What is the purpose of the `count` variable?**
[Explain how it tracks how many roster slots are “in use”]

Answer: Count corresponds to the amount of items in rosterNames/Credits

**Where did you use `count` in loops and why?**
[Explain why you loop 0..count-1 instead of using the full array length]

Answer: We checked if count was 0 (meaning rosterNames/Credits were empty) or not

## Printing and Sorting

**How did you print the class roster using a `foreach` loop?**
[Describe building an array of roster lines and then printing each line]

Answer: For every line in lines, we output it and moved on to the next one until we had done all of them

**How did you sort the roster while keeping names and credits aligned?**
[Describe copying the used roster into new arrays and using Array.Sort on parallel arrays]

Answer: Using Array.Sort() keeps the parallel elements synced

## What I Learned

**Key takeaways from this week:**
[3-5 main things you learned]

1. How to create arrays in C#
2. How to use Array.Sort() to sort and synchronize arrays
3. How to index arrays in C# with for(each) loops
4.
5.

**Which loop felt most natural to use and why?**

Answer: foreach. Using for loops in python the same way we used foreach made sense to me first and I feel it is easier to grasp

## Time Spent

**Total time:** [4 hours]

**Breakdown:**

- Planning the arrays/menu: [0.75 hours]
- Input validation: [1 hours]
- Add + print roster features: [0.75 hours]
- Sorting feature: [0.75 hours]
- Testing and debugging: [1 hours]
- Writing documentation: [1 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: Understanding the sections that used the helper functions

## Reflection

**What would you do differently next time?**

Answer: Making more time for commenting code

**How did using `for` and `foreach` improve your understanding of arrays?**

Answer: I can't think of anything specific that improved my understanding of for and foreach loops in relation to arrays
