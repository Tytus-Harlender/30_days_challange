using System;
using System.Collections.Generic;
using System.Text;

namespace Day2
{
    
    class Example1_1
    {

        public static void ShowExampleOne()
        {
            
            DisplayListOfCars(CreateListOfCars());

        }

        public static List<string> CreateListOfCars()
        {
            List<string> carsList = new List<string>();

            carsList.Add("Polonez");
            carsList.Add("VolksWagen");
            carsList.Add("Ford");
            carsList.Add("Audi");

            return carsList;

        }

        public static void RemoveFromListOfCars(List<string> cars)
        {
            cars.Remove("Audi");
            cars.Remove("Ford");
        }

        



        public static void DisplayListOfCars(List<string> cars) 
        {
            foreach (string name in cars)
            {
                Console.WriteLine(name);
            }
        
        }

        public static List<string> CreateListOfCarsSimpler()
        {
            List<string> carsList = new List<string>() {"Polonez", "VolksWagen", "Ford", "Audi"};

            return carsList;
        }




    }
}
