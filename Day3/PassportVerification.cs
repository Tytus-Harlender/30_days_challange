using System;

namespace Day3
{
    public static class PassportVerification
    {
        public static void PassTheBorder()
        {

            string str = "polish";

            PassportCheck(ref str);

            Console.WriteLine(str);
        }

        static void PassportCheck(ref string str1)
        {

            if (str1 != "US citizan")
            {
                Console.WriteLine("No entrance for foreigners");
            }

            str1 = "You shall not pass!";

        }
    }
}
