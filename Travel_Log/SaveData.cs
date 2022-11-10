using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using NUnit.Framework;
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace The_Daily_Travel_Log
{
    //The SaveData class has the single responsibility of saving data and follows the Single Responsibility Principle (Part of Feature #3)
    public class SaveData
    {
        public static void SaveLocation()
        {
            string currenttown;
            string currentstateorprovince;
            string currentcountry;

            Console.WriteLine("Please note that anything typed into the following parameters will be saved to your previous locations. This means typos and all!");
            Console.WriteLine();
            Thread.Sleep(2000);

            DateTime currentDateAndTime = DateTime.Now;

            //Saves location information the user inputs to PreviousLocations.csv
            StreamWriter swriter1 = new StreamWriter("PreviousLocations.csv", true);

            Console.WriteLine("Please input the town you are currently in:");
            currenttown = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Please input the state or province you are currently in:");
            currentstateorprovince = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Please input the country you are currently in:");
            currentcountry = Console.ReadLine();
            Console.WriteLine();

            //Formats the text input by the user for easy legibility
            swriter1.WriteLine("Town: " + currenttown + " , State/Province: " + currentstateorprovince + " , Country: " + currentcountry + " , Date and Time Logged: " + currentDateAndTime);
            swriter1.Flush();
            swriter1.Close();

            Console.WriteLine("Your location information has been recorded!");
        }
        //This method saves file not found errors to a user accessible text file when attempting to access previously saved locations (Part of Feature #2)
        public static void SavePreviousLocationsRetrievalError()
        {
            StreamWriter swriter2 = new StreamWriter("DailyTravelLogErrors.txt", true);
            DateTime errorDateAndTime = DateTime.Now;
            swriter2.WriteLine(errorDateAndTime + " File Not Found Exception: PreviousLocations.csv");
            swriter2.Flush();
            swriter2.Close();
        }
        //This method saves file not found errors to a user accessible text file when attempting to access previously saved errors (Part of Feature #2)
        public static void SavePreviousErrorsRetrievalError()
        {
            StreamWriter swriter3 = new StreamWriter("DailyTravelLogErrors.txt", true);
            DateTime errorDateAndTime = DateTime.Now;
            swriter3.WriteLine(errorDateAndTime + " File Not Found Exception: DailyTravelLogErrors.txt");
            swriter3.Flush();
            swriter3.Close();
        }
        //This method saves main menu user input errors to a user accessible text file (Part of Feature #2)
        public static void SaveUserInputError()
        {
            StreamWriter swriter4 = new StreamWriter("DailyTravelLogErrors.txt", true);
            DateTime errorDateAndTime = DateTime.Now;
            swriter4.WriteLine(errorDateAndTime + " Error: User input was not recognized");
            swriter4.Flush();
            swriter4.Close();
        }
    }
}
//Thanks Michael Winter for the StreamWriter help!