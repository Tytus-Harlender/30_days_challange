
namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            CSVReaderAndListCreator newList = new CSVReaderAndListCreator("C:\\Users\\Tytus\\Desktop\\TASKs\\biostats.csv");
            ListSearcherAndPrinterByQuery.SearchTheList(listOfPersons);
        }
    }
}
