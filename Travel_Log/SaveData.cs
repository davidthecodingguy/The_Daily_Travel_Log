using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using NUnit.Framework;

namespace The_Daily_Travel_Log
{
    public class SaveAndRetrieveLocations
    {
        public static void SaveLocation()
        {
            string currenttown;
            string currentstateorprovince;
            string currentcountry;

            Console.WriteLine("Please note that anything typed into the following parameters will be saved to your previous locations. This means typos and all!");
            Console.WriteLine();
            Thread.Sleep(2000);

            DateTime currentDateAndTime = DateTime.Now;

            //Saves location information the user inputs to PreviousLocations.csv
            StreamWriter swriter1 = new StreamWriter("PreviousLocations.csv", true);

            Console.WriteLine("Please input the town you are currently in:");
            currenttown = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Please input the state or province you are currently in:");
            currentstateorprovince = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Please input the country you are currently in:");
            currentcountry = Console.ReadLine();
            Console.WriteLine();

            //Formats the text input by the user for easy legibility
            swriter1.WriteLine("Town: " + currenttown + " , State/Province: " + currentstateorprovince + " , Country: " + currentcountry + " , Date and Time Logged: " + currentDateAndTime);
            swriter1.Flush();
            swriter1.Close();

            Console.WriteLine("Your location information has been recorded!");
        }

        public static void RetrievePreviousLocations()
        {
            StreamReader sreader1 = new StreamReader("PreviousLocations.csv");
            Console.WriteLine(sreader1.ReadToEnd());
            sreader1.Close();
        }

    }
}
//Thanks Michael Winter for the StreamWriter help!