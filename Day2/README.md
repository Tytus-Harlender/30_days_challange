# Day 2

collections – terms of usage – interfaces implemented by collections - List, Queue, stack,Array
missing: ienumerable or iquerably, directory
time:3,5h

Collection – it is a group of objects. Collections are used to manage the program data and to make it more concise – to organize it. They are created using already .NET-prepared namespaces of classes with various functions. The most commonly used namespaces are:
System.Collections.Generic
System.Collections.Concurrent
System.Collections
NOTE: There is a possibility to create your own class as a collection type
Each of the consist of different collection types as:
- Lists, Queries, Stacks, Dictionaries, Bags etc.

Here are some examples of hand-on collections applications:
System.Collections.Generic – used to enforce strong typing and protect the collection of adding objects of not willing 

Example1.1 one shows how to use an example of Generics Class (List<T>) from System.Collections.Generic namespace in C#. List<T> (generics) Represents a strongly typed list of objects that can be accessed by index. Provides methods to search, sort, and manipulate lists. A list of cars is created and then displayed. Note that all of them have the same type – ‘string’. We see this collections prevent from adding any different data type. However we may define the car not as a chain of letters, but as an object. It gives us possibility to define its properties apart from name!
Example1.2 – if we want to create a group of objects we may define a class and later create a list of its instances. That is presented in class Example1.2

System.Collections.Concurrent – enables thread safe operations for accessing collection from multiple threads, used whenever multiple threads are accessing the collection concurrently

Example2.1 shows to use an example of the Queue class creating method and then printing the values with the proper sequence, as Objects stored in a Queue are inserted at one end and removed from the other. We call it FIFO style (First In, First Out). Another example of concurrent class is stack. It works in a way of last-in-first-out (LIFO) style. So it will print the objects backwards from the way the were assigned (so exactly the opposite to the Queue class)
Stack implements ICloneable, System.Collections.ICollection interfaces
Queue implements ICloneable, System.Collections.Icollection interfaces.

There is also Array class, which provides methods for creating, manipulating, searching, and sorting arrays, thereby serving as the base class for all arrays in the common language runtime.. 
Array implements ICloneable, System.Collections.IList, System.Collections.IStructuralComparable, System.Collections.IStructuralEquatable interfaces

System.Collections - do not store elements as specifically typed objects, but as objects of type ‘Object’, may be used when our language does not support generics. We may use List instead of List<T> class.

The implementation tree
All Collections implement directly or indirectly from ICollection.  IList interface and the IDictionary interface are both derived from the ICollection interface. These three interfaces are foundation that the rest of collections types are based on. Array, ArrayList, or List<T> types implement IList. Queue, ConcurrentQueue<T>, Stack, ConcurrentStack<T>, or LinkedList<T> types implement Icollection directly. Every element in this types contains only a value.
The Hashtable and SortedList classes, the Dictionary<TKey,TValue> and SortedList<TKey,TValue> generic classes implement IDictionary interface. Every element in these types contains both a key and a value.





Sources:

Collections in general - https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/collections
Interafaces implementation paths and when to use which namespace: - https://docs.microsoft.com/en-us/dotnet/standard/collections/commonly-used-collection-types

Thread safety - https://www.c-sharpcorner.com/UploadFile/1c8574/thread-safety369/
		https://docs.microsoft.com/en-us/dotnet/standard/collections/thread-safe/


