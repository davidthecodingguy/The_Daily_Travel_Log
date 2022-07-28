using System;
using System.IO;
using System.Threading;
using NUnit.Compatibility;
using NUnit.Framework;

namespace The_Daily_Travel_Log
{
    [TestFixture]
    public class SaveAndRetrieveFilesTests
    {
        [Test]
        public void WhenUnableToFindPreviousLocationsFile()
        {
            File.Exists("PreviousLocations.csv");
            Assert.IsTrue(File.Exists("PreviousLocations.csv"));
        }
        [Test]
        public void WhenUnableToFindPreviousErrorsFile()
        {
            File.Exists("DailyTravelLogErrors.txt");
            Assert.IsTrue(File.Exists("DailyTravelLogErrors.txt"));
        }
    }
}
