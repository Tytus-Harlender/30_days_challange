using System;
using System.Collections.Generic;

namespace Task1
{
    public class IntToStringListConverter
    {
        public List<string> ConvertIntToStringList(List<int> listOfInts)
        {
            List<string> listOfStrings = new List<string>();
            foreach (int i in listOfInts)
            {
                string x = Convert.ToString(i);
                listOfStrings.Add(x);
            }
            
            return listOfStrings;
        }
    }
}
