using System;
using System.Collections.Generic;
using System.Text;

namespace Day4
{
    class UnboxingExample
    {
        public void UnboxingA()
        {
            int a = 5;

            object o = a;

            a = 10;
            int x = (int)o;

            Console.WriteLine(a);
            Console.WriteLine(o);
            Console.WriteLine(x);


        }
    }
}
