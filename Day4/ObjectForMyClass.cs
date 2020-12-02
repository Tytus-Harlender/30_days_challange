using System;

namespace Day4
{
    public static class ObjectForMyClass
    {
        public static void CreateMyClass()
        {
            MyClass myNewClass = new MyClass(8, "Tytus");
            Console.WriteLine(myNewClass.YourNumber);
            Console.WriteLine(myNewClass.YourWord);
        }

        public static void SayMyClassNumber(MyClass UsedClass)
        {
            UsedClass.SayMyNumber();

        }

        public static void SayMyClassWord(MyClass UsedClass)
        {
            UsedClass.SayMyWord();

        }
    }
}
