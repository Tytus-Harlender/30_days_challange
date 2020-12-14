using System;

namespace Day1
{
    class ProtectionFromOverride
    {
        class X
        {
            protected virtual void F() { Console.WriteLine("X.F"); }
            protected virtual void F2() { Console.WriteLine("X.F2"); }
        }

        class Y : X
        {
            sealed protected override void F() { Console.WriteLine("Y.F"); }
            protected override void F2() { Console.WriteLine("Y.F2"); }
        }

        class Z : Y
        {
            protected override void F2() { Console.WriteLine("Z.F2"); }
        }
    }
}
