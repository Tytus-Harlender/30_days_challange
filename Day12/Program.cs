using System;

namespace Day12
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = "coconut";
            var firstLetter_1 = StringEditor.firstLetter(word);
            var firstLetter_0 = word.firstLetter();
            Console.WriteLine(firstLetter_0);
            Console.WriteLine(firstLetter_1);

            GenericsPresentation presentation = new GenericsPresentation();

        }
    }
}
