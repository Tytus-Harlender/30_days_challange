using System;

namespace Day5
{
    class StructExample
    {

        struct SimpleExample
        {

            public int number;
            public string word;
            public bool TheAnswer;
        
        }

        public void UseAStruct()
        {
            SimpleExample s;
            s.number = 5;
            s.word = "That's it!";
            s.TheAnswer = false;

            Console.WriteLine(s.number);
            Console.WriteLine(s.TheAnswer);

        }







    }
}
