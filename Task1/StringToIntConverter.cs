using System;

namespace Task1
{
    public class StringToIntConverter
    {
        public int[] ConvertStringToInt(string[] arrayToConvert)
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
