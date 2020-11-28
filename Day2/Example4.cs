using System;
using System.Collections.Generic;
using System.Text;

namespace Day2
{
    class Example4
    {


        public Example4()
        {
            CreateDictionary();
        
        }
        public void CreateDictionary()
        {
            Dictionary<int, string> theRaceResults = new Dictionary<int, string>();

            theRaceResults.Add(1, "Adam");
            theRaceResults.Add(2, "Tom");
            theRaceResults.Add(3, "Rafael");
            theRaceResults.Add(4, "Michael");
            theRaceResults.Add(5, "Gabriel");


            theRaceResults[1] = "disqualified";

            theRaceResults.Remove(4);
            theRaceResults.Remove(5);

            theRaceResults[2] = theRaceResults[3];


            string nameOfParticipant;
            if (theRaceResults.TryGetValue(1, out nameOfParticipant))
            {
                Console.WriteLine(nameOfParticipant);
            }


        }
        
    }
}
