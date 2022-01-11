#Day 12 helper method - extension method - generics - Threads - Asynchronous communication


1. Helper methods 

A "helper method" isn't anything special, and isn't a language feature.
It doesn't differ in any way from a regular method.
A helper method is just a method that helps you do something else.
For example, if you had to find the square root of a number multiple times within a method, you wouldn't write out the code to find the root each time you needed it.
You'd separate it out into a method like Math.Sqrt.

2. Extension method

On the contrary, an extension method is a language feature.
Extension methods allow you to make it so you can omit the class containing the method, and allow you to call your method directly on a variable.
If you, for example, had a string variable and were to call one of the methods on it, you would use the variable name followed by the dot operator followed by the method name and method call operator.
Such use is presented in the 'StringEditor' class. By declaring 'firstLetter' method as the extension method we may use it directly on the string in our programme.
Extension methods are declared in much the same way as normal methods, just with the 'this' keyword before the first argument (and the first argument being of the type you want to be able to call the method on).

When to use?

Probably the most common use of extension methods is with LINQ, which uses extension methods to add extra functionality to any class that implements IEnumerable<T>.
Through LINQ's use of extension methods, you can use methods that work on List<T>s, arrays, and anything else that implements IEnumerable<T> even though the method is only defined in one place (which makes the method easier to maintain).

source: 
https://social.msdn.microsoft.com/Forums/sqlserver/en-US/7b24548c-953e-4aeb-bf9e-3d7a22015ed6/what-exactly-is-a-c-helper-method?forum=smallbasic

2. Generics
3. Threads
4. Asynchronous communication
