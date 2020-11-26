using System;
using System.Collections;
using System.Text;

namespace Day2
{
    class Example2_1
    {

        public static void CreateQueue()
        {

            Queue myQue = new Queue();

            myQue.Enqueue("first written");
            myQue.Enqueue("second written");
            myQue.Enqueue("third written");

            PrintValues(myQue);
        }

        public static void CreateStack()
        {
            Stack myStack = new Stack();

            myStack.Push("first written");
            myStack.Push("second written");
            myStack.Push("third written");


            PrintValues(myStack);

        }



        public static void PrintValues(IEnumerable myCollection)
        {
            foreach (Object obj in myCollection)
                Console.Write("    {0}", obj);
            Console.WriteLine();
        }
    }
}
