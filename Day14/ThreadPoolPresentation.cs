using System;
using System.Threading;

namespace Day14
{
    public class ThreadPoolPresentation
    {
        public static void BackgroundTask(Object stateInfo)
        {
            Console.WriteLine("Hello! I'm a worker from ThreadPool");
            Thread.Sleep(1000);
        }

        public static void PresentThreadPool()
        {
            ThreadPool.QueueUserWorkItem(BackgroundTask);
            Console.WriteLine("Main thread does some work, then sleeps.");
            Thread.Sleep(500);
            Console.WriteLine("Main thread exits.");
            Console.ReadKey();

        }
    }
}
