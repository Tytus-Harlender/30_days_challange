using System;
using System.Collections.Generic;
using System.Text;

namespace Day8
{
    class NullableValueClass
    {
        public void ShowNullableExample()
        {

            int? nullableInt;
            Nullable<int> nullableIntTwo = null;
            int? a = 5;

            if (a.HasValue)
            {
                Console.WriteLine($"a is {a.Value}");
            }
            else
            {
                Console.WriteLine("a does not have a value");
            }


        }

    }
}