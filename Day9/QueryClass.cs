using System;
using System.Linq;

namespace Day9
{
    class QueryClass
    {
        private static int[] _numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

        static void ShowQueryExample()
        {
            var numQuery =
                from num in _numbers
                where (num % 2) == 0
                select num;

            foreach (int num in numQuery)
            {
                Console.Write("{0,1} ", num);
            }

        }

        public static void ShowMethodSyntaxExample()
        {

            var query = _numbers.Where(number => number>3);

            foreach (var numberChosen in query)
            {
                Console.WriteLine("Number chosen is"+numberChosen);
            }



        }
    }
}
