using System;

namespace Day9
{
    class EnumerationClass
    {


        enum Months
        {
            January,
            February,
            April,
            March,
            June,
            July,
            September,
            October,
            November,
            December,
        }

        enum Payment
        {
            John = 10,
            Kavin = 20,
            Steve = 8,
            Robert = 9,
        
        }


        public static void LoopThroughMonths()
        {

            var values = Enum.GetValues(typeof(Months));

            foreach (int month in values)
            {
                Console.WriteLine((Months)month);
            
            }

        }
        public static void LoopThroughPayment()
        {

            var values = Enum.GetValues(typeof(Payment));

            foreach (int memberPayment in values)
            {
                Console.WriteLine(memberPayment);

            }

        }


    }
}
