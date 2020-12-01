using System;
using System.Collections.Generic;
using System.Text;

namespace Day3
{
    class WillHideYou : HideMe
    {


        new public static int x = 100;

        public static void ShowResult()
        {
           
            Console.WriteLine(x);

            Console.WriteLine(HideMe.x);

            Console.WriteLine(y);
        }
    }
}
