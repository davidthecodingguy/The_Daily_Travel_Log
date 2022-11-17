using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace The_Daily_Travel_Log
{
    public class UserInput
    {
        public static void MainMenuInput()
        {
            Console.WriteLine();
            string menuoption = Console.ReadLine();
            if (menuoption == "1" || menuoption == "1." || menuoption == "1:" || menuoption == "1)" || menuoption == "1 " || menuoption == "1. " || menuoption == "1: " || menuoption == "1) ")
            {
                SaveData.SaveLocation();
                Console.WriteLine();
                Thread.Sleep(1000);
                DisplayMenus.MainMenu();
            }

            else if (menuoption == "2" || menuoption == "2." || menuoption == "2:" || menuoption == "2)" || menuoption == "2 " || menuoption == "2. " || menuoption == "2: " || menuoption == "2) ")
            {
                //Displays previous locations information in a user friendly format
                try
                {
                    //Values from the list are used for previous location display (Part of Feature #3) 
                    var locations = RetrieveData.RetrievePreviousLocations();
                    foreach (var location in locations)
                    {
                        Console.WriteLine(location.CurrentDateAndTime + " Town: " + location.CurrentTown + " State/Province: " + location.CurrentStateOrProvince + " Country: " + location.CurrentCountry);
                    }
                }
                //Displays error warnings and saves issues reaching the database to DailyTravelLogErrors.csv for later retrieval (Part of Feature #2)
                catch
                {
                    ErrorHandling.PreviousLocationsRetrievalError();
                }
                Thread.Sleep(3000);
                Console.WriteLine();
                DisplayMenus.MainMenu();
            }

            else if (menuoption == "3" || menuoption == "3." || menuoption == "3:" || menuoption == "3)" || menuoption == "3 " || menuoption == "3. " || menuoption == "3: " || menuoption == "3) ")
            {
                DisplayMenus.MainMenu();
            }

            else if (menuoption == "4" || menuoption == "4." || menuoption == "4:" || menuoption == "4)" || menuoption == "4 " || menuoption == "4. " || menuoption == "4: " || menuoption == "4) ")
            {
                Console.Clear();
                Console.WriteLine("Screen cleared!");
                DisplayMenus.MainMenu();
            }

            else if (menuoption == "5" || menuoption == "5." || menuoption == "5:" || menuoption == "5)" || menuoption == "5 " || menuoption == "5. " || menuoption == "5: " || menuoption == "5) ")
            //This menu option correlates to the error logging feature (Feature #2) listed in the project README and has been implemented as a menu option to aid in debugging
            {
                try
                {
                    RetrieveData.RetrievePreviousErrors();
                }
                //Displays error warnings and saves file not found errors to DailyTravelLogErrors.txt for later retrieval (Part of Feature #2)
                catch (FileNotFoundException)
                {
                    ErrorHandling.PreviousErrorsRetrievalError();
                }
                Thread.Sleep(1500);
                Console.WriteLine();
                DisplayMenus.MainMenu();
            }

            else if (menuoption == "6" || menuoption == "6." || menuoption == "6:" || menuoption == "6)" || menuoption == "6 " || menuoption == "6. " || menuoption == "6: " || menuoption == "6) ")
            {
                Console.WriteLine("Happy Trails!");
                Thread.Sleep(1500);
                Environment.Exit(0);
            }

            else
            //Displays error warnings and saves user input errors on the main menu to DailyTravelLogErrors.txt for later retrieval (Part of Feature #2)
            {
                ErrorHandling.UserInputError();
                Thread.Sleep(1000);
                Console.WriteLine();
                DisplayMenus.MainMenu();
            }
        }
    }
}

