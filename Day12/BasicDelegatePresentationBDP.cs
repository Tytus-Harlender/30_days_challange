using System;

namespace Day12
{
    public delegate void MyDelegate(string msg);
    public class BasicDelegatePresentationBDP
    {
        public void PresentTheDelegates()
        {
            
            MyDelegate del = BDPClassA.MethodA;
            del("this is for MethodA");

            del = BDPClassB.MethodB;
            del("this one goes for MethodB");
        }

        public void InvokeDelegate(MyDelegate del)
        {
            del("it was called");
        }
    }
}
