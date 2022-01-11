
using System;
using System.Linq;

namespace Task1
{
    public class SecondStringToIntConverter : IConvertStringToInt
    {
        public int[] ConvertStringToInt(string[] arrayToConvert)
        {
            return arrayToConvert.Select(x => Int32.Parse(x)).ToArray();
        }
    }
}
