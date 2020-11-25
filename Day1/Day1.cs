using System;


namespace _30_days_challange
{   
    
    public class Day1
    {

        public class PolonezTemplate
        {

            public string brand = "Polonez";
            public string color = "red";
            public double doors = 5;
            public double generation = 4;

        }


        public abstract class CarPrototype
        {
         
            public abstract void SwitchTheLights();
            public void Go()
            {
                Console.WriteLine("Car is going!!!");
            }


        }

        public class PolonezType : CarPrototype
        {
            public override void SwitchTheLights()
            {
                Console.WriteLine("Polonez switches the lights automatically after engine start");
            }

        }

        public class VolkswagenType : CarPrototype
        {
            public override void SwitchTheLights()
            {
                Console.WriteLine("Volkswagen switches the lights after the key input to the ignition switch");
            }

        }

        public interface IConceptCar
        {
            void CarFunction();
            void CarFunctionTwo();


        }

        public class CarImplementation : IConceptCar
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

        //multi-implementation presented

        public interface IConceptPlane 
        {
            public void PLaneFunctionOne();
            public void PlaneFunctionTwo();
        
        
        }

        public class PlanCarCross : IConceptCar, IConceptPlane
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
}

