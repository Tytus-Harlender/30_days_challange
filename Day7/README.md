#Day7




StringBuilder - cache - garbage collector,

1.	StringBuilder class

StringBuilder class lets us create an object for storing and modifying a chain of signs. In the contrary to widly-known ‘string’ class, this class does not create a copy of an object when modifying its content.
Lets take a look in StringBuilderExample class. Instead of creating a wide array of copies with string object in StringExample(), we create one object of StringBuilder type and use AppendLine() commend to add next lines of text. At the end we convert the whole content to string.
Why do we use it?
We use it not to have a wide array of useless string object created, which would need to be removed by garbage collector.

Source:
https://cezarywalenciuk.pl/blog/programing/stringbuilder-c-i-net-40-operacje-na-napisach-05

2.	Cache

Cache Memory is a special very high-speed memory. It is used to speed up and synchronizing with high-speed CPU. Cache memory is an extremely fast memory type that acts as a buffer between RAM and the CPU. It holds frequently requested data and instructions so that they are immediately available to the CPU when needed.

Cache memory is used to reduce the average time to access data from the Main memory. The cache is a smaller and faster and stores copies of the data from frequently used main memory locations. There are various different independent caches in a CPU, which store instructions and data.

Source:
https://www.geeksforgeeks.org/cache-memory-in-computer-organization/

3.	Garbage Collector (GC)

In the common language runtime (CLR), the garbage collector (GC) serves as an automatic memory manager. The garbage collector manages the allocation and release of memory for an application. For developers working with managed code, this means that you don't have to write code to perform memory management tasks. Automatic memory management can eliminate common problems, such as forgetting to free an object and causing a memory leak or attempting to access memory for an object that's already been freed. GC runs regularly during the program execution.
However, GC.Collect() method is used to manually begin collection of garbage within the program.

Source:
https://docs.microsoft.com/en-us/dotnet/api/system.gc.collect?view=net-5.0
https://docs.microsoft.com/en-us/dotnet/standard/garbage-collection/fundamentals
