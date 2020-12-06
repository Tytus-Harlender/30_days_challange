using System;

namespace Day5
{
    class OverloadingExample
    {
        public void PrintSomething(int something)
        {
            Console.WriteLine(something);
        }
        public void PrintSomething(double something)
        {
            Console.WriteLine(something);
        }

    }
}
