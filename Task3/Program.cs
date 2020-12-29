using System.IO;
using System.Xml.Serialization;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string sp = @"C:\Users\Tytus\Desktop\TASKs\task3file.xml";
            string dp = @"C:\Users\Tytus\Desktop\TASKs\task3file.csv";

            using (StreamReader reader = new StreamReader(sp))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Catalog));             
                Catalog catalog = (Catalog)serializer.Deserialize(reader);               
                CSVFileCreator nc = new CSVFileCreator();
                nc.CreateCSVFile(catalog.Book, dp);               
            }
        }
    }
}
