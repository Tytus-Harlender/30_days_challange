using System;
using System.Collections.Generic;
using System.Text;


namespace Day2
{
    class Example1_2
    {



        public static void CreateMyArray()
        {
            string[] cars = new string[5];
            string[] cars2 = new string[] { "Polonez", "Audi", "VolksWagen", "Audi", "VolksWagen"};

            Console.WriteLine(cars.Length);
            Console.WriteLine(cars2.Length);


            Console.WriteLine(Array.IndexOf(cars2, "VolksWagen"));
            Console.WriteLine(Array.IndexOf(cars2, "banana"));

            Display(cars2);
            Display(cars);
        }

        static void Display(IEnumerable<string> names)
        {
            foreach (string name in names)
            {
                Console.WriteLine("IENUMERABLE: " + name);
            }
        }

    }
}
