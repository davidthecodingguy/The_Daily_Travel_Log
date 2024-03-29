﻿using System;
using System.IO;
using System.Threading;
using NUnit.Compatibility;
using NUnit.Framework;
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace The_Daily_Travel_Log
{
    [TestFixture]
    public class SaveDataTests
    //These unit tests correlate to the unit tests feature listed on the project README (Feature #1) and have been implemented to aid in debugging and ensure the program continues to function as intended
    {
        //TEST TYPE #1: Tests to ensure the program is writing to a txt file stored on the computer, like is done in the error logging feature, without having to run the program or check the computer's memory manually (Part of Feature #1)
        [Test]
        public void EnsureWriteToTxtFile()
        {
            ErrorHandling.UserInputError();
            Assert.IsNotEmpty(File.ReadAllText("DailyTravelLogErrors.txt"));
        }
    }
}