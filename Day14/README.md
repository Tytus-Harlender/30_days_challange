Day14

Threading - Asynchronicity

1. Threading

 Threading is the idea of separating the tasks into several processes (threads) during programm execution.
A commonly followed rule is to create max 2 threads per each core of our processor. 
 
 
 In the Main() method of Program.cs we may see some examples of threads creation.
Generally the Main() method is the entry point of the app and running the program creates the main background thread.
All the other threads created are foreground threads.
During thread creation we need to pass the method that will be executed within it.

For example 'workerThread' is responsible for executing method Print() from the class Printer.cs.
Since it is static method there is no need for creating the instance of a class before passing the method to the thread.

On the other hand, PrinterJob() is not static method, thus it needs an instance of the printer class one line before printerThread creation.
Moreover as the method need some object data input, during using build-in 'Start' method for initiating the thread we pass some object (in this cas "Some data" string).

Same situation goes with thread 'workThread2', however here we pass an instance of the custom design class 'Person' (having three properties) instead of string.

The last part of the Main() programm is to print the parameters of the current thread in the console.

T.B.C. with:
Thread pools 


sources:
- https://www.c-sharpcorner.com/article/Threads-in-CSharp/
- https://www.geeksforgeeks.org/how-to-create-threads-in-c-sharp/
- https://docs.microsoft.com/en-us/dotnet/api/system.threading.thread?view=net-6.0

3. Asynchronicity
