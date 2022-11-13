using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using NUnit.Framework;
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.EntityFrameworkCore;
namespace The_Daily_Travel_Log
{
    //I'll probably need to put references to this in SaveData
    public class LocationDataContext : DbContext
	{
		public DbSet<Locations> Locations { get; set; }

		public string DbPath { get; set; }

		public LocationDataContext()
		{
			var folder = Environment.SpecialFolder.LocalApplicationData;
			var path = Environment.GetFolderPath(folder);
			DbPath = System.IO.Path.Join(path, "locations.db");
		}

		protected override void OnConfiguring(DbContextOptionsBuilder options) =>
			options.UseSqlite($"Data Source={DbPath}");
	}
    //How do I make sure info goes where I want it? Maybe look at Microsoft notes?
    public class Locations
	{
		public int LocationId { get; set; }
		public string CurrentTown { get; set; }
		public string CurrentStateOrProvince { get; set; }
		public string CurrentCountry { get; set; }
		public string CurrentDateAndTime { get; set; }
	}
}
//Thanks Doug Sutherland for the database help!