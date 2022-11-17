using System;
using System.Threading;
using NUnit.Framework;
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace The_Daily_Travel_Log
{
    public class ProgramStart
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
            DisplayMenus.MainMenu();
        }
    }
}
//Thanks Mike DeMarco for the DateTime format!