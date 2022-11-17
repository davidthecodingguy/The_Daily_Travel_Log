using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using NUnit.Framework;
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace The_Daily_Travel_Log
{
    public class ErrorHandling
    {
        public static void PreviousLocationsRetrievalError()
        {
            Console.WriteLine("The database could not be reached! Please make your first location entry!");
            SaveData.SavePreviousLocationsRetrievalError();
        }
        public static void PreviousErrorsRetrievalError()
        {
            Console.WriteLine("The file could not be found! Either make your first mistake or make sure the file DailyTravelLogError.txt has not been deleted or renamed!");
            SaveData.SavePreviousErrorsRetrievalError();
        }
        public static void UserInputError()
        {
            Console.WriteLine("Input not recognized, please try again!");
            SaveData.SaveUserInputError();
        }
    }
}
