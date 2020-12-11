using System;


namespace Day8
{
    class StackOverflowClass
    {
        static void Recursive(int value)
        {
            Console.WriteLine(value);
            Recursive(++value);
        }

        static void OverflowStack()
        {
           
            Recursive(0);
        }



    }
}
