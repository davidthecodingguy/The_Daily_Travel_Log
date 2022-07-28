using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;

namespace The_Daily_Travel_Log
{
    public class SaveAndRetrieveFileInfo
    {
        public static void SaveDateAndTime()
        {
            DateTime currentDateAndTime = DateTime.Now;
        }

        public static void SaveTown()
        {
            string currenttown;
            currenttown = Console.ReadLine();
            Console.WriteLine();
        }

        public static void SaveStateOrProvince()
        {
            string currentstateorprovince;
            currentstateorprovince = Console.ReadLine();
            Console.WriteLine();
        }

        public static void SaveCountry()
        {
            string currentcountry;
            currentcountry = Console.ReadLine();
            Console.WriteLine();
        }

        public static void RetrievePreviousLocations()
        {
            StreamReader sreader1 = new StreamReader("PreviousLocations.csv");
            Console.WriteLine(sreader1.ReadToEnd());
            sreader1.Close();
        }

        public static void RetrievePreviousErrors()
        {
            StreamReader sreader2 = new StreamReader("DailyTravelLogErrors.txt");
            Console.WriteLine("You are viewing a list of previously logged errors when attempting to access program files or options in the main menu:");
            Console.WriteLine(sreader2.ReadToEnd());
            sreader2.Close();
        }

    }
}
