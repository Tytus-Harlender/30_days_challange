using System;
using System.Collections.Generic;
using System.IO;

namespace Task3
{
    public class CSVFileCreator
    {
        public void CreateCSVFile(List<Book> listToConvert, string destinationPath)
        {
            File.WriteAllText(destinationPath,"");
            foreach (Book b in listToConvert)
            {
                List<string> bookElements = new List<string>();
                bookElements.Add(b.Title);
                bookElements.Add(b.Id);
                bookElements.Add(b.Genre);
                bookElements.Add(b.Description);
                bookElements.Add(b.Price);
                bookElements.Add(b.Publish_date);
                bookElements.Add(b.Author);

                string newbook = string.Join(",", bookElements);
                AddElement(newbook, destinationPath);
            }
        }
        public void AddElement(string nb, string filePath)
        {
            File.AppendAllText(filePath, nb + Environment.NewLine);
        }
    }
}
