using System;
using System.Collections.Generic;
using System.Text;

namespace Day1
{
    abstract class CarPrototype
    {
        public abstract void SwitchTheLights();
        public void Go()
        {
            Console.WriteLine("Car is going!!!");
        }
    }
}
