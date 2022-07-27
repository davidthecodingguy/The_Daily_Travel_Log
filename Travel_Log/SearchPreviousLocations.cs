using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace The_Daily_Travel_Log
{
    class SearchPreviousLocations//MenuOptionInputDictionary
    {
       public static void LinqToSearchPreviousLocations()
       {
            IEnumerable<string> currentDateAndTime = File.ReadLines(@"PreviousLocations.csv");
            //StreamReader sreader = new StreamReader("PreviousLocations.csv");

            var results = from Date in currentDateAndTime orderby currentDateAndTime ascending
                          where (Date) != null
                          select Date;
            foreach (string Date in currentDateAndTime)
            {
                Console.WriteLine(Date);
            }
            //Console.WriteLine(sreader.ReadToEnd());
            //sreader.Close();
                          /*select new
                          {
                              currentTown = true(),
                          }*/
            
            /*var query = currentDate
                .Where<string>()*/
            //var wildCardString = "";

            //var searchResult = stringList.Where()
            //var results = from c in currentDate
                          

            //Might delete later
            //var menuoptioninput = new Dictionary<string, string>()
            //{
            //    {"1", "1."}
            //};
            
              /*public string currenttown { get; set; }

              public string currentstateorprovince { get; set; }

              public string currentcountry { get; set; }

              public string currentdate {get; set;}

              List<"PreviousLocations.csv"> */

            /*var locations = new string[] { };

            var locationQuery =
                from town in currenttown
                select town;*/
       }
    }
}
