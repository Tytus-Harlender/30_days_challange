using System;

namespace Day4
{
    public class MyClass
    {
        private int yourNumber;

        private string yourWord;

        public int YourNumber { get; set; }
        public string YourWord { get; set; }


        public MyClass(int number, string name)
        {
            YourNumber = number;
            YourWord = name;
        
        }

        public void SayMyWord()
        {
            Console.WriteLine("Your word is :" + YourWord);
        
        }

        public void SayMyNumber()
        {
            Console.WriteLine("Your number is :" + YourNumber);

        }
    }
}
