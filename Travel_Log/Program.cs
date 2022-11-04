using System;
using System.Threading;
using NUnit.Framework;

namespace The_Daily_Travel_Log
{
    //The Program class has the single responsibility of introducing the program menu and follows the Single Responsibility Principle (Part of Feature #3)
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "Travel Log";
            Console.Clear();
            Console.WriteLine("Welcome to");
            ProgramLogo.WriteLogo();
            Console.WriteLine("The time and date is:");
            Console.WriteLine(DateTime.Now.ToString("HH:mm\nMM/dd/yyyy"));
            Console.WriteLine();
            Thread.Sleep(1500);
            MainMenu.Menu();
        }
    }
}
//Thanks Mike DeMarco for the DateTime format!