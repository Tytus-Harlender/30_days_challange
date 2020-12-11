#Day8
1.	Try-catch-finally. What is it and what is a usage of each keyword?
2.	How to create an exeption? What kind of exceptions usage do you know (3 examples)?
3.	What is a meaning of stackoverflow exeption?
4.	What are nullable types and what are its kinds?
5.	What is the difference between keywords: continue od break?

1.	Try-catch-finally

It is a sequance of code in C# which defines the procedure of fulfilling certain task which has a possibility for failure. It consists of three blocks of code. First one placed after ‘try’ defines the certain task we want to proceed with. ‘Catch’ part defines what should happen if the procedure will not be able to proceed. The last block called ‘finally’ is executed regardless the execution of catch block. It notifies whether the exception occurred or not. ‘ExceptionCatchExample’ class illustrates that usage. 

The example shows an exception that may occur during dividing operation when divider is equal ‘0’ (which is forbidden in math equations). We see that in try block we set the result as a quotient of two given numbers. In ‘catch’ block we may see catching the exception when the divider is equal to ‘0’. In round brackets the type of exception is given and ‘e’ stands for the exception reference. This block prints in the console the information about exception presence. The finally block prints in the console information about the result.


Source:
https://www.tutorialspoint.com/Try-Catch-Finally-in-Chash
https://www.c-sharpcorner.com/UploadFile/puranindia/try-catch-finally-in-C-Sharp/

2.	Exceptions – usage and creation

Exceptions are instances of Exception class or classes that derive from it. They represent errors that occur during application execution. There are built-in exception classes for different kinds of exceptions. However, it is also possible to create user-defined exception. Such example is illustrated in ‘MyExceptionClass’ class. We may see that there is a constructor defining the notification form for the new exception. In MyExceptionUsage.UseMyException() we may see an usage of the exception in try-catch statement

Source:
https://www.c-sharpcorner.com/article/exception-handling-in-C-Sharp/

3.	‘Stackoverflow exception’

StackOverflowException is a class that derives from Exception class described above. It is then an exception class and it handles the exception of overflown memory in stack. Stack is a place in memory where we store (in general, since it is not always true) value types.  Sometimes this place in memory is overflown with information and terminate the program execution. It happens mostly when we input some infinite recursive loops in the program. Such example we may see in ‘StackOverflowClass’. We may see that method Recursive() generates infinite loop of calls as it calls itself. Each method call frame (activation record) is kept on the stack memory separately. It generates infinite need for memory space in a stack, but it is limited, thus it generates an error. It is possible to overcome this problem by ‘tail recursion’ in which the space needed for program is constant.

Source:
https://www.dotnetperls.com/stackoverflowexception


