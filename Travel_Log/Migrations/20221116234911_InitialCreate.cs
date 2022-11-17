using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace The_Daily_Travel_Log.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CurrentTown = table.Column<string>(type: "TEXT", nullable: true),
                    CurrentStateOrProvince = table.Column<string>(type: "TEXT", nullable: true),
                    CurrentCountry = table.Column<string>(type: "TEXT", nullable: true),
                    CurrentDateAndTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Locations");
        }
    }
}
