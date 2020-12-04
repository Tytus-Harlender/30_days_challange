#Day4

What do the terms “boxing” and “unboxing” mean? (Examples in code) What is the difference between a class and an object, and how do these terms relate to each other? What is value type and reference type? (examples in code)

1.	Boxing and unboxing

Boxing is the process of converting a value type to the type object or to any interface type (which is a reference type) implemented by this value type. Class ‘BoxingExample’ shows it’s idea. The object ‘o’ can apply value type ‘a’. Therefore in boxing example we may see how a value is transfered to reference type. The bottom lines are an example of that in reference type we do use reference-equality which checks if the references are equal, not if the underlying values are equal. Therefore the logic value printed will be ‘false’. Because of reference-equality we need to use casting in unboxing process.

Unboxing is an operation reversed to boxing. It is a conversion from object type (reference type in general) to value type. However, we cannot do it directly, since obj type may contain a wider range of types than a value we want to assign (for example an int). That is why we use cast operation. It is telling the program what kind of type we suppose to see in unboxing object. UnboxingExample class shows that concept.

Why is it usefull?

To have a unified type system and allow value types to have a completely different representation of their underlying data from the way that reference types represent their underlying data. In boxing we change the value type of information into reference type of it by assigning the information to an object type (compare to difference between value and reference types). For example, the old collection type ArrayList only eats objects. That is, it only stores references to somethings that live somewhere. Without boxing you cannot put an int into such a collection. But with boxing, you can.


Sources:
https://stackoverflow.com/questions/2111857/why-do-we-need-boxing-and-unboxing-in-c
https://cezarywalenciuk.pl/blog/programing/kurs-obiektowosc-w-c-systemobject-boxing-i-unboxing-rzutowanie-06

2.	Class and object

We may see how a class for object instances with fields, properties and methods is defined in ‘MyClass.cs’. On the other hand, in ‘ObjectForMyClass.cs’ we may see how an instance of ‘MyClass’ is created and how it’s methods and fields are used in the next code lines, printing the members in the consoleline.


3.	Value type and reference type – two basic kind of types in C#

Value type variable contains an instance of the type. With value types, each variable has its own copy of the data, and it is not possible for operations on one variable to affect the other (except in, out and ref keywords usage). 

Reference type variable contains a reference to an instance of the type. With reference types, two variables can reference the same object; therefore, operations on one variable can affect the object referenced by the other variable. 
It is said that value types are stored on a stack and reference types are stored on a heap. It is not exactly true, as for example every static variable is stored on the heap, regardless of whether it's declared within a reference type or a value type (see sources)

We may think about reference type difference and value type as a different pieces of papers. Value type is a piece that have the information directly on it for example ‘10’ number written or ‘false’ logic state. Reference type in such analogy would be a piece with a directions to information like for example URL link to the website.

This analogy triggers some good understanding of value and reference types differences. Firstly, if we make a copy of paper with ‘10’ on it and change something in a first copy that will not affect the second copy. On the other hand, if we change something in the website, it will affect information handled in all of the URL paper copies that refers to it. Secondly, a copy of URL address (a reference) is just a reference so it contains less information than a copy of a paper with data like number ‘10’ which is a copy of pure information. Finally, if a reference copy itself is changed (letters in URL mixed for example) it does not change the information itself (website) nor the other reference copies (other URLs).

The class ‘ReferenceAndValueClass’ shows that concept. It uses ‘PrintedPage’ struct (value type) and ’WebPage’ class (reference type) to show the differences described above. At the bottom are the bodies of struct and class mentioned above. In ‘ReferenceAndValueClass’ we have ‘ShowTheDifference()’ method. In first lines of it value type ‘originalPrintedPage’ is created than copied and changed. We see by printing the original value variable, that the information in it is unchanged. The second part of code does the same steps but with reference type. Here we see the information is unchanged, although when we make an instance of the copy (last lines) the new value assigned does not affect the original state (analogy with changing a URL rather than website itself) 

It is important to remember:
If x is a variable and its type is a reference type, then changing the value of x is not the same as changing the data in the object which the value of x refers to.

Source:
https://jonskeet.uk/csharp/references.html
https://jonskeet.uk/csharp/memory.html

