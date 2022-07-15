using System;
using System.Threading;

namespace The_Daily_Travel_Log
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "Travel Log";
            Console.Clear();
            Console.WriteLine("Welcome to The Daily Travel Log!");
            Console.WriteLine("The time and date is:");
            Console.WriteLine(DateTime.Now.ToString("HH:mm\nMM/dd/yyyy"));
            Console.WriteLine();
            Thread.Sleep(2000);
            MainMenu.Menu();
        }
    }
}
