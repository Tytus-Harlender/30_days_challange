
namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Tytus\Desktop\TASKs\biostats.csv";
            ListCreator nl = new ListCreator();
            CSVFileReader fr = new CSVFileReader();
            var listToSort = fr.ReadCSVFile(path,nl.CreateList());
            ListSearcher ls = new ListSearcher();
            ls.SearchTheList(listToSort);
        }
    }
}
