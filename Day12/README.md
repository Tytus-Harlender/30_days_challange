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
  
  The generics are the concept of declaring a class without specific declaration of the data type (T) it will use. The scope of the possible types to be used in such class is treated generally (hence the name) not specificaly. In other words, "generic" means the general form, not specific. It may be better understood on the given example in the class "DataStorage". We can see '<T>' standing directly after the name of the class, meaning this specific class is generic. We specify the type during creating an instance of the class.
  This may be seen within "GenericsPresentation" class. We declare that this created instance will contain string data type. If we then try to assign a value of a different type we will find ourselves in a compilation error.
  
  Very well then, but are we obliged to use only one generic type within the class? No. Moreover, we do not have to name it with single capital letter 'T'.
"KeyValuePair" class represents this case. The idea behind it is the same as in "DataStorage" class, omitting one single difference - we have to 'slots' for type declaration - TKey and TValue (note that we now have picked custom names instead of simply passing 'T' letter again).
  
  In both above generic classes the type is a type of a specified property - Data (in "DataStorage") and both Key and Value (in "KeyValuePair") respectively.
  
  t.b.c.
  
  sources: https://www.tutorialsteacher.com/csharp/csharp-generics
          https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/types/generics
3. Threads
4. Asynchronous communication
