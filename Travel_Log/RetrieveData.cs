using System;
using System.IO;
using System.Threading;
using NUnit.Compatibility;
using NUnit.Framework;

namespace The_Daily_Travel_Log
{
    //The RetrieveData class has the single responsibility of data retrieval and follows the Single Responsibility Principle (Part of Feature #3)
    public class RetrieveData
    {
        public static void RetrievePreviousLocations()
        {
            StreamReader sreader1 = new StreamReader("PreviousLocations.csv");
            Console.WriteLine(sreader1.ReadToEnd());
            sreader1.Close();
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
