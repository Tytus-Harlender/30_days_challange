#Day7



StringBuilder - reference&valuetype – out ref - cache - garbage collector,

1.	StringBuilder class

StringBuilder class lets us create an object for storing and modifying a chain of signs. In the contrary to widly-known ‘string’ class, this class does not create a copy of an object when modifying its content.
Lets take a look in StringBuilderExample class. Instead of creating a wide array of copies with string object in StringExample(), we create one object of StringBuilder type and use AppendLine() commend to add next lines of text. At the end we convert the whole content to string.
Why do we use it?
We use it not to have a wide array of useless string object created, which would need to be removed by garbage collector.

Source:
https://cezarywalenciuk.pl/blog/programing/stringbuilder-c-i-net-40-operacje-na-napisach-05

