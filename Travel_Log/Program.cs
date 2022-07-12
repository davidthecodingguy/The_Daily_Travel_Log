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
            Console.WriteLine();
            Thread.Sleep(2000);
            Console.WriteLine("Please type the corresponding number to select an option:");
            Thread.Sleep(1000);
            Console.WriteLine("1: Log Location");
            Thread.Sleep(1000);
            Console.WriteLine("2: See Previous Locations");
            Thread.Sleep(1000);
            Console.WriteLine("3: Exit");
        }
    }
}
