# 02 Arrays and Strings
## Test your Knowledge
1. When to use String vs. StringBuilder in C# ?
- Strings are immutable and can only be defined once, but StringBuilder allows for mutable strings, so if a string changes, then StringBuilder is recommended.
2. What is the base class for all arrays in C#?
- **The Array class** is the base class for all the arrays in C#
3. How do you sort an array in C#?

> Array.Sort(array)

4. What property of an array object can be used to get the total number of elements in an array?
- length
5. Can you store multiple data types in System.Array?
- Nap, we cannot store multiple datatype in an Array, we can store similar datatype only in an Array.
6. What’s the difference between the System.Array.CopyTo() and System.Array.Clone()?
- The clone is of the same Type as the original Array. The CopyTo() method copies the elements into another existing array. It copies the elements of one array to another pre-existing array starting from a given index (usually 0).