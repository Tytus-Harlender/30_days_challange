using System.Collections.Generic;

namespace Task1
{
    public class TextLinesCollectionCreator
    {
        private List<int> listOfInts;

        public List<int> ListOfInts { get=>listOfInts; set=>listOfInts=value; }

        public TextLinesCollectionCreator(int[] inputnumbers)
        {
            List<int> newList = new List<int>();

            foreach (int i in newList)
            {

                newList.Add(inputnumbers[i]);

            }

            ListOfInts = newList;

        }
    }
}
