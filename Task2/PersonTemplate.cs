using System;

namespace Task2
{
    public class PersonTemplate
    {
        #region FIELDS
        private enum _sexEnum
        {
            Male,
            Female
        
        }
        #endregion

        #region PROPERTIES
        public string Name { get ; set; }
        public int Sex { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public double Weight { get; set; }

        #endregion
        public PersonTemplate(string[] values)
        {
            Name = values[0];
            if (values[1].Contains("F"))
            {
                Sex = (int)_sexEnum.Female;
            }
            else if (values[1].Contains("M"))
            {
                Sex = (int)_sexEnum.Male;
            }
            Age = Int32.Parse(values[2]);
            Height = Int32.Parse(values[3]);
            Weight = Double.Parse(values[4]);
        }
    }
}
