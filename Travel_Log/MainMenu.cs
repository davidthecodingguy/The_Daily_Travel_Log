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
            Console.WriteLine("Please type the corresponding number to select an option:");
            Thread.Sleep(500);
            Console.WriteLine("1: Log Location");
            Thread.Sleep(500);
            Console.WriteLine("2: See All Previous Locations");
            Thread.Sleep(500);
            Console.WriteLine("00: Search Previous Locations");
            Thread.Sleep(500);
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
                string currenttown;
                string currentstateorprovince;
                string currentcountry;

                Console.WriteLine("Please note that anything typed into the following parameters will be saved to your previous locations. This means typos and all!");
                Console.WriteLine();
                Thread.Sleep(2000);

                DateTime currentDateAndTime = DateTime.Now;

                //Saves location information the user inputs to PreviousLocations.csv (Part of Feature #2)
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

                //Formats the text input by the user for easy legibility (Part of Feature #2)
                swriter1.WriteLine("Date and Time Logged: " + currentDateAndTime + " | Town: " + currenttown + " | State/Province: " + currentstateorprovince + " | Country: " + currentcountry);
                swriter1.Flush();
                swriter1.Close();

                Console.WriteLine("Your location information has been recorded!");
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
                    StreamReader sreader1 = new StreamReader("PreviousLocations.csv");
                    Console.WriteLine(sreader1.ReadToEnd());
                    sreader1.Close();
                }
                //Saves file not found errors to DailyTravelLogErrors.csv for later retrieval (Part of Feature #3)
                catch
                {
                    Console.WriteLine("The file could not be found! Either make your first location entry or make sure the file PreviousLocations.csv has not been deleted or renamed!");
                    StreamWriter swriter2 = new StreamWriter("DailyTravelLogErrors.csv", true);
                    DateTime errorDateAndTime = DateTime.Now;
                    swriter2.WriteLine(errorDateAndTime + " Error: Could not find PreviousLocations.csv");
                    swriter2.Flush();
                    swriter2.Close();
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
                    StreamReader sreader2 = new StreamReader("DailyTravelLogErrors.csv");
                    Console.WriteLine("You are viewing a list of previously logged errors when attempting to access options in the main menu or the PreviousLocations.csv file:");
                    Console.WriteLine(sreader2.ReadToEnd());
                    sreader2.Close();
                }
                //Saves file not found errors to DailyTravelLogErrors.csv for later retrieval (Part of Feature #3)
                catch
                {
                    Console.WriteLine("The file could not be found! Either make your first mistake or make sure the file DailyTravelLogErrors.csv has not been deleted or renamed!");
                    StreamWriter swriter3 = new StreamWriter("DailyTravelLogErrors.csv", true);
                    DateTime errorDateAndTime = DateTime.Now;
                    swriter3.WriteLine(errorDateAndTime + " Error: Could not find DailyTravelLogErrors.csv");
                    swriter3.Flush();
                    swriter3.Close();
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
                //Saves user input errors on the main menu to DailyTravelLogErrors.csv for later retrieval (Part of Feature #3)
                Console.WriteLine("Input not recognized, please try again!");
                StreamWriter swriter4 = new StreamWriter("DailyTravelLogErrors.csv", true);
                DateTime errorDateAndTime = DateTime.Now;
                swriter4.WriteLine(errorDateAndTime + " Error: User input was not recognized");
                swriter4.Flush();
                swriter4.Close();

                Thread.Sleep(1000);
                Console.WriteLine();
                MainMenu.Menu();
            }
        }
    }
}
//Thanks Michael Winter for the StreamWriter help!