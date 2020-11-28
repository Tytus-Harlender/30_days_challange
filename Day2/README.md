#Day2
collections – terms of usage – interfaces implemented by collections - List, Array - Queue, Stack -  Dictionary - ienumerable vs iquerably

Collection – it is a group of objects. Collections are used to manage the objects in the program and to perform various operations on them like to store, update, delete, retrieve, search, sort etc. They are created using already .NET namespaces. The most commonly used namespaces are:

System.Collections.Generic – used to enforce strong typing and protect the collection of adding objects of not willing type
System.Collections.Concurrent – enables thread safe operations for accessing collection from multiple threads, used whenever multiple threads are accessing the collection concurrently
System.Collections - do not store elements as specifically typed objects, but as objects of type ‘Object’. It may be used when our language does not support generics, but it is rather rarely used in modern .NET development

Since .NET later releases started to use type-safety in programs System.Collections.Generic is the most widely used namespace for Collections. Unless you don’t need to prevent problems concerning multiple threads access, that is a namespace to use. Otherwise, for multiple thread safety ‘System.Collections.Concurrent’ should be used. 

Within the namespaces we have a classes to be used as a collection. The most common are - List, Array - Queue, Stack -  Dictionary types. Let’s take a look what are those.

Here are some examples of different types of collections:

Example1.1  (List<T> : IList<T>, System.Collections.IList, IReadOnlyList<T>)
	
This example shows how to use an example of generics class List<T> from System.Collections.Generic namespace in C#. List<T> (note the ‘<T>’ which mean it is a generic) represents a strongly typed list of objects that can be accessed by index. A list of cars is created in the example and then displayed (note that all of them have the same type – ‘string’, since generics prevent from adding any different data type then defined for collection).
We may see methods for adding new elements and removing them. There is a method to insert range of strings in a particular point in the list. Both the number of elements and each element can be displayed.
What is specific for List<T> is that it may be enlarged by adding new elements thanks to the method ‘cars.Add’. It is something that cannot be done within Arrays. List<T> implements the generic IEnumerable<T> interface and can be used easily in LINQ (‘Language Integrated Query’we will describe it further).

Example1.2 (Array : ICloneable, IList, IStructuralComparable, IStructuralEquatable) 

This example shows how to create an Array in two ways and to present its length. Then we have a method Array.IndexOf() to find an index of a certain value in the Array. Note that it returns only one index if the values repeats as in the example (differs from Dicitonary class). It returns ‘0’ if no elements is found (‘banana’). Array is fixed in size once it is allocated. We cannot add items to it or remove items from it. However, is more efficient then List, both in terms of memory and performance. Moreover, it supports multiple dimensions while List do not. NOTE: Arrays start counting the index from 0.

List and Array : comparison, when to use ?
Lists are used more often in C# than arrays are, but there are some instances where arrays can (or should) be used. That includes if your data is unlikely to grow very much or if you’re dealing with a relatively large amount of data that will need to be indexed into often.
Both List<T> and Array implement the IEnumerable interface for us automatically. This allows us to use arrays with LINQ extension methods, or pass arrays to methods that receive IEnumerable. Methods that receive IEnumerable usage lets us use foreach loop for searching through both Arrays and Lists<T>. It is shown in the example with Display() method.

Example2.1 Queue and Stack

Stack : ICollection, ICloneable
Queue : ICollection, ICloneable
This example shows the use of the Queue and Stack classes. There are two methods presenting the creation of each. Then we may see a method having the same function and implementation as in previous example with Array. It prints the values with the proper sequence for both Queue and Stack. 
What is the difference between stack and queue?
Both Stack and Queue implements the same interfaces. However the difference is hidden in how they ‘accept’ and ‘give back’ elements. Objects stored in a Queue are inserted at one end and removed from the other. We call it FIFO style (First In, First Out). Another example of concurrent class is stack. It works in a way of last-in-first-out (LIFO) style. So it will print the objects backwards from the way the were assigned (so exactly the opposite to the Queue class). That is the difference. 





Example4 Dictionary<TKey,TValue>: IDictionary<TKey,TValue>, IDictionary, IReadOnlyDictionary<TKey, TValue>, ISerializable, IDeserializationCallback

This example shows an usage of Dictionary<TKey, TValue> class. It is possible to create a collection that will contain elements with assign identifier (called Key) which may be useful in searching through the collection. Such a collection is Dictionary<TKey,TValue>. Possibility of searching and changing Dictionary elements by Key is realized by the Item[TKey] property within the Dictionary. It’s use is presented in Example number 4. A Dictionary class cannot have two same keys, but it may have more then one the same values. As we may see in the example, the name of the participant at the first place may be easily found by it’s key.

When Dictionary<TKey, TValue> is better then Array and List?
Thanks to that each value has unique Key we may get to each value directly in the dictionary without need for searching through all of it as in Arrays and Lists. Thanks to that Dictionary may be more efficient and faster in such operations. Moreover, it may be useful when we have to lists of data that are related to each other and the first column of indexes have a special meaning besides just positional placement. For example list of people id and list of PIN of each of them.

The implementation tree
As was mentioned in the previous day, interfaces are fully abstract classes which may be implemented by the derived class. All of the collections types implement some interfaces. Each collection implements directly or indirectly from ICollection.  IList interface and the IDictionary interface are both derived from the ICollection interface. These three interfaces are foundation that the rest of collections types are based on. Array, ArrayList, or List<T> types implement IList. Queue, ConcurrentQueue<T>, Stack, ConcurrentStack<T>, or LinkedList<T> types implement Icollection directly. Every element in this types contains only a value.
The Hashtable and SortedList classes, the Dictionary<TKey,TValue> and SortedList<TKey,TValue> generic classes implement IDictionary interface. Every element in these types contains both a key and a value.

Sources:

Collections in general - https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/collections

List and arrays: https://www.dotnetperls.com/

Interafaces implementation paths and when to use which namespace: - https://docs.microsoft.com/en-us/dotnet/standard/collections/commonly-used-collection-types
https://referencesource.microsoft.com/

Thread safety - https://www.c-sharpcorner.com/UploadFile/1c8574/thread-safety369/
		https://docs.microsoft.com/en-us/dotnet/standard/collections/thread-safe/
