#Day4

What do the terms “boxing” and “unboxing” mean? (Exmaples in code) What is the difference between a class and an object, and how do these terms relate to each other? What is value type and reference type? (examples in code)

1.	Boxing and unboxing

Boxing is the process of converting a value type to the type object or to any interface type implemented by this value type. Class ‘BoxingExample’ shows it’s idea. The object ‘o’ can apply value type ‘a’. The later printing of ‘a’ value does not affect it ‘o’ value.
Why is it usefull?
The storage of both data types is different. Value types such as ‘a’ in this case are stored on stack whereas reference type such as object ‘o’ are stored on a heap. Therefore in boxing example we may see how a value is trensfered to reference type from a stack to a heap.

https://cezarywalenciuk.pl/blog/programing/kurs-obiektowosc-w-c-systemobject-boxing-i-unboxing-rzutowanie-06

2.	Class and object

We may see how a class for object instances with fields, properties and methods is defined in ‘MyClass.cs’. On the other hand, in ‘ObjectForMyClass.cs’ we may see how an instance of ‘MyClass’ is created and how it’s methods and fields are used in the next code lines, printing the members in the consoleline.


3.	Value type and reference type – two basic kind of types in C#

Value type variable contains an instance of the type. With value types, each variable has its own copy of the data, and it is not possible for operations on one variable to affect the other (except in, out and ref keywords usage)

Reference type variable contains a reference to an instance of the type. With reference types, two variables can reference the same object; therefore, operations on one variable can affect the object referenced by the other variable.
