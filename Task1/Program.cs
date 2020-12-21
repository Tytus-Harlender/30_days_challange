
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {

            StringArrayToIntArrayConverter newConverter = new StringArrayToIntArrayConverter(TextFileSizer.GetTheLines());

            TextLinesCollectionCreator newCreator = new TextLinesCollectionCreator(newConverter.IntArray);

            ListSortingClass.SortTheList(newCreator.ListOfInts);

            //File.WriteAllLines(@"C:\Users\Tytus\Desktop\fileTest2.txt", newCreator.ListOfInts);
        }
    }
}
