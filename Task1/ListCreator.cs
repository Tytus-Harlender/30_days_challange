using System.Collections.Generic;

namespace Task1
{
    public class ListCreator
    {
        public List<int> MyList { get; set; }
        public ListCreator(int[] inputnumbers)
        {
            List<int> newList = new List<int>();

            foreach (int i in inputnumbers)
            {
                newList.Add(i);
            }

            MyList = newList;
        }
    }
}
