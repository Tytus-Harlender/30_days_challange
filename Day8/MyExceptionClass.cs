using System;
using System.Collections.Generic;
using System.Text;

namespace Day8
{
    class MyExceptionClass : Exception
    {
        public MyExceptionClass(string str)
        {
            Console.WriteLine("User defined exception");
        }
    }
}
