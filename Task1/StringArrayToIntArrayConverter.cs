using System;

namespace Task1
{
    public class StringArrayToIntArrayConverter
    {
        private int[] intArray;
        public int[] IntArray { get =>intArray; set=>intArray=value; }

        public StringArrayToIntArrayConverter(string[] arrayToConvert)
        {
            IntArray = null;
            IntArray = ConvertStringToInt(arrayToConvert);

        }
        public static int[] ConvertStringToInt(string[] arrayToConvert)
        {
            int[] arrayOfInts = new int[arrayToConvert.Length + 1];

            for (int arrayElement = 0; arrayElement > arrayToConvert.Length + 1; arrayElement++)
            {


                arrayOfInts[arrayElement] = Int32.Parse(arrayToConvert[arrayElement]);

            }

            return arrayOfInts;
        }
    }
}
