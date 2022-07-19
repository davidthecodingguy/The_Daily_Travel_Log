using System;
using System.IO;
using System.Linq;
using System.Threading;

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
            
                 //this menu option is not working because I'm not invoking instances of it maybe?
                    
                    

                StreamWriter sw = new StreamWriter("previouslocations.csv", true);

                sw.WriteLine();
                sw.Flush();
                sw.Close();
                MainMenu.Menu();
             
            }
            else if (menuoption == "2" || menuoption == "2." || menuoption == "2:" || menuoption == "2)" || menuoption == "2 " || menuoption == "2. " || menuoption == "2: " || menuoption == "2) ")
            {
                //this menu option has not been implemented yet
                Console.WriteLine("This feature is still under development!");
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
                Console.WriteLine("Input not recognized, please try again!");
                Thread.Sleep(500);
                Console.WriteLine();
                MainMenu.Menu();
            }
        }
    }
}
