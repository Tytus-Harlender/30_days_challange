
using System;

namespace Day12
{
    public class NotGenericPrinter
    {
        public void Print<T>(T data)
        {
            Console.WriteLine(data);
        }
    }
}
