using System;

namespace Day3
{
    public class QuickReturn
    {
        public void TellTheSum()
        {
            
            int L;

            Sum(out L);

            Console.WriteLine("The sum:", L);
        }

        public static void Sum(out int L)
        {
            L = 80;
            L += L;
        }
    }
}
