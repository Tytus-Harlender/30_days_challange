using System.Collections.Generic;
using System.IO;

namespace Task2
{
    class CSVReaderAndListCreator
    {
        public static List<PersonTemplate> ReadCSVFileAndCreateAList(string filePath)
        {
            //using (var reader = new StreamReader(filePath))
            //{
                var reader = new StreamReader(filePath);
                List<PersonTemplate> listOfPersons = new List<PersonTemplate>();
                reader.ReadLine();


                for (int i = 1; i<=18; i++)
                {

                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    PersonTemplate newPerson = new PersonTemplate(values[0], values[1], values[2], values[3], values[4]);


                    listOfPersons.Add(newPerson);

                }

                
            //}
            return listOfPersons;
        }
    }
}
