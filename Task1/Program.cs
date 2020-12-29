
namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {            
            string sp = @"fileTest.txt";
            string op = @"output.txt";
            var ng = new TextLinesGetter();
            var lines = ng.GetTheLines(sp);
            var sic = new StringToIntConverter();
            var numbers = sic.ConvertStringToInt(lines);
            var lc = new ListCreator(numbers);
            lc.MyList.Sort();
            var tw = new TextLinesWriter(lc.MyList,op);
        }
    }
}
