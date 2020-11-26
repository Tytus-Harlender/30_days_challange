using System;
using System.Collections.Generic;
using System.Text;


namespace Day2
{
    class Example1_2
    {



        public static void CreateListOfCarObjects()
        {
            List<object> carList = new List<object>();

            new Car() { Brand = "Polonez", ProductionDate = 1956, Color = "yellow"};
            new Car() { Brand = "Audi", ProductionDate = 1966, Color = "green" };
            new Car() { Brand = "VolksWagen", ProductionDate = 2000, Color = "red" };
            new Car() { Brand = "Ford", ProductionDate = 1978, Color = "blue" };

            
        }

        public class Car
        {
            public string Brand { get; set; }
            public int ProductionDate { get; set; }
            public string Color { get; set; }


        }
    }
}
