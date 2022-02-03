using System;
using System.Threading;

namespace Day14
{
    public class ThreadPoolPresentation
    {

        //TODO Maximum and Minimum Thread Pool Threads
        public static void PresentThreadPool()
        {
            ThreadPool.QueueUserWorkItem(BackgroundTask);
            Console.WriteLine("Main thread does some work, then sleeps.");
            Thread.Sleep(500);
            Console.WriteLine("Main thread exits.");
            Person p = new Person("Primo", "Male", 50);
            ThreadPool.QueueUserWorkItem(BackgroundTaskWithObject, p);
            Console.ReadKey();

        }
        public static void BackgroundTask(Object stateInfo)
        {
            Console.WriteLine("Hello! I'm a worker from ThreadPool");
            Thread.Sleep(1000);
        }

        static void BackgroundTaskWithObject(Object stateInfo)
        {
            Person data = (Person)stateInfo;
            Console.WriteLine($"Hi {data.Name} from ThreadPool.");
            Thread.Sleep(1000);
        }
    }
}
