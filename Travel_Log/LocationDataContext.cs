using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using NUnit.Framework;
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace The_Daily_Travel_Log
{
    public class LocationDataContext : DbContext
	{
		public DbSet<Location> Locations { get; set; }

		public string DbPath { get; set; }
		//I initialized the db but I don't see any other files when I look at files in Travel_Log folder
		public LocationDataContext()
		{
			var folder = Environment.SpecialFolder.LocalApplicationData;
			var path = Environment.GetFolderPath(folder);
			DbPath = System.IO.Path.Join(path, "locations.db");
		}
		//Will this or the above code create a path to the db or will I need to do that some other way?
		protected override void OnConfiguring(DbContextOptionsBuilder options) =>
			options.UseSqlite($"Data Source={DbPath}");
	}
    public class Location
	{

        int Id { get; set; }

		public string CurrentTown { get; set; }

		public string CurrentStateOrProvince { get; set; }

		public string CurrentCountry { get; set; }

		public DateTime CurrentDateAndTime { get; set; }
	}
}
//Thanks Doug Sutherland for the database help!