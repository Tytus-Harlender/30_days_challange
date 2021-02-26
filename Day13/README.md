#Day13


SOLID

- it is acronym for a set of good patterns in writting code (principles). It stands for the following:

S - Single Responsibility Principle
O - Open for Extension and closed for Modification Principle
L - Liskov substitution Principle
I - Interface Segregation Principle
D - Dependency Inversion Principle

In my opinion S and I principles share the dividing the responsibility of the software, whereas O, L and D principles share different perspective.
L is somehow an extension of O principle and D is somehow an extension of L principle.

'Single responsibility principle'

It tells that functionality should be divided into smallest pieces possible.
For example we should have separate class for each responsobility in the code. 
The single responsibility principle is one of the most commonly used design principles in object-oriented programming.
It makes your software easier to implement and prevents unexpected side-effects of future changes. The more responsibilities your class has, the more often you need to change it.
If your class implements multiple responsibilities, they are no longer independent of each other.
Single responsibility classes are easier to understand and explain.
What is the responsibility of your class/component/microservice? - If your answer includes the word “and”, you’re most likely breaking the single responsibility principle.

'Open for Extension and closed for Modification Principle'

It tells you to write your code so that you will be able to add new functionality without changing the existing code.
That prevents situations in which a change to one of your classes also requires you to adapt all depending classes.
However, there came a problem. In OOP inheritance introduces tight coupling if the subclasses depend on implementation details of their parent class.
That’s why Robert C. Martin and others redefined the Open/Closed Principle to the Polymorphic Open/Closed Principle. 
It uses interfaces instead of superclasses to allow different implementations which you can easily substitute without changing the code that uses them. 
The interfaces are closed for modifications, and you can provide new implementations to extend the functionality of your software.
The main benefit of this approach is that an interface introduces an additional level of abstraction which enables loose coupling.


'Liskov substitution Principle'

This principle defines that objects of a superclass shall be replaceable with objects of its subclasses without breaking the application.
That requires the objects of your subclasses to behave in the same way as the objects of your superclass.
Following the rules of open/closed principle alone is not enough to ensure that you can change one part of your system without breaking other parts.
Your classes and interfaces also need to follow the Liskov Substitution Principle to avoid any side-effects.
It extends the Open/Closed Principle by focusing on the behavior of a superclass and its subtypes.
For example, to provide this an overridden method of a subclass needs to accept the same input parameter values as the method of the superclass (similar goes with the return value).
Unfortunately, there is no easy way to enforce this principle.
You need to implement your own checks to ensure that your code follows the Liskov Substitution Principle.
In the best case, you do this via code reviews and test cases.

'Interface Segregation Principle'


The goal of the Interface Segregation Principle is to reduce the side effects and frequency of required changes by splitting the software into multiple, independent parts.
The idea is that you segregate the interfaces so that the functionalities of the different coffee machines are independent of each other.
By following this principle, you prevent bloated interfaces that define methods for multiple responsibilities.


'Dependency Inversion Principle'

Robert C. Martin’s definition of the Dependency Inversion Principle consists of two parts:

    High-level modules should not depend on low-level modules. Both should depend on abstractions.
    Abstractions should not depend on details. Details should depend on abstractions.
    
It is based on the O and L principles.
If you consequently apply the Open/Closed Principle and the Liskov Substitution Principle to your code, it will also follow the Dependency Inversion Principle.



SOURCE:
https://stackify.com/solid-design-principles/
