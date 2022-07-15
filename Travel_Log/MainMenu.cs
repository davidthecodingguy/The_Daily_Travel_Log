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
            Thread.Sleep(1000);
            Console.WriteLine("1: Log Location");
            Thread.Sleep(1000);
            Console.WriteLine("2: See Previous Locations");
            Thread.Sleep(1000);
            Console.WriteLine("3. Return to Menu");
            Thread.Sleep(1000);
            Console.WriteLine("4: Quit");
        }
    }
}
