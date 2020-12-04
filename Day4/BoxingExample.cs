using System;

namespace Day4
{
    class BoxingExample
    {
        public void BoxingA()
        {   
            int a = 5;
            
            object o = a;

            a = 10;

            Console.WriteLine(a);
            Console.WriteLine(o);

            double e = 2.718281828459045;
            object o1 = e;
            object o2 = e;
            Console.WriteLine(o1 == o2);


        }

      
        

    }
}
