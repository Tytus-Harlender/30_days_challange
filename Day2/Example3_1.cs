using System;
using System.Collections;
using System.Text;

namespace Day2
{
    class Example3_1
    {

        public static void CreateArray()
        {
            // Creates and initializes a new ArrayList.
            ArrayList myArray = new ArrayList();
            myArray.Add("we");
            myArray.Add("are");
            myArray.Add("here");

            Example2_1.PrintValues(myArray);

        }
    }
}
