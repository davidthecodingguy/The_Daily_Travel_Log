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
            Console.WriteLine("2: See Previous Locations");
            Thread.Sleep(500);
            Console.WriteLine("3: Return to Menu");
            Thread.Sleep(500);
            Console.WriteLine("4: Clear Screen");
            Thread.Sleep(500);
            Console.WriteLine("5: Quit");

            Console.WriteLine();
            string menuoption = Console.ReadLine();
            if (menuoption == "1" || menuoption == "1." || menuoption == "1:" || menuoption == "1)" || menuoption == "1 " || menuoption == "1. " || menuoption == "1: " || menuoption == "1) ")
            {
                //Keeps saving files to new csv files. Might need a path?
                string currenttown;
                string currentstateorprovince;
                string currentcountry;
                string currentdate;

                StreamWriter sw1 = new StreamWriter("PreviousLocations.csv", true);

                Console.WriteLine("Please input the town you are currently in:");
                currenttown = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Please input the state or province you are currently in:");
                currentstateorprovince = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Please input the country you are currently in:");
                currentcountry = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Please input the current date (format MM/DD/YYYY):");
                currentdate = Console.ReadLine();
                Console.WriteLine();

                sw1.WriteLine("Town: " + currenttown + " State/Province: " + currentstateorprovince + " Country: " + currentcountry + " Date: " + currentdate);
                sw1.Flush();
                sw1.Close();

                Console.WriteLine("Your location information has been recorded!");
                Console.WriteLine();
                Thread.Sleep(1000);
                MainMenu.Menu();
            }
            else if (menuoption == "2" || menuoption == "2." || menuoption == "2:" || menuoption == "2)" || menuoption == "2 " || menuoption == "2. " || menuoption == "2: " || menuoption == "2) ")
            {
                /*this menu option has not been added yet. need to add LINQ query. Maybe insert query at beginning

                var query = from line in File.ReadLines("PreviousLocations.csv")
                            select new
                            {
                                PreviousTown = Data[1]
                            }
                var ordered = from c in currenttown orderby c.town descending select c;*/

                try
                {
                    StreamReader sr1 = new StreamReader("PreviousLocations.csv"); 
                    Console.WriteLine(sr1.ReadToEnd());
                    sr1.Close();
                }
                catch
                {
                    Console.WriteLine("The file could not be found! Please make sure the file PreviousLocations.csv has not been deleted or renamed and try again!");
                    StreamWriter sw2 = new StreamWriter("DailyTravelLogErrors.csv", true);
                    sw2.WriteLine("Error: The file PreviousLocations.csv could not be found.");
                    sw2.Flush();
                    sw2.Close();
                    //might need to put in readme that the user will have to search for the file under DailyTravelLogErrors.csv in they wish to view the error log
                }
                Thread.Sleep(1500);
                Console.WriteLine();
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
                Console.WriteLine("Until next time!");
                Thread.Sleep(1500);
                Environment.Exit(0);
            }
            else
            {
                //Maybe put in a menu option to see previous errors?
                Console.WriteLine("Input not recognized, please try again!");
                StreamWriter sw3 = new StreamWriter("DailyTravelLogErrors.csv", true);
                sw3.WriteLine("User Input Error");
                sw3.Flush();
                sw3.Close();

                Thread.Sleep(500);
                Console.WriteLine();
                MainMenu.Menu();
            }
        }
    }
}
//Thanks Michael Winter for the StreamWriter help!