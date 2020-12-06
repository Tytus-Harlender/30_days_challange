using System;

namespace Day5
{
    abstract class OverridingExample
    {
        public abstract void CallMe();
    }

    class OverridingClass:OverridingExample
    {

        public override void CallMe()
        {
            Console.WriteLine("I call you");
        }

    }

}
