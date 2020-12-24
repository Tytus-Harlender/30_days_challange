using System.IO;

namespace Task1
{
    public class TextFileSizer
    {
        public string[] GetTheLines(string path)
        {
            string[] inputLines = File.ReadAllLines(path);
            return inputLines;
        }
    }
}
