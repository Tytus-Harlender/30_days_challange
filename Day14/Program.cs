using System;
using System.Threading;

namespace Day14
{
    class Program
    {
        static void Main()
        {
            // secondary thread
            Thread workerThread = new Thread(new ThreadStart(Printer.Print));
            workerThread.Start();
            
            // main thread  
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Main thread: {i}");
                Thread.Sleep(200);
            }


            // third thread  
            Printer p = new Printer();
            Thread printerThread = new Thread(p.PrintJob);
            printerThread.Start("Some data");


            // fourth thread (with object)
            Person stanislaw = new Person("Stanislaw Nugal", "Male",80 );
            Thread workerThread2 = new Thread(p.PrintPerson);
            workerThread2.Start(stanislaw);

            CurrentThreadInformator.PrintCurrentThreadInfo();
            ThreadPoolPresentation.PresentThreadPool();
            CurrentThreadInformator.PrintCurrentThreadInfo();

        }
    }
}
