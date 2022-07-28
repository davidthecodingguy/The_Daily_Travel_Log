using System;
using System.IO;
using System.Threading;
using NUnit.Compatibility;
using NUnit.Framework;
using The_Daily_Travel_Log;

namespace The_Daily_Travel_Log
{
    [TestFixture]
    public class SaveAndRetrieveFilesTests
    {
        [Test]
        public void WhenUnableToFindPreviousLocationsFile()
        {
            File.Exists("PreviousLocations.csv");
            Assert.IsFalse(File.Exists("PreviousLocations.csv"));
        }
    }
}
