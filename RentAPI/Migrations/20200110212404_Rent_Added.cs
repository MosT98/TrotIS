using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RentAPI.Migrations
{
    public partial class Rent_Added : Migration
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
                    RentDate = table.Column<DateTime>(nullable: false),
                    IsCancelled = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rents", x => x.RentId);
                });

            migrationBuilder.InsertData(
                table: "Rents",
                columns: new[] { "RentId", "IsCancelled", "LocationId", "RentDate", "ScooterInstanceId", "UserId" },
                values: new object[] { new Guid("3666b1ef-c954-4b2a-b97a-5cc9a7ca12f8"), false, new Guid("e5cf7f23-0146-4a4a-8322-d1209cf737d0"), new DateTime(2019, 1, 3, 6, 0, 0, 0, DateTimeKind.Unspecified), new Guid("47364138-912d-4ea2-b59f-eca02e4d8db7"), new Guid("843e8cb6-4928-4bb8-85ca-2412ff36a3eb") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rents");
        }
    }
}
