# Day 9 


1. What is LINQ? What methods it has? How to use them?
2. How do we use the keyword ‘namespace’?
3. What is an ‘enum’?
4. What is a ‘singleton’? When to use it?
5. What is a ‘nuget’? How to use it?

1.	LINQ – definition, methods, usage

LINQ stands for Language Integrated Query. It is a set of technologies in C# which needs introduction of ‘query’ concept for better understanding. A ‘query’ is a set of instructions that let as get data from different data storages as a SQL database, XML file and a collection from System.Collection namespaces (described in Day1).

Queries let us retrieve data from above places with describing which data we want to get and how should they be listed. A query expression has a certain form. ‘From’ and ’select/group’ clauses shows the beginning and ending of the query. Introducing a ‘query variable’ here should be useful. A ‘query variable’ is any variable that stores a query instead of the results of a query. It means that creating a query is not even to executing the query. So in LINQ the execution of the query is distinct from the query itself. In other words, you have not retrieved any data just by creating a query variable. It might have started to sound confusing so far, so “QueryClass” should help with better understanding of queries. We may see a method called ShowQueryExample() which executes three basic query steps. Firstly, it creates an array of int variables called numbers. That will be our little database to execute the query on. Then we declare query variable ‘numQuery’	which will store the query (not a result of it). The declaration of a query consist of three parts ‘from’ (from what we retrieve data), ‘where’ (which data we want to retrieve) and ‘select’ clauses. The last step of the method is a executing the query and obtaining the result (if query is an ask, this is an answer) with foreach loop.

The above example is created with so-called query syntax. There is also a method syntax for queries and the combination of both. It is recommended to use query syntax wherever possible because it is more readable and concise. Therefore query operations should be used only when necessary (Some query operations, such as Count or Max, have no equivalent query expression clause and must therefore be expressed as a method call.) For a developer who writes queries, the most visible "language-integrated" part of LINQ is the query expression discussed above.

Method syntax is show in ShowMethodSyntaxExample() method. It uses lambda expressions (=>) and methods to form a query. We may see a ‘Where()’ method used to get the numbers greater than 3 form the array.

Here are listed popular query operations: 

-ordering :
sorts the elements of a sequence in ascending order according to a key. The key is a member of the ordering database for example age of a pet. Example: var query = pets.OrderBy(pet => pet.Age);

-grouping :
groups the elements of a sequence. Following the above example with pets we may group them by age. We use age as a key value and select only the pet's Name for each value. 
Example: ‘var  query = pets.GroupBy(pet => pet.Age, pet => pet.Name);

-joining :
It correlates the elements of two sequences based on matching keys. We may create a list of Person-Pet pairs where each element is an anonymous type that contains a  Pet's name and the name of the Person that owns the Pet. 
Example:
var query = people.Join(pets, person => person, pet => pet.Owner,
                    (person, pet) =>
                        new { OwnerName = person.Name, Pet = pet.Name });
-selecting:
Projects each element of a sequence into a new form. ‘new’ keyword is used. It is basic method used at the ends of queries.
Example:
var query = fruits.Select((fruit, index) =>
                      new { index, str = fruit.Substring(0, index) });

-distinct:
Returns distinct elements from a sequence by comparing values and omitting those which repeat in a collection. We may get only the range of ages that are present without information how much pets share the same age.
Example:
var distinctAges = ages.Distinct();

-first or default:
It returns the first element of a sequence, or a default value if no element is found.
Example:
List<int> months = new List<int> { };
int firstMonth1 = months.FirstOrDefault();



Sources:
https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/introduction-to-linq-queries
https://cezarywalenciuk.pl/blog/programing/linq-wybieranie-i-grupowanie-z-kolekcji-prosty-przykad
https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/



2.	Namespace keyword

	‘Namespace’ keyword is used to declare a scope of objects. It is useful when we have to deal with a large amount of classes for example within some share a relation with each other. Such related classes we may summon up to one namespace for better organization. Classes are not only objects that can be nested in namespace. All of such ‘objects’ are: Another namespace, Class, Interface, Enum, Delegate, Struct.
