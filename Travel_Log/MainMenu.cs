using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace The_Daily_Travel_Log
{
    public class MainMenu
    {
        public static void Menu()
        {
            Console.WriteLine("Please type the corresponding number and press enter to select a menu option:");
            Thread.Sleep(500);
            Console.WriteLine("1: Log Current Location");
            Thread.Sleep(500);
            Console.WriteLine("2: See All Previous Locations");
            Thread.Sleep(500);
            /*Console.WriteLine("00: Search Previous Locations");
            Thread.Sleep(500);*/
            Console.WriteLine("3: Return to Menu");
            Thread.Sleep(500);
            Console.WriteLine("4: Clear Screen");
            Thread.Sleep(500);
            Console.WriteLine("5: View Error Log (Nerds Only)");
            Thread.Sleep(500);
            Console.WriteLine("6: Quit");

            Console.WriteLine();
            //MenuOptionInputDictionary.PreviousLocationsContext();
            //Console.ReadKey();
            //if (menuoptioninput.ContainsKey("1"))
            //This is the start of the "master loop" feature listed in the project README (Feature #1) and each following menu option allows the user to input commands repeatedly.
            string menuoption = Console.ReadLine();
            if /*(menuoptioninput)*/ (menuoption == "1" || menuoption == "1." || menuoption == "1:" || menuoption == "1)" || menuoption == "1 " || menuoption == "1. " || menuoption == "1: " || menuoption == "1) ")
            //This menu option saves information input by the user and correlates to the save location/retrieve locations feature (FEATURE #2) listed in the project README
            {
                SaveAndRetrieveLocations.SaveLocation();
                Console.WriteLine();
                Thread.Sleep(1000);
                MainMenu.Menu();
            }

            else if (menuoption == "2" || menuoption == "2." || menuoption == "2:" || menuoption == "2)" || menuoption == "2 " || menuoption == "2. " || menuoption == "2: " || menuoption == "2) ")
            {
                /* need to add LINQ query. Maybe insert query at beginning

                var query = from line in File.ReadLines("PreviousLocations.csv")
                            select new
                            {
                                PreviousTown = Data[1]
                            }
                var ordered = from c in currenttown orderby c.town descending select c;*/

                //This menu option retrieves information previously input by the user correlates to the save location/retrieve locations feature (Feature #2) listed in the project README
                try
                {
                    SaveAndRetrieveLocations.RetrievePreviousLocations();
                }
                //Saves file not found errors to DailyTravelLogErrors.csv for later retrieval (Part of Feature #3)
                catch (FileNotFoundException)
                {
                    ErrorHandling.PreviousLocationsRetrievalError();
                }
                Thread.Sleep(3000);
                Console.WriteLine();
                MainMenu.Menu();
            }

            else if (menuoption == "00")
            {
                SearchPreviousLocations.LinqToSearchPreviousLocations();
                MainMenu.Menu();
            }

            else if (menuoption == "3" || menuoption == "3." || menuoption == "3:" || menuoption == "3)" || menuoption == "3 " || menuoption == "3. " || menuoption == "3: " || menuoption == "3) ")
            {
                MainMenu.Menu();
            }

            else if (menuoption == "4" || menuoption == "4." || menuoption == "4:" || menuoption == "4)" || menuoption == "4 " || menuoption == "4. " || menuoption == "4: " || menuoption == "4) ")
            {
                Console.Clear();
                Console.WriteLine("Screen cleared!");
                MainMenu.Menu();
            }

            else if (menuoption == "5" || menuoption == "5." || menuoption == "5:" || menuoption == "5)" || menuoption == "5 " || menuoption == "5. " || menuoption == "5: " || menuoption == "5) ")
            {
                //This menu option correlates to the error logging feature (Feature #3) listed in the project README and has been implemented as a menu option to aid in debugging
                try
                {
                    ErrorHandling.RetrievePreviousErrors();
                }
                //Saves file not found errors to DailyTravelLogErrors.txt for later retrieval (Part of Feature #3)
                catch (FileNotFoundException) 
                {
                    ErrorHandling.PreviousErrorsRetrievalError();
                }
                Thread.Sleep(1500);
                Console.WriteLine();
                MainMenu.Menu();
            }

            else if (menuoption == "6" || menuoption == "6." || menuoption == "6:" || menuoption == "6)" || menuoption == "6 " || menuoption == "6. " || menuoption == "6: " || menuoption == "6) ")
            //This menu option correlates to the master loop feature (Part of Feature #1) and allows the user to exit the program any time they are in the main menu
            {
                Console.WriteLine("Happy Trails!");
                Thread.Sleep(1500);
                Environment.Exit(0);
            }

            else
            {
                //Saves user input errors on the main menu to DailyTravelLogErrors.txt for later retrieval (Part of Feature #3)
                ErrorHandling.UserInputError();
                Thread.Sleep(1000);
                Console.WriteLine();
                MainMenu.Menu();
            }
        }
    }
}
//Thanks Michael Winter for the StreamWriter help!