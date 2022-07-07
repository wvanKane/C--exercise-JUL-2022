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