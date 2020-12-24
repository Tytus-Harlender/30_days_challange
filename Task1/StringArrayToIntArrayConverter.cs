using System;

namespace Task1
{
    public class StringArrayToIntArrayConverter
    {
        public int[] IntArray;

        public StringArrayToIntArrayConverter(string[] arrayToConvert)
        {
            IntArray = ConvertStringToInt(arrayToConvert);
        }

        public int[] ConvertStringToInt(string[] arrayToConvert) // 1
        {
            int[] arrayOfInts = new int[arrayToConvert.Length];
                                    
            for (int arrayElement = 0; arrayElement < arrayToConvert.Length; arrayElement++)
            {
                arrayOfInts[arrayElement] = Int32.Parse(arrayToConvert[arrayElement]);
            }

            return arrayOfInts;
        }
    }
}
