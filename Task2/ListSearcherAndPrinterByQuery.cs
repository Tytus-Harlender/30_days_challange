using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2
{
    public class ListSearcherAndPrinterByQuery
    {
        public static void SearchTheList(List<PersonTemplate> listToSearch)
        {

            var listQuery =
                from person in listToSearch
                where ((person.Age >30) && (person.Sex == 1))
                
                select person;

            foreach (PersonTemplate person in listQuery)
            {
                Console.Write(person);
            }


        }
    }
}
