using System;
using System.IO;
using System.Threading;
using NUnit.Compatibility;
using NUnit.Framework;

namespace The_Daily_Travel_Log
{
    //The SaveDataTests class has the single responsibility of testing data retrieval and follows the Single Responsibility Principle (Part of Feature #3)
    [TestFixture]
    public class RetrieveDataTests
    //These unit tests correlate to the unit tests feature listed on the project README (Feature #1) and have been implemented to aid in debugging and ensure the program continues to function as intended
    {
        //TEST TYPE #3: Tests to ensure the program is reading from the correct csv file stored on the computer, like is done in the previous locations display feature (Part of Feature #1)
        [Test]
        public void EnsureReadCsvFile()
        {
            RetrieveData.RetrievePreviousLocations();
            //StreamReader teststreamReader = new StreamReader("PreviousLocations.csv");
            Assert.IsNotEmpty(File.ReadLines("PreviousLocations.csv"));
            //Console.WriteLine(teststreamReader.ReadLine());
            //Assert.IsNotEmpty(teststreamReader.ReadLine());
            //teststreamReader.Close();
        }
        //Tests to ensure the program is reading from the correct txt file stored on the computer, like is done in the previous errors display feature (Part of Feature #1)
        [Test]
        public void EnsureReadTxtFile()
        {
            RetrieveData.RetrievePreviousErrors();
            //StreamReader teststreamReader = new StreamReader("DailyTravelLogErrors.txt");
            Assert.IsNotEmpty(File.ReadLines("DailyTravelLogErrors.txt"));
            //Console.WriteLine(teststreamReader.ReadLine());
            //Assert.IsNotEmpty(teststreamReader.ReadLine());
            //teststreamReader.Close();
        }
    }
}
