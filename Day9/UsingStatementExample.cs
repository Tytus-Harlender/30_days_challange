using System;
using System.IO;

namespace Day9
{
    class UsingStatementExample
    {
        public static void ReadTheLines()
        {
            string manyLines = @"This is line one
                                 This is line two
                                 Here is line three
                                 The penultimate line is line four
                                 This is the final, fifth line.";

            using (var reader = new StringReader(manyLines))
            {
                string item;
                do
                {
                    item = reader.ReadLine();
                    Console.WriteLine(item);
                } while (item != null);
            }

            using (var sb = new StringReader(manyLines))
            using (var sw = new StringReader(sb.ReadLine()))
            {
                Console.WriteLine(sw);
            }


        }
    }


}
