using System;
using System.IO;
using System.Threading;
using NUnit.Compatibility;
using NUnit.Framework;

namespace The_Daily_Travel_Log
{
    [TestFixture]
    public class SaveAndRetrieveFilesTests
    //These unit tests correlate to the unit tests feature and have been implemented to aid in debugging and ensure the program continues to function as intended
    {
        //Tests to ensure the previous locations save file exists without having to check through the program or manually in the computer's memory (Feature #4)
        [Test]
        public void EnsurePreviousLocationsFileExists()
        {
            File.Exists("PreviousLocations.csv");
            Assert.IsTrue(File.Exists("PreviousLocations.csv"));
        }
        //Tests to ensure the previous errors save file exists without having to check through the program or manually in the computer's memory (Feature #4)
        [Test]
        public void EnsurePreviousErrorsFileExists()
        {
            File.Exists("DailyTravelLogErrors.txt");
            Assert.IsTrue(File.Exists("DailyTravelLogErrors.txt"));
        }
        //Tests to ensure StreamWriter is writing to a csv file stored on the computer, like is done in the location logging feature,
        //without having to check through the program or manually in the computer's memory (Feature #4)
        [Test]
        public void EnsureWriteToCsvFile()
        {
            StreamWriter teststreamWriter = new StreamWriter("ProgramTestFile.csv");
            teststreamWriter.WriteLine("Test");
            teststreamWriter.Flush();
            teststreamWriter.Close();
            Assert.IsNotEmpty(File.ReadAllText("ProgramTestFile.csv"));
            //Deletes file to ensure future test fidelity
            File.Delete("ProgramTestFile.csv");
            //Verifies if file has been deleted
            Assert.IsFalse(File.Exists("ProgramTestFile.csv"));
        }
        //Tests to ensure StreamWriter is writing to a txt file stored on the computer, like is done in the error logging feature,
        //without having to check through the program or manually in the computer's memory (Feature #4)
        [Test]
        public void EnsureWriteToTxtFile()
        {
            StreamWriter teststreamWriter = new StreamWriter("ProgramTestFile.txt");
            teststreamWriter.WriteLine("Test");
            teststreamWriter.Flush();
            teststreamWriter.Close();
            Assert.IsNotEmpty(File.ReadAllText("ProgramTestFile.txt"));
            //Deletes file to ensure future test fidelity
            File.Delete("ProgramTestFile.txt");
            //Verifies if file has been deleted
            Assert.IsFalse(File.Exists("ProgramTestFile.txt"));
        }
        [Test]
        public void EnsureReadCsvFile()
        {
            /*StreamReader teststreamReader = new StreamReader("ProgramTestFile.csv");
            Console.WriteLine(teststreamReader.ReadToEnd());
            Console.ReadLine();*/
        }
    }
}
