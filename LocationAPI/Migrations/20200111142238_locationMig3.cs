using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LocationAPI.Migrations
{
    public partial class locationMig3 : Migration
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
                    Longitude = table.Column<decimal>(nullable: false),
                    Latitude = table.Column<decimal>(nullable: false),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationID);
                });

            migrationBuilder.InsertData(
                table: "LinkLocationsToScooterInstances",
                columns: new[] { "LocationID", "ScooterInstanceID" },
                values: new object[] { new Guid("dd9cc90c-dd61-474d-abec-a288458eaad9"), new Guid("65a1ecd5-5ac1-434b-8c35-1bedcee04dd4") });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationID", "Comment", "Latitude", "Longitude" },
                values: new object[] { new Guid("dd9cc90c-dd61-474d-abec-a288458eaad9"), "TrotIS Center, Faculty of Computer Science", 47.1739724m, 27.5743639m });
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
