using System;

namespace Day12
{
    public delegate void MyDelegate(string msg);

    public delegate int MyDelegateReturnOfTheInt();
    public class BasicDelegatePresentationBDP
    {
        public void PresentTheDelegates()
        {
            
            MyDelegate del = BDPClassA.MethodA;
            del("this is for MethodA");

            del = BDPClassB.MethodB;
            del("this one goes for MethodB");

            //multi-cast delegate

            del = BDPClassA.MethodA;
            del += BDPClassB.MethodB;
            InvokeDelegate(del);
            del -= BDPClassB.MethodB;
            InvokeDelegate(del);

            MyDelegateReturnOfTheInt del1 = BDPClassC.MethodC;
            MyDelegateReturnOfTheInt del2 = BDPClassD.MethodD;

            MyDelegateReturnOfTheInt del3 = del1 + del2;
            Console.WriteLine(del3());

        }

        public void InvokeDelegate(MyDelegate del)
        {
            del("it was called");
        }
    }
}
