#Day3

Usage of keywords private, public, internal, namespace, new, override, static, new (2 zastosowania słowa new poproszę), ref, out, var, break, yeld


Keywords or Reserved words are the words in a language that are used for some internal process or represent some predefined actions. These words are therefore not allowed to use as variable names or objects. Doing this will result in a compile-time error (unless they include @ as a prefix. For example, @if is a valid identifier, but if is not because if is a keyword). 
There are 78 keywords in C# and are mainly divided into 10 categories as follows:
-	15 value type keywords (bool, double, char, int etc.)
-	6 reference type keywords (class, delegate, interface, object, string, void)
-	17 modifiers keywords (public, private, abstract, internal, new etc.)
-	18 statement keywords (if, foreach, while, break, do etc.)
-	4 method parameters keywords (params, in, ref, out)
-	3 namespace keywords (namespace, using, extern)
-	8 operator keywords (as, is, new, sizeof, typeof, true, false, stackalloc)
-	3 conversion keywords (explicit, implicit, operator)
-	2 access keywords (base, this)
-	2 literal keywords (null, default)

A separate group are Contextual Keywords. These are used to give a specific meaning in the program. Whenever a new keyword comes in C#, it is added to the contextual keywords, not in the keyword category. This helps to avoid the crashing of programs which are written in earlier version. They are no restricted and may have different meaning based on the application of them. There are 30 contextual keywords (var, remove, add, value etc).




Here we will focus on the following keywords:
private, public, internal, new, override, static (modifiers) namespace (namespace) ref, out (method parameters) var, yield (contextual keywords) break (statements)

public 

It is the most liberal access modifier for types and types members like classes, methods, properties etc. Such modifier tells that the type may be accessed freely by the thread. No restrictions in accessibility


Internal

Another access modifier keyword. Internal types or members are accessible only within files in the same assembly. Assembly is implemented as .dll or .exe file.

Private

It is another access modifier. It restricts the type (class, method) to be accessed only by the types within the same superior type. For example if a method is a private method in a class it may be only used by methods that are within this class, not external methods.
 
Note: In c#, we are not allowed to use any access modifiers on namespaces, because the namespaces have no access restrictions.

In our program ‘Bank’ class represents the idea of private and public elements of a class. We may print the name of the created bank and it’s invitation phrase, but we cannot print it’s total money amount because it is a private field.

New

https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new-modifier

There are three possible ‘new’ keyword meanings in C#. It may be used to hide a member that is inherited from a base class(‘new’ modifier) as well as to create an instance of a type (‘new’ as operator) or as a member declaration modifier (‘new’ as constrain)
We may see an example of ‘new’ keyword usage to hide a member in classes ‘HideMe’ and ‘WillHideYou’. The x value is hidden and a new value of this field is assigned. We then have two values of x (hidden and new value of it) and one value of y (unhidden) printed in the console.
Another usage of ‘new’ keyword is to create an instance of an object. An example of this operation is stated in the ‘Program.cs’ class in line 10:
Bank myBank = new Bank("Imaginary Investments", 500000);
New keyword indicates that we create a new instance of the object Bank that will be called ‘myBank’.
The third usage of ‘new’as constraint type specifies that a type argument in a generic class declaration must have a public parameterless constructor. It is not shown here.





Override

This modifier is required to extend or modify the abstract implementation of an inherited method, property, indexer, or event. When an abstract class is implemented, its abstract types need to be overridden by this modifier. You cannot override a non-virtual or static method. Both abstract method and the one that overrides it needs to have same access level modifier. You cannot use the new, static, or virtual modifiers to modify an override method.

Such example was shown in Day1 when discussing abstract classes.

Static

This modifier is used to declare a static member, which belongs to the type itself rather than to a specific object. A static member can't be referenced through an instance. Instead, it's referenced through the type name. While an instance of a class contains a separate copy of all instance fields of the class, there's only one copy of each static field. It may be useful when we want to prevent the usage of a class from creating plenty of instances, while only a one quick method is required and later the instances would be lasting in vain. On the other hand, when the number of parameters input to the invocation (call) of the class enlarge, we may find using a non-static class better. Using a static one in such case would trigger the need for many overloads definition. Static methods are mostly used in utility classes. Another case worth considering is class filled only with methods.
 If the static keyword is applied to a class, all the members of the class must be static.
More:
https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/static
https://stackoverflow.com/questions/205689/class-with-single-method-best-approach

The class ‘SomeFunctionality’ pictures the idea behind the static keyword. It is a static class, then it consists of only static methods. They are all public so may be easily accessed outside the class. Since we have only methods within the class and they held some specific set of functionalities to the program, then we do not need to create instances each time we need to use them. It is far simpler in use as we just call the proper method by name in ‘Program.cs’


Ref, out

- both used for passing reference
The out is a keyword in C# which is used for the passing the arguments to methods as a reference type. It is generally used when a method returns multiple values. The out parameter does not pass the property.
Class ‘QuickReturn’ shows us the usage of a out keyword. The variable L is changed in the method and then given back out to be assigned again. 
Note: ref does not use the same variable name in method
The ref is a keyword in C# which is used for the passing the arguments by a reference. Or we can say that if any changes made in this argument in the method will reflect in that variable when the control return to the calling method. The ref parameter does not pass the property.
Class ‘PassportVerification’ shows us the usage of a ref keyword. The variable str is changed from the method as it was passed as a reference. 
More:
https://www.geeksforgeeks.org/difference-between-ref-and-out-keywords-in-c-sharp/?ref=rp


break

In C#, the break statement is used to terminate a loop(for, if, while, etc.) or a switch statement on a certain condition. And after terminating the controls will pass to the statements that present after the break statement, if available. If the break statement exists in the nested loop, then it will terminate only those loops which contain the break statements.

More:
https://www.geeksforgeeks.org/c-break-statement/?ref=rp

var

Used to let the complier quess the type of the following variable.An implicitly typed local variable is strongly typed just as if you had declared the type yourself, but the compiler determines the type. VarAndYeldClass.UseVar() method shows the usage. Both declarations mean the same in the end


yield

When you use the yield contextual keyword in a statement, you indicate that the method, operator, or get accessor in which it appears is an iterator
