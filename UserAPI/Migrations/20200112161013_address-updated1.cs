using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UserAPI.Migrations
{
    public partial class addressupdated1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    AddressId = table.Column<Guid>(nullable: false),
                    Country = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    Number = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.AddressId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    BirthDay = table.Column<DateTime>(nullable: false),
                    SocialClass = table.Column<int>(nullable: false),
                    AddressId = table.Column<Guid>(nullable: true),
                    IsAdmin = table.Column<bool>(nullable: false),
                    DTE_CRE = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressId", "City", "Country", "Number", "Street" },
                values: new object[] { new Guid("1e870629-83db-4661-b16e-d41ddaf8783c"), "Iasi", "Romania", 35, "Moara de foc" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "AddressId", "BirthDay", "DTE_CRE", "Email", "FirstName", "IsAdmin", "LastName", "Password", "Phone", "SocialClass" },
                values: new object[] { new Guid("cd0d4451-14db-4cc6-8705-405fe79e7e8d"), null, new DateTime(1999, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 12, 16, 10, 12, 853, DateTimeKind.Utc).AddTicks(8546), "catalinbelu21@gmail.com", "Catalin", false, "Belu", "parola", "0770796616", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Users_AddressId",
                table: "Users",
                column: "AddressId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Addresses");
        }
    }
}
