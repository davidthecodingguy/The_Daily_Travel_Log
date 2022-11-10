using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using NUnit.Framework;
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace The_Daily_Travel_Log
{
    //The ErrorHandling class has the single responsibility of error display and follows the Single Responsibility Principle (Part of Feature #3)
    public class ErrorHandling
    {
        //The PreviousLocationsRetrievalError method's behavior can be extended as new requirements arise without changing it's source code and follows the Open/Closed Principle (Part of Feature #3)
        public static void PreviousLocationsRetrievalError()
        {
            Console.WriteLine("The file could not be found! Either make your first location entry or make sure the file PreviousLocations.csv has not been deleted or renamed!");
            SaveData.SavePreviousLocationsRetrievalError();
        }
        //The PreviousErrorsRetrievalError method's behavior can be extended as new requirements arise without changing it's source code and follows the Open/Closed Principle (Part of Feature #3)
        public static void PreviousErrorsRetrievalError()
        {
            Console.WriteLine("The file could not be found! Either make your first mistake or make sure the file DailyTravelLogError.txt has not been deleted or renamed!");
            SaveData.SavePreviousErrorsRetrievalError();
        }
        //The UserInputError method's behavior can be extended as new requirements arise without changing it's source code and follows the Open/Closed Principle (Part of Feature #3)
        public static void UserInputError()
        {
            Console.WriteLine("Input not recognized, please try again!");
            SaveData.SaveUserInputError();
        }
    }
}
