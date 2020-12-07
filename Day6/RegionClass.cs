using System;

namespace Day6
{
    class RegionClass
    {

        #region Fields

        private string name;
        private int age;
        private double weight;
        private string colour;


        #endregion

        #region Propierties

        public string Name { get => name; set=> name = value; }
        public int Age { get =>age; set=> age = value; }
        public double Weight { get => weight; set => weight = value; }
        public string Colour { get => colour; set => colour = value; }
        #endregion

        #region Methods

        public void DisplayNote()
        {
            Console.WriteLine("This is a note");
        
        }

        public int GiveMeAgeTimesTwo()
        {
            return 2*age;
        }

        #endregion

    }
}
