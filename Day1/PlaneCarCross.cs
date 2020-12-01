using System;

namespace Day1
{
    class PlaneCarCross:IConceptCar,IConceptPlane
    {
        public void CarFunction()
        {
            Console.WriteLine("Riding on the ground");
        }

        public void CarFunctionTwo()
        {
            Console.WriteLine("Having tires");
        }

        public void PLaneFunctionOne()
        {
            Console.WriteLine("Flying to the sky");
        }

        public void PlaneFunctionTwo()
        {
            Console.WriteLine("Having wings");
        }
    }
}