In ‘NamespaceDeclarationClass’ we may see a declaration of each of the above. It is worth mentioning that we may not have two classes with the same name within one namespace, but we may have such in two different namespaces. Namespaces have public modifiers and it is not modifiable.
To use a declared or built-in .NET namespace in our program we use ‘using’ (as using directive) keyword at the very beginning of it. It gives us ability to use object within ‘used’ namespaces. We may ad ‘static’ keyword to the ‘using’. This is using static directive. It indicates that in a following namespace static members and nested types you can access without specifying a type name. For example writing ‘using static System.Console;’ will let us use ‘WriteLine()’ method directly without a Console in front of it.

Apart from mentioned above with using namespaces, there is an usage called using statement. This statement is similar in look to the method declaration and is used to tell when to deconstruct an object after its task completion so it may release some space in memory without need for garbage collector usage. We may see it in ‘UsingStatementExample’ class. After ‘using’ we declare the object in round brackets which will be destructed, then in moustache brackets we define what operations should be done. After leaving the braces, the object is destructed and it gives back an access to the information it worked on.
For example, in our method “ReadTheLines()” we first declare a string to work on called ‘manyLines’. Then goes using statement. We create a ‘reader’ which is an instance of StringReader class used to read the string files. The reader then is used in the body of the statement to loop through the lines. When the loop ends we exit the using statement. Then access to ‘manyLines’ string we worked on is given back to other methods in the program and the ‘reader’ itself is destructed to make more space in the memory.
We may also use several using declarations for one statement in a row. This example is shown in ReadTheLines() method at the end. We use two using declaration instancing two constructors (thy may be different ones). Note that one object is passed to another in the following using declaration (‘sb’ passed to ‘sw’ as ‘sb.ReadLine()’)

When to use ‘using statement’?
Usually for classes that require cleaning up after them, like IO




source:
https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/namespace
https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using-static
https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using-statement
https://stackoverflow.com/questions/9396064/using-statement-with-multiple-variables



3.	Enum

‘Enum’ refers to the enum class. It provides the base class for enumerations. This class implements IComparable IConvertible and IFormattable interfaces.

Enumeration type is a value type and it is a set of related constants like for example days of the week, seasons, months, colours and so on. We create such type by using enum keyword and passing the names of the set of constants. By default each name has an int type and value starting from 0 with the first name and ascending. We may assign different int values if we want. The idea of enum type is to present a set of integers with names so we may for example loop through the names by ints. The idea is  The example od enumeration is shown in EnumerationClass.

In this class we create two enums. One with dedfault ints and second with defined int values. Then we create two methods that may loop through these enums. First will print in the console the names of the months. The second will print the ints assigned to the members names. In both cases we first create an array of the values from enums by Enum.GetValues() method and then loop through this array. Note that in the first case we cast the values to the Months type to have the names of the months printed instead of the numbers.

When to use?

Whenever a procedure accepts a limited set of variables, consider using an enumeration. Enumerations make for clearer and more readable code, particularly when meaningful names are used.

Source:
https://docs.microsoft.com/en-us/dotnet/visual-basic/programming-guide/language-features/constants-enums/when-to-use-an-enumeration
https://stackoverflow.com/questions/3519429/what-is-main-use-of-enumeration



4.	Singleton – definition, terms of use 

	It is a design pattern that is used to prevent a class from creating its instance more than once. In other words, it is a design pattern which by use of static method Instance() always returns the same object. It can be used as an access point to database or printer. By doing so we provide secure access with one connection instead of creating several connections at once.
The example of singleton usage may be seen in SingletonClass. Within this class we may see three members. A private field that represents our connection to a database or printer. A method SingletonClass() that is a constructor for new connection and a GiveMeConnection() method which is static and public since we need to make sure we can invoke it several times in the thread of our application without creating an instance. By doing so, it will check if the connection is already created. If not, it will create a new one and return the connection. Therefore, we will have just one creation of the connection and only at the moment when its needed in the application, not at the beginning of compilation (as we would have with static classes).

Source:
https://cezarywalenciuk.pl/blog/programing/wzorce-projektowe-c--singleton

5.	Nuget

Nuget is a mechanism in .NET to create, host and share packages of code. Such packages are called nupackages and may be downloaded from the cloud to the IDE for supporting the program we create. They contain compiled code in DLL format. To download a package we right click on a project name and choose -> Manage NuGet packages -> Browse ->Install
Then we may include downloaded code by using ‘using’ keyword for the namespace at the beginning, the nuget packages used by the project are also seen in the project tree in the ‘Dependencies’.

Source:
https://docs.microsoft.com/en-us/nuget/what-is-nuget

