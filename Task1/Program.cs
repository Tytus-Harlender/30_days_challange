
using System;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var textFileSizer = new TextFileSizer();
            string fileWithNubmer = @"fileTest.txt";
            var lines = textFileSizer.GetTheLines(fileWithNubmer);
            StringArrayToIntArrayConverter newConverter = new StringArrayToIntArrayConverter(lines);

            TextLinesCollectionCreator newCreator = new TextLinesCollectionCreator(newConverter.IntArray);

            //ListSortingClass.SortTheList(newCreator.ListOfInts);
            //File.WriteAllLines("fileTest2.txt", newCreator.ListOfInts);
        }
    }
}
