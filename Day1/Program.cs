using System;

namespace _30_days_challange
{

    class Program
    {
        static void Main()
        {
            DayOneProgram();
        }

        static void DayOneProgram()
        {
            //createing an instance of a regular class

            Day1.PolonezTemplate polonezTemplate = new Day1.PolonezTemplate();

            Console.WriteLine(polonezTemplate.brand);
            Console.WriteLine(polonezTemplate.color);
            Console.WriteLine(polonezTemplate.doors);
            Console.WriteLine(polonezTemplate.generation);

            //createing an instance of a subclass (a derivative of an abstract class) 


            Day1.PolonezType polonezType = new Day1.PolonezType();
            Day1.VolkswagenType volkswagenType = new Day1.VolkswagenType();

            polonezType.SwitchTheLights();
            polonezType.Go();

            volkswagenType.SwitchTheLights();
            volkswagenType.Go();

            //createing an instance of a subclass(a implementation of an interface) 

            Day1.CarImplementation carImplementation = new Day1.CarImplementation();

            carImplementation.CarFunction();
            carImplementation.CarFunctionTwo();

            Day1.PlanCarCross planCarCross = new Day1.PlanCarCross();

            planCarCross.CarFunction();
            planCarCross.CarFunctionTwo();
            planCarCross.PLaneFunctionOne();
            planCarCross.PlaneFunctionTwo();


        }
    }
}
