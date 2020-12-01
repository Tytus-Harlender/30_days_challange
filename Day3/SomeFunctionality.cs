using System;

namespace Day3
{
    public static class SomeFunctionality
    {
        public static void PrintTheBillInformation()
        {
            Console.WriteLine("Dear customer, please pay the bill");
        }

        public static DateTime GiveTheDateOfLogin()
        {
            Console.WriteLine(DateTime.Now);
            return DateTime.Now;

        }

        public static int GiveTheAgeOfCustomer(int birthyear)
        {
            Console.WriteLine("Your age equals:");
            return (DateTime.Now.Year-birthyear);

        }


    }
}
