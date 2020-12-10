using System;

namespace Day8
{
    class ExceptionCatchExample
    {
        private int result;
        public int Result { get => result; set => result=value; }
        public ExceptionCatchExample()
        {
            Result = 0;
        }

        public void DivideTwoNumbers(int num1, int num2)
        {
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
            }
            finally
            {
                Console.WriteLine("Result: {0}", result);
            }
        }

        public static void ShowExceptionExample()
        {
            ExceptionCatchExample d = new ExceptionCatchExample();
            d.DivideTwoNumbers(25, 0);
            Console.ReadKey();
        }

    }
}
