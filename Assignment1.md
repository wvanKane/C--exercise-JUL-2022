# 01 Introduction to C# and Data Types
## Understanding Data Types
## Test your Knowledge
1. What type would you choose for the following “numbers”?
- A person’s telephone number -- Int
- A person’s height -- float
- A person’s age -- byte
- A person’s gender (Male, Female, Prefer Not To Answer) -- Char 
- A person’s salary -- decimal
- A book’s ISBN --int
- A book’s price --decimal
- A book’s shipping weight --float
- A country’s population -- int
- The number of stars in the universe --ulong
- The number of employees in each of the small or medium businesses in the United Kingdom (up to about 50,000 employees per business) -- ushort
2. What are the difference between value type and reference type variables? What is boxing and unboxing?
- value type holds data inside the memony
- ref means point to another memory location
- boxing tends to implict the type to another by its value
- unboxing extract the value form the obj
3. What is meant by the terms managed resource and unmanaged resource in .NET
- basically mean anything managed by the CLR
4. Whats the purpose of Garbage Collector in .NET?
- The garbage collector manages the allocation and release of memory for an application, this means that you don't have to write code to perform memory management tasks.

- Automatic memory management can eliminate common problems, such as forgetting to free an object and causing a memory leak or attempting to access memory for an object that's already been freed.

## Playing with Console App
Modify your console application to display a different message. Go ahead and intentionally add some mistakes to your program, so you can see what kinds of error messages you get from the compiler. The more familiar you are with these messages, and what causes them, the better you'll be at diagnosing problems in your programs that you / didn't/ intend to add!

Using just the ReadLine and WriteLine methods and your current knowledge of variables, you can have the user pass in quite a few bits of information. Using this approach, create a console application that asks the user a few questions and then generates some custom output for them. For instance, your program could generate their "hacker name" by asking them their favorite color, their astrology sign, and their street address number. The result might be something like "Your hacker name is RedGemini480."

## Practice number sizes and ranges
1. Create a console application project named /02UnderstandingTypes/ that outputs the
number of bytes in memory that each of the following number types uses, and the
minimum and maximum values they can have: sbyte, byte, short, ushort, int, uint, long,
ulong, float, double, and decimal.
2. Write program to enter an integer number of centuries and convert it to years, days, hours,
minutes, seconds, milliseconds, microseconds, nanoseconds. Use an appropriate data
type for every data conversion. Beware of overflows
>Input: 1
Output: 1 centuries = 100 years = 36524 days = 876576 hours = 52594560 minutes
= 3155673600 seconds = 3155673600000 milliseconds = 3155673600000000
microseconds = 3155673600000000000 nanoseconds
Input: 5
Output: 5 centuries = 500 years = 182621 days = 4382904 hours = 262974240
minutes = 15778454400 seconds = 15778454400000 milliseconds = 15778454400000000
microseconds = 15778454400000000000 nanoseconds

## Explore following topics
- C# Keywords
- Main() and command-line arguments
- Types (C# Programming Guide)
- Statements, Expressions, and Operators
- Strings (C# Programming Guide)
- Nullable Types (C# Programming Guide)
- Nullable reference types
## Controlling Flow and Converting Types
### Test your Knowledge
1. What happens when you divide an int variable by 0?
- Unhandled exception. System.DivideByZeroException: Attempted to divide by zero.
2. What happens when you divide a double variable by 0?
- infinity
3. What happens when you overflow an int variable, that is, set it to a value beyond its range?
- Throw an out of range exception
4. What is the difference between x = y++; and x = ++y;?
- the first makes x, y equal then adds y by 1
- while the 2nd one adds y by 1 then makes xy equal
5. What is the difference between break, continue, and return when used inside a loop statement?
- break means end of the loop by this step
- continue means resume and hold to the next step
- return end the loop and return the result

6. What are the three parts of a for statement and which of them are required?
- There are initialization, condition, iteration.
7. What is the difference between the = and == operators?
- = assign a value to the var
- == check if both sides are equal by checking their memory location
8. Does the following statement compile? for ( ; true; ) ;
- meaning loop endlessly
9. What does the underscore _ represent in a switch expression?
- The underscore _ character replaces the default keyword to signify that it should match anything if reached.
10. What interface must an object implement to be enumerated over by using the foreach
statement
- System.Collections.IEnumerable or System.Collections.Generic.IEnumerable

