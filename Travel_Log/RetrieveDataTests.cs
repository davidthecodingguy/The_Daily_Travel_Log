using System;
using System.IO;
using System.Threading;
using NUnit.Compatibility;
using NUnit.Framework;
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace The_Daily_Travel_Log
{
    [TestFixture]
    public class RetrieveDataTests
    //These unit tests correlate to the unit tests feature listed on the project README (Feature #1) and have been implemented to aid in debugging and ensure the program continues to function as intended
    {
        //TEST TYPE #2: Tests to ensure the program is reading from the database, like is done in the previous locations display feature (Part of Feature #1)
        [Test]
        public void EnsureReadLocationsDatabase()
        {
            var locations = RetrieveData.RetrievePreviousLocations();
            Assert.IsNotEmpty(locations);
        }
        //Tests to ensure the program is reading from the correct txt file stored on the computer, like is done in the previous errors display feature (Part of Feature #1)
        [Test]
        public void EnsureReadTxtFile()
        {
            RetrieveData.RetrievePreviousErrors();
            Assert.IsNotEmpty(File.ReadLines("DailyTravelLogErrors.txt"));
        }
        [Test]
        //ADD TEST TESTING FUNCTION IN RETRIEVEDATA
        public void EnsureFunctionFunctions()
        {

        }
    }
}
