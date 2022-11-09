using System;
using System.IO;
using System.Threading;
using NUnit.Compatibility;
using NUnit.Framework;

namespace The_Daily_Travel_Log
{
    //The SaveDataTests class has the single responsibility of testing file/data saving and follows the Single Responsibility Principle (Part of Feature #3)

    //The EnsurePreviousLocationsFileExists, EnsurePreviousErrorsFileExists, EnsureWriteToCsvFile, and EnsureWriteToTxtFile methods can be be extended as new requirements arise without changing the overall function of SaveDataTests parent class.
    //This class follows the Open/Closed Principle (Part of Feature #3)
    [TestFixture]
    public class SaveDataTests
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
            SaveData.SaveLocation();
            Assert.IsNotEmpty(File.ReadAllText("PreviousLocations.csv"));
        }
        //Tests to ensure the program is writing to a txt file stored on the computer, like is done in the error logging feature, without having to run the program or check the computer's memory manually (Part of Feature #1)
        [Test]
        public void EnsureWriteToTxtFile()
        {
            ErrorHandling.UserInputError();
            Assert.IsNotEmpty(File.ReadAllText("DailyTravelLogErrors.txt"));
        }
    }
}