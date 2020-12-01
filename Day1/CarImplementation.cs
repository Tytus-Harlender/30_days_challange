using System;

namespace Day1
{
    interface CarImplementation:IConceptCar
    {

        public void CarFunction()
        {
            Console.WriteLine("Movement from point to point");
        }

        public void CarFunctionTwo()
        {
            Console.WriteLine("Playing music");
        }
    }

}
