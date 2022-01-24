using System;
using System.Threading;

namespace Day14
{
    class Program
    {
        static void Main()
        {
            // Create a secondary thread by passing a ThreadStart delegate  
            Thread workerThread = new Thread(new ThreadStart(Print));
            // Start secondary thread  
            workerThread.Start();

            // Main thread : Print 1 to 10 every 0.2 second.   
            // Thread.Sleep method is responsible for making the current thread sleep  
            // in milliseconds. During its sleep, a thread does nothing.  
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Main thread: {i}");
                Thread.Sleep(200);
            }

            Console.ReadKey();
        }

        /// <summary>  
        ///  This code is executed by a secondary thread  
        /// </summary>  
        static void Print()
        {
            for (int i = 11; i < 20; i++)
            {
                Console.WriteLine($"Worker thread: {i}");
                Thread.Sleep(1000);


                //returns the current thread that is executing the code
                Thread currentThread = Thread.CurrentThread;
                Console.WriteLine("Thread Id {0}: ", currentThread.ManagedThreadId);
                Console.WriteLine("Is thread background: {0}", currentThread.IsBackground);
                Console.WriteLine("Priority: {0}", currentThread.Priority);
                Console.WriteLine("Culture: {0}", currentThread.CurrentCulture.Name);
                Console.WriteLine("UI Culture: {0}", currentThread.CurrentUICulture.Name);
                Console.WriteLine();
            }
        }
    }
}
