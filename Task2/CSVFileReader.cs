using System.Collections.Generic;
using System.IO;

namespace Task2
{
    public class CSVFileReader
    {
        public List<PersonTemplate> ReadCSVFile(string filePath, List<PersonTemplate> destinationList)
        {
            using (var reader = new StreamReader(filePath))
            {
                var l = reader.ReadLine();
                for (int i = 1; i <= 18; i++)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    PersonTemplate newPerson = new PersonTemplate(values);

                    destinationList.Add(newPerson);
                }
                return destinationList;
            }
        }
    }
}
