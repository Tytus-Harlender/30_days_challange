using System;

namespace Day1
{
    class VolkswagenType:CarPrototype
    {
        public override void SwitchTheLights()
        {
            Console.WriteLine("Volkswagen switches the lights after the key input to the ignition switch");
        }
    }
}
