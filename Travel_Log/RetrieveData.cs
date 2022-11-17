using System;
using System.IO;
using System.Threading;
using NUnit.Compatibility;
using NUnit.Framework;
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;

namespace The_Daily_Travel_Log
{
    public class RetrieveData
    {
        public static List<Location> RetrievePreviousLocations()
        {
            //This list has been created to separate concerns of retrieving and saving data and to allow easier implementation of this class in multiple locations (Part of Feature #3)
            using var db = new LocationDataContext();
            List<Location> locations = db.Locations.ToList();
            return locations;
        }
        //Retrieves main menu errors that have been written to a text file (Part of Feature #2)
        public static void RetrievePreviousErrors()
        {
            StreamReader sreader2 = new StreamReader("DailyTravelLogErrors.txt");
            Console.WriteLine("You are viewing a list of previously logged errors when attempting to access program files or options in the main menu:");
            Console.WriteLine(sreader2.ReadToEnd());
            sreader2.Close();
        }
    }

}
