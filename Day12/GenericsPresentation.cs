
namespace Day12
{
    public class GenericsPresentation
    {
        public GenericsPresentation()
        {
         DataStorage<string> stringData = new DataStorage<string>();
         KeyValuePair<int, double> competitionOutcome = new KeyValuePair<int, double>();
         stringData.Data = "some text";
         competitionOutcome.Key = 1;
         competitionOutcome.Value = 2.43;

         DataStorageWithArray<int> intArrayData = new DataStorageWithArray<int>();
         intArrayData.AddOrUpdate(1, 23);
         intArrayData.AddOrUpdate(2, 57);
         intArrayData.AddOrUpdate(3, 88);
         intArrayData.GetData(11);


         NotGenericPrinter printerOne = new NotGenericPrinter();
         printerOne.Print(58);
        }
    }
}
