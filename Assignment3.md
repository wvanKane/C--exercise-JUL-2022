# 03 Object-Oriented Programming
## Test your knowledge
1. What are the six combinations of access modifier keywords and what do they do? 
- **public**: The type or member can be accessed by any other code in the same assembly or another assembly that references it. 
- **protected internal**: same as public but without the capability to be used in a non-derived class in a different assembly
- **protected**: same as public but without the capability to be used in a non-derived class in the same assembly
- **internal**: same as public but without the capability to be used in a derived class in a different assembly 
- **private protected**: Can be used within the class and derived classes
- **private**: only accessible in the **class** or **struct** in context
2. What is the difference between the **static, const, and readonly** keywords when applied to
a type member?
- **Static** refers to a variable, method or class belongs to the type itself rather than a specific object
- **Const** refers to a variable that can only be initialized during compile time and then becomes immutable (cannot change its value)
- **Readonly** refers to a variable that can only be initialized either during compile time or runtime, but then cannot have its values changed
3. What does a constructor do?
- A **constructor** is a special method in which creates an instance of the class
4. Why is the partial keyword useful?
- The partial keyword indicates that other parts of the class, struct, or interface can be defined in the namespace.
5. What is a tuple?
A **tuple** can represent a database record, and its components can represent individual fields of the record.
6. What does the C# *record* keyword do?
7. What does *overloading* and *overriding* mean?
- **Overloading** is when the same class has the same name for two methods that may take different number/order of/types of parameters.
- **Overrriding** is when a child class has the same name for a method as its parent class.
8. What is the difference between a field and a property?
- A field is a variable of any type that is declared directly in a class. 
- A property is a member that provides a flexible mechanism to read, write or compute the value of a private field.
9. How do you make a method parameter optional?
-- params
10. What is an interface and how is it different from abstract class?
- An interface is a blueprint of a class. 
It is different from abstract classes in that an interface must have public methods and values, while abstract classes are not limited to this.
11. What accessibility level are members of an interface?
- pubilc
12. **True**/False. Polymorphism allows derived classes to provide different implementations of the same method.
13. True/**False**. The override keyword is used to indicate that a method in a derived class is
providing its own implementation of a method.
14. True/**False**. The new keyword is used to indicate that a method in a derived class is
providing its own implementation of a method.
15. True/**False**. Abstract methods can be used in a normal (non-abstract) class. 
16. **True**/False. Normal (non-abstract) methods can be used in an abstract class. 
17. **True**/False.
Derived classes can override methods that were virtual in the base class. 
18. True/**False**.
Derived classes can override methods that were abstract in the base class. 
19. **True**/False.
In a derived class, you can override a method that was neither virtual non abstract in the
base class.
20. True/**False**. A class that implements an interface does not have to provide an
implementation for all of the members of the interface.
21. **True**/False. A class that implements an interface is allowed to have other members that
aren’t defined in the interface.
22. **True**/False. A class can have more than one base class.
23. **True**/False. A class can implement more than one interface.