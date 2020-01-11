using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RentAPI.Migrations
{
    public partial class rentMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rents",
                columns: table => new
                {
                    RentId = table.Column<Guid>(nullable: false),
                    LocationId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    ScooterInstanceId = table.Column<Guid>(nullable: false),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    IsCancelled = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rents", x => x.RentId);
                });

            migrationBuilder.InsertData(
                table: "Rents",
                columns: new[] { "RentId", "EndDate", "IsCancelled", "LocationId", "OrderDate", "ScooterInstanceId", "StartDate", "UserId" },
                values: new object[] { new Guid("f2c7dbe2-9f6c-4219-9240-9610ca09b3d9"), new DateTime(2000, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new Guid("e5cf7f23-0146-4a4a-8322-d1209cf747d0"), new DateTime(2020, 1, 11, 13, 32, 56, 100, DateTimeKind.Utc).AddTicks(2104), new Guid("47364138-912d-4ea2-b59f-eca02e4d8db7"), new DateTime(1999, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("843e8cb6-4928-4bb8-85ca-2412ff35a3eb") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rents");
        }
    }
}
