# Day 9 


1. What is LINQ? What methods it has? How to use them?
2. How do we use the keyword ‘namespace’?
3. What is an ‘enum’?
4. What is a ‘singleton’? When to use it?
5. What is a ‘nuget’? How to use it?

1.	LINQ – definition, methods, usage

LINQ stands for Language Integrated Query. It is a set of technologies in C# which needs introduction of ‘query’ concept for better understanding. A ‘query’ is a set of instructions that let as get data from different data storages as a SQL database, XML file and a collection from System.Collection namespaces (described in Day1). Queries let us retrieve data from above places with describing which data we want to get and how should they be listed. A query expression has a certain form. ‘From’ and ’select/group’ clauses shows the beginning and ending of the query. Introducing a ‘query variable’ here should be useful. A ‘query variable’ is any variable that stores a query instead of the results of a query. It means that creating a query is not even to executing the query. So in LINQ the execution of the query is distinct from the query itself. In other words, you have not retrieved any data just by creating a query variable. It might have started to sound confusing so far, so “QueryClass” should help with better understanding of queries. We may see a method called ShowQueryExample() which executes three basic query steps. Firstly, it creates an array of int variables called numbers. That will be our little database to execute the query on. Then we declare query variable ‘numQuery’	which will store the query (not a result of it). The declaration of a query consist of three parts ‘from’ (from what we retrieve data), ‘where’ (which data we want to retrieve) and ‘select’ clauses. The last step of the method is a executing the query and obtaining the result (if query is an ask, this is an answer) with foreach loop.

The above example is created with so-called query syntax. There is also a method syntax for queries and the combination of both. It is recommended to use query syntax wherever possible because it is more readable and concise. Therefore query operations should be used only when necessary (Some query operations, such as Count or Max, have no equivalent query expression clause and must therefore be expressed as a method call.) For a developer who writes queries, the most visible "language-integrated" part of LINQ is the query expression discussed above.

There are many query operations like ordering, grouping, joining and selecting

Worth-seeing also:

IQueryable Interface (Provides functionality to evaluate queries against a specific data source wherein the type of the data is not specified)

Method syntax vs query syntax

Sources:
https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/introduction-to-linq-queries
https://cezarywalenciuk.pl/blog/programing/linq-wybieranie-i-grupowanie-z-kolekcji-prosty-przykad
https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/

2.	Namespace keyword

	‘Namespace’ keyword is used to declare a scope of objects. It is useful when we have to deal with a large amount of classes for example within some share a relation with each other. Such related classes we may summon up to one namespace for better organization. Classes are not only objects that can be nested in namespace. All of such objects are listed below (some of them have not been discussed yet):
-	Another namespace
-	Class
-	Interface
-	Enum
-	Delegate
-	Struct
In ‘NamespaceDeclarationClass’ we may see a declaration of each of the above. It is worth mentioning that we may not have two classes with the same name within one namespace, but we may have such in two different namespaces. Namespaces have public modifiers and it is not modifiable.
To use a declared or built-in .NET namespace in our program we use ‘using’ (as using directive) keyword at the very beginning of it. It gives us ability to use object within ‘used’ namespaces. There are also two different usages of the ‘using’ keyword (using static directive and using statement)

Worth-seeing also:
- using static directive
- using statement

source:
https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/namespace

