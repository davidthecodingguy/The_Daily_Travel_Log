using System;
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
            Console.WriteLine("4: Quit");

            Console.WriteLine();
            string menuoption = Console.ReadLine();
            if (menuoption == "1" || menuoption == "1." || menuoption == "1:" || menuoption == "1)" || menuoption == "1 " || menuoption == "1. " || menuoption == "1: " || menuoption == "1) ")
            {
                {
                    //this menu option has not implemented yet
                    Console.WriteLine("This feature is still under development!");
                    Thread.Sleep(1500);
                    Console.WriteLine();
                    MainMenu.Menu();
                }
            }
            else if (menuoption == "2" || menuoption == "2." || menuoption == "2:" || menuoption == "2)" || menuoption == "2 " || menuoption == "2. " || menuoption == "2: " || menuoption == "2) ")
            {
                { 
                    //this menu option has not been implemented yet
                    Console.WriteLine("This feature is still under development!");
                    Thread.Sleep(1500);
                    Console.WriteLine();
                    MainMenu.Menu();
                }
            }
        }
    }
}
