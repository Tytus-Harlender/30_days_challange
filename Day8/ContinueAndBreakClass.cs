using System;


namespace Day8
{
    class ContinueAndBreakClass
    {
        public static void BreakingLoop()
        {
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
                if (i == 4)
                {
                    break;
                }
            }
        }

        public static void OmittingIteration()
        {

            int i = 0;
            while (i < 10)
            {
                if (i == 4)
                {
                    i++;
                    continue;
                }
                Console.WriteLine(i);
                i++;
            }



        }


    }
}
