using System;

namespace Day6
{
    partial class PartialExample
    {
        public PartialExample(int x, int y)
        {
            X = x;
            Y = y;
        
        }

        public void ShowTheValues()
        {
            Console.WriteLine(X);
            Console.WriteLine(Y);
        
        }
    }

    partial class PartialExample
    {
        
        private int x;
        private int y;
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
    }
}
