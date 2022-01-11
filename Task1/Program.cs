
using System.Linq;
using Unity;

namespace Task1
{
    class Program
    {
        private static string _sourcePath = @"fileTest.txt";
        private static string _outputPath = @"output.txt";
        static void Main(string[] args)
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<IConvertStringToInt, StringToIntConverter>();


            var textLinesGetter = new TextLinesGetter();
            var lines = textLinesGetter.GetTheLines(_sourcePath);
            IConvertStringToInt stringToIntConverter = container.Resolve<IConvertStringToInt>();
            var numbers = stringToIntConverter.ConvertStringToInt(lines);

            var sortedList = numbers.ToList();
            sortedList.Sort();
            var textLinesWriter = new TextLinesWriter();
            textLinesWriter.SaveToFile(sortedList, _outputPath);
        }
    }

    public class Test
    {
        public void DoSth(IConvertStringToInt stringToIntConverter)
        {
            throw new System.NotImplementedException();
        }
    }
}
