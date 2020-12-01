using System;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Bank myBank = new Bank("Imaginary Investments", 500000);

            Console.WriteLine(myBank.welcomeText);
            Console.WriteLine(myBank.bankName);

            WillHideYou.ShowResult();

            Console.WriteLine(SomeFunctionality.GiveTheAgeOfCustomer(1989));
        }
    }
}
