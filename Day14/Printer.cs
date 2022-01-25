using System;
using System.Threading;

namespace Day14
{
    public class Printer
    {
        public static void Print()
        {

            /// <summary>  
            ///  This code is executed by a secondary thread  
            /// </summary>
            /// 
            for (int i = 11; i < 20; i++)
            {
                Console.WriteLine($"Worker thread: {i}");
                Thread.Sleep(1000);
            }
        }

        public void PrintJob(object data)
        {
            Console.WriteLine("Background PrintJob started.");
            Thread.Sleep(1000);
            Console.WriteLine("PrintJob still printing...");
            Console.WriteLine($"Data: {data}");
            Thread.Sleep(1000);
            Console.WriteLine("PrintJob finished.");
        }

        public void PrintPerson(object data)
        {
            Console.WriteLine("Background PrintPerson started.");
            Thread.Sleep(1000);
            Console.WriteLine("PrintPerson still printing...");
            Person p = (Person)data;
            Console.WriteLine($"Person {p.Name} is a {p.Sex} of {p.Age} age.");
            Thread.Sleep(1000);
            Console.WriteLine("PrintPerson finished.");
        }
    }
}
