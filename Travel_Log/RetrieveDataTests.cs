using System;
using System.IO;
using System.Threading;
using NUnit.Compatibility;
using NUnit.Framework;
//ALL UNNECESSARY CODE NEEDS TO BE DELETED
namespace The_Daily_Travel_Log
{
    //The RetrieveDataTests class has the single responsibility of testing data retrieval and follows the Single Responsibility Principle (Part of Feature #3)

    //The EnsureReadCsvFile and EnsureReadTextFile methods can be be extended as new requirements arise without changing the overall function of RetrieveDataTests parent class.
    //This class follows the Open/Closed Principle (Part of Feature #3)
    [TestFixture]
    public class RetrieveDataTests
    //These unit tests correlate to the unit tests feature listed on the project README (Feature #1) and have been implemented to aid in debugging and ensure the program continues to function as intended
    {
        //TEST TYPE #3: Tests to ensure the program is reading from the correct csv file stored on the computer, like is done in the previous locations display feature (Part of Feature #1)
        [Test]
        public void EnsureReadCsvFile()
        {
            RetrieveData.RetrievePreviousLocations();
            Assert.IsNotEmpty(File.ReadLines("PreviousLocations.csv"));
        }
        //Tests to ensure the program is reading from the correct txt file stored on the computer, like is done in the previous errors display feature (Part of Feature #1)
        [Test]
        public void EnsureReadTxtFile()
        {
            RetrieveData.RetrievePreviousErrors();
            Assert.IsNotEmpty(File.ReadLines("DailyTravelLogErrors.txt"));
        }
    }
}
