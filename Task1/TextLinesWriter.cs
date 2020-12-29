﻿using System.Collections.Generic;
using System.IO;

namespace Task1
{
    public class TextLinesWriter
    {
        public TextLinesWriter(List<int> inputList, string outputPath)
        {
            var isc = new IntToStringListConverter();
            var stringList = isc.ConvertIntToStringList(inputList);
            File.WriteAllLines(outputPath, stringList);
        }
    }
}
