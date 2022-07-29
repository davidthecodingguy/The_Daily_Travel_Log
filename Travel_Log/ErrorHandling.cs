using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using NUnit.Framework;
namespace The_Daily_Travel_Log
{
    public class ErrorHandling
    {
        public static void PreviousLocationsRetrievalError()
        {
            Console.WriteLine("The file could not be found! Either make your first location entry or make sure the file PreviousLocations.csv has not been deleted or renamed!");
            StreamWriter swriter2 = new StreamWriter("DailyTravelLogErrors.txt", true);
            DateTime errorDateAndTime = DateTime.Now;
            swriter2.WriteLine(errorDateAndTime + " File Not Found Exception: PreviousLocations.csv");
            swriter2.Flush();
            swriter2.Close();
        }

        public static void PreviousErrorsRetrievalError()
        {
            Console.WriteLine("The file could not be found! Either make your first mistake or make sure the file DailyTravelLogError.txt has not been deleted or renamed!");
            StreamWriter swriter3 = new StreamWriter("DailyTravelLogErrors.txt", true);
            DateTime errorDateAndTime = DateTime.Now;
            swriter3.WriteLine(errorDateAndTime + " File Not Found Exception: DailyTravelLogErrors.txt");
            swriter3.Flush();
            swriter3.Close();
        }

        public static void UserInputError()
        {
            Console.WriteLine("Input not recognized, please try again!");
            StreamWriter swriter4 = new StreamWriter("DailyTravelLogErrors.txt", true);
            DateTime errorDateAndTime = DateTime.Now;
            swriter4.WriteLine(errorDateAndTime + " Error: User input was not recognized");
            swriter4.Flush();
            swriter4.Close();
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
