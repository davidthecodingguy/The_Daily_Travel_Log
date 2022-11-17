using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace The_Daily_Travel_Log
{
    public class DisplayMenus
    {
        public static void MainMenu()
        {
            Console.WriteLine("Please type the corresponding number and press enter to select a menu option:");
            Thread.Sleep(500);
            Console.WriteLine("1: Log Current Location");
            Thread.Sleep(500);
            Console.WriteLine("2: See All Previous Locations");
            Thread.Sleep(500);
            Console.WriteLine("3: Return to Menu");
            Thread.Sleep(500);
            Console.WriteLine("4: Clear Screen");
            Thread.Sleep(500);
            Console.WriteLine("5: View Error Log (Nerds Only)");
            Thread.Sleep(500);
            Console.WriteLine("6: Quit");

            UserInput.MainMenuInput();
        }
    }
}