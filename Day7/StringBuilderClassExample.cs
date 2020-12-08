using System;
using System.Collections.Generic;
using System.Text;

namespace Day7
{
    class StringBuilderClassExample
    {
        public static void StringBuilderExample()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Line 1:");
            sb.AppendLine("Line 2:");

            string allLines = sb.ToString();
        }

        public static void StringExample()
        {
            string s = string.Empty;
            s += "Line 1:";
            s += "/r/nLine 2:/r/n"; 

        }
        
    }
}
