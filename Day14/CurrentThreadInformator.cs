using System;
using System.Threading;


namespace Day14
{
    public static class CurrentThreadInformator
    {
        public static void PrintCurrentThreadInfo()
        {
            //returns the current thread that is executing the code
            Thread currentThread = Thread.CurrentThread;
            Console.WriteLine("Thread Id {0}: ", currentThread.ManagedThreadId);
            Console.WriteLine("Is thread background: {0}", currentThread.IsBackground);
            Console.WriteLine("Priority: {0}", currentThread.Priority);
            Console.WriteLine("Culture: {0}", currentThread.CurrentCulture.Name);
            Console.WriteLine("UI Culture: {0}", currentThread.CurrentUICulture.Name);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
