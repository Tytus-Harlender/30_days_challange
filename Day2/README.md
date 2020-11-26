Collection – it is a group of objects. Collections are used to manage the program data and to make it more concise – to organize it. They are created using already .NET-prepared namespaces of classes with various functions. The most commonly used namespaces are:
System.Collections.Generic
System.Collections.Concurrent
System.Collections
NOTE: There is a possibility to create your own class as a collection type
Each of the consist of different collection types as:
- Lists, Queries, Stacks, Dictionaries, Bags etc.

Here are some examples of hand-on collections applications:
System.Collections.Generic – used to enforce strong typing and protect the collection of adding objects of not willing 

Example1.1 one shows how to use an example of Generics Class (List<T>) from System.Collections.Generic namespace in C#. A list of cars is created and then displayed. Note that all of them have the same type – ‘string’. We see this collections prevent from adding any different data type. However we may define the car not as a chain of letters, but as an object. It gives us possibility to define its properties apart from name!
Example1.2 – if we want to create a group of objects we may define a class and later create a list of its instances. That is presented in class Example1.2

System.Collections.Concurrent – enables thread safe operations for accessing collection from multiple threads, used whenever multiple threads are accessing the collection concurrently

Example2.1 shows to use an example of Concurrent Class from Concurrent Classes System.Collections.Concurrent Classes

System.Collections - do not store elements as specifically typed objects, but as objects of type ‘Object’, may be used when our language does not support generics. We may use List instead of List<T> class.


The implementation tree
All Collections implement directly or indirectly from ICollection.  IList interface and the IDictionary interface are both derived from the ICollection interface. These three interfaces are foundation that the rest of collections types are based on.





Sources:
Collections in general - https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/collections

Interafaces implementation paths and when to use which namespace: - https://docs.microsoft.com/en-us/dotnet/standard/collections/commonly-used-collection-types

Thread safety - https://www.c-sharpcorner.com/UploadFile/1c8574/thread-safety369/
		https://docs.microsoft.com/en-us/dotnet/standard/collections/thread-safe/

