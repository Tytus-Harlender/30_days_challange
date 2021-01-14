#Day5

Comparison of struct and a class – ‘sealed’ keyword -  difference between overloading and overriding

1.	Struct vs class

The main difference is that struct is a value type and class is a reference type. The place of data storage is then different (stack vs heap) and therefore an access to is’s data may be sometimes faster for the structs. Another consequence is that structs as value types must contain a value (nullable type extension for values does not apply here). Class can be null type. Moreover, when you copy a struct and alter the copy it does not affect the original. In contrary, a copy of a class modification always influences the second one as it is the same data location (what is copied is just a pointer).


Structs have a default public members. We may see usage of a struct in StructExample class. We first define the struct and later assign values to it’s members, which will be further displayed. Note that all members are public and that we do not use new keyword for initializing the struct. In .NET there are already some built-in structs which don’t need to be defined as DateTime.

Main differences:
-structs are value types and classes are reference types
(the rest are a consequance of the above)
- structs do not support inheritance, but classes do
- structs cannot have default constructors

Source:
https://stackoverflow.com/questions/54585/when-should-you-use-a-class-vs-a-struct-in-c
https://www.dotnetperls.com/struct
https://stackoverflow.com/questions/13049/whats-the-difference-between-struct-and-class-in-net
https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/choosing-between-class-and-struct




2.	Sealed keyword

Sealed keyword is used to prevent other classes from inheriting from it. It may be also applied to methods and properties. Then the restriction is limited to the selected members not the hole class. 

We may see an example of sealed keyword in “StopInheritance” class. First class is an abstract class with two methods. StopInheritance.cs derives from FirstClass and overrides these two methods. There we can see that word sealed is used. The consequence may be seen in the third class called FinalClass which can override only F2() method as this is not restricted from it. Attempt to override F() would proceed with an error.

When to use it?

-	For security purposes in order to make the classes responsible for security features, to prevent them from being modified
-	To increase the performance rate of processes as ‘sealed’ tells that there is no need for searching for methods further down and that speeds things up. 


Source:
https://stackoverflow.com/questions/7777611/when-and-why-would-you-seal-a-class
https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/sealed


3.	Overloading vs overriding

Overloading is a multiple declaration of the same method within one class. Each declaration has the same method name but different input parameters.

Overriding is describing a new functionality of a method previously defined in a base class after the inheritance of these class.

Both concepts are presented within ‘OverloadingExample’ and ‘OverridingExample’ classes. In the first one we may see that PrintSomething method is declared twice but each declaration takes different parameters. In  ‘OverridingExample’ we see a base abstract class with abstract method that is later overridden.



Source:
https://stackoverflow.com/questions/673721/overloading-and-overriding
https://www.w3schools.com/cs/cs_method_overloading.asp

	


