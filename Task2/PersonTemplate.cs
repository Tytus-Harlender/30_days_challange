using System;

namespace Task2
{
    public class PersonTemplate
    {
        #region FIELDS
        private string _name;
        private int _sexValue;
        private enum _sexEnum
        {
            Male = 0,
            Female = 1
        }
        private int _age;
        private int _height;
        private double _weight;
        #endregion

        #region PROPERTIES
        public string Name { get => _name; set => _name = value; }
        public int Sex { get => _sexValue; set => _sexValue = value; }
        public int Age { get => _age; set => _age = value; }
        public int Height { get => _height; set => _height = value; }
        public double Weight { get => _weight; set => _weight = value; }

        #endregion

        public PersonTemplate(string name, string sex, string age, string height, string weight)
        {
            Name = name;
            if (sex == "F")
            {
                Sex = (int)_sexEnum.Female;
            }
            else if (sex == "M")
            {
                Sex = (int)_sexEnum.Male;
            }              
            Age = Int32.Parse(age);
            Height = Int32.Parse(height);
            Weight = Double.Parse(weight);

        }
    }
}
