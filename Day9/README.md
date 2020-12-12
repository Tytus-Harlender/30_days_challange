# Day 9 


6. What is LINQ? What methods it has? How to use them?
7. How do we use the keyword ‘namespace’?
8. What is an ‘enum’?
9. What is a ‘singleton’? When to use it?
10. What is a ‘nuget’? How to use it?

1.	LINQ – definition, methods, usage

LINQ stands for Language Integrated Query. It is a set of technologies in C# which needs introduction of ‘query’ concept for better understanding. A ‘query’ is a set of instructions that let as get data from different data storages as a SQL database, XML file and a collection from System.Collection namespaces (described in Day1). Queries let us retrieve data from above places with describing which data we want to get and how should they be listed. A query expression has a certain form. ‘From’ and ’select/group’ clauses shows the beginning and ending of the query. Introducing a ‘query variable’ here should be useful. A ‘query variable’ is any variable that stores a query instead of the results of a query. It means that creating a query is not even to executing the query. So in LINQ the execution of the query is distinct from the query itself. In other words, you have not retrieved any data just by creating a query variable. It might have started to sound confusing so far, so “QueryClass” should help with better understanding of queries. We may see a method called ShowQueryExample() which executes three basic query steps. Firstly, it creates an array of int variables called numbers. That will be our little database to execute the query on. Then we declare query variable ‘numQuery’	which will store the query (not a result of it). The declaration of a query consist of three parts ‘from’ (from what we retrieve data), ‘where’ (which data we want to retrieve) and ‘select’ clauses. The last step of the method is a executing the query and obtaining the result (if query is an ask, this is an answer) with foreach loop.

The above example is created with so-called query syntax. There is also a method syntax for queries and the combination of both.


Source:
https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/introduction-to-linq-queries
https://cezarywalenciuk.pl/blog/programing/linq-wybieranie-i-grupowanie-z-kolekcji-prosty-przykad

