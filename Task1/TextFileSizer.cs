using System.IO;

namespace Task1
{
    public static class TextFileSizer
    {
        public static string[] GetTheLines()
        {
            string path = @"C:\Users\Tytus\Desktop\fileTest.txt";
            string[] inputLines = File.ReadAllLines(path);
            return inputLines;

        }
        
    
    }
}
