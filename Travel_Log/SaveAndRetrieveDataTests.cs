using System;
using System.IO;
using System.Threading;
using NUnit.Compatibility;
using NUnit.Framework;

namespace The_Daily_Travel_Log
{
    [TestFixture]
    public class SaveAndRetrieveDataTests
    //These unit tests correlate to the unit tests feature listed on the project README (Feature #1) and have been implemented to aid in debugging and ensure the program continues to function as intended
    {
        //TEST TYPE #1: Tests to ensure the previous locations save file exists without having to run the program or check the computer's memory manually (Part of Feature #1)
        //PLEASE NOTE: Test Type #1 will fail if you have not made an error or attempted to log a location
        [Test]
        public void EnsurePreviousLocationsFileExists()
        {
            File.Exists("PreviousLocations.csv");
            Assert.IsTrue(File.Exists("PreviousLocations.csv"));
        }
        //Tests to ensure the previous errors save file exists without having to run the program or check the computer's memory manually (Part of Feature #1)
        [Test]
        public void EnsurePreviousErrorsFileExists()
        {
            File.Exists("DailyTravelLogErrors.txt");
            Assert.IsTrue(File.Exists("DailyTravelLogErrors.txt"));
        }
        //TEST TYPE #2: Tests to ensure the program is writing to a csv file stored on the computer, like is done in the location logging feature, without having to run the program or check the computer's memory manually (Part of Feature #1)
        [Test]
        public void EnsureWriteToCsvFile()
        {
            SaveAndRetrieveLocations.SaveLocation();
            Assert.IsNotEmpty(File.ReadAllText("PreviousLocations.csv"));
        }
        //Tests to ensure the program is writing to a txt file stored on the computer, like is done in the error logging feature, without having to run the program or check the computer's memory manually (Part of Feature #1)
        [Test]
        public void EnsureWriteToTxtFile()
        {
            ErrorHandling.UserInputError();
            Assert.IsNotEmpty(File.ReadAllText("DailyTravelLogErrors.txt"));
        }
        //TEST TYPE #3: Tests to ensure the program is reading from the correct csv file stored on the computer, like is done in the previous locations display feature (Part of Feature #1)
        [Test]
        public void EnsureReadCsvFile()
        {
            SaveAndRetrieveLocations.RetrievePreviousLocations();
            StreamReader teststreamReader = new StreamReader("PreviousLocations.csv");
            Assert.IsNotEmpty(File.ReadLines("PreviousLocations.csv"));
            Console.WriteLine(teststreamReader.ReadLine());
            Assert.IsNotEmpty(teststreamReader.ReadLine());
            teststreamReader.Close();
        }
        //Tests to ensure the program is reading from the correct txt file stored on the computer, like is done in the previous errors display feature (Part of Feature #1)
        [Test]
        public void EnsureReadTxtFile()
        {
            ErrorHandling.RetrievePreviousErrors();
            StreamReader teststreamReader = new StreamReader("DailyTravelLogErrors.txt");
            Assert.IsNotEmpty(File.ReadLines("DailyTravelLogErrors.txt"));
            Console.WriteLine(teststreamReader.ReadLine());
            Assert.IsNotEmpty(teststreamReader.ReadLine());
            teststreamReader.Close();
        }
        
    }
}