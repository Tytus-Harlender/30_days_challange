using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2
{
    public class ListSearcher
    {
        public void SearchTheList(List<PersonTemplate> listToSearch)
        {
            var listQuery =
            from person in listToSearch
            where person.Age > 30 && person.Sex == 1
            select person;

            Console.WriteLine("name, height, weight, age");

            foreach (PersonTemplate person in listQuery)
            {
                Console.Write(person.Name + " ");
                Console.Write(person.Height + " ");
                Console.Write(person.Weight + " ");
                Console.WriteLine(person.Age + " ");
            }

        }
    }
}
