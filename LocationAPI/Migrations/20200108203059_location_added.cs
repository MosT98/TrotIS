using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LocationAPI.Migrations
{
    public partial class location_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LinkLocationsToScooterInstances",
                columns: table => new
                {
                    LocationID = table.Column<Guid>(nullable: false),
                    ScooterInstanceID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LinkLocationsToScooterInstances", x => new { x.LocationID, x.ScooterInstanceID });
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocationID = table.Column<Guid>(nullable: false),
                    AddressID = table.Column<Guid>(nullable: false),
                    valid = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationID);
                });

            migrationBuilder.InsertData(
                table: "LinkLocationsToScooterInstances",
                columns: new[] { "LocationID", "ScooterInstanceID" },
                values: new object[] { new Guid("b4b821df-fac2-4b76-b4ac-10f3dd1ce8ce"), new Guid("65a1ecd5-5ac1-434b-8c35-1bedcee04dd4") });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationID", "AddressID", "valid" },
                values: new object[] { new Guid("b4b821df-fac2-4b76-b4ac-10f3dd1ce8ce"), new Guid("6719bc69-b700-40a3-8c00-ecf14eb977cd"), true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LinkLocationsToScooterInstances");

            migrationBuilder.DropTable(
                name: "Locations");
        }
    }
}
