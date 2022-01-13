
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
        }
    }
}
