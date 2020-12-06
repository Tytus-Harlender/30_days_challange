using System;

namespace Day5
{
    abstract class FirstClass
    {
        public abstract void F();
        public abstract void F2(); 
    }

    class StopInheritance : FirstClass
    {
        public sealed override void F() { Console.WriteLine("Y.F"); }
        public override void F2() { Console.WriteLine("Y.F2"); }
    }

    class FinalCLass : StopInheritance
    {
        //'public override void F() { Console.WriteLine("Z.F1"); }' would generate error
        public override void F2() { Console.WriteLine("Z.F2"); }
    }
}
