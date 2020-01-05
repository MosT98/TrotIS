using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UserAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("ec2856fc-8c84-4330-9299-15ffba7b697a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("5e076492-8603-486c-a9df-1da58256938e"));

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressId", "Apartment", "Block", "City", "Country", "County", "Floor", "Number", "Street" },
                values: new object[] { new Guid("457828fe-659e-45d0-866f-ff779243abdc"), "7A", "Solomon", "Iasi", "Romania", "Iasi", 7, 35, "Moara de foc" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "AddressId", "BirthDay", "Email", "FirstName", "LastName", "Password", "Phone", "SocialClass" },
                values: new object[] { new Guid("095b5ad5-26de-456e-867e-36c363d0fdcc"), null, new DateTime(1999, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "catalinbelu21@gmail.com", "Catalin", "Belu", "parola", "0770796616", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("457828fe-659e-45d0-866f-ff779243abdc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("095b5ad5-26de-456e-867e-36c363d0fdcc"));

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressId", "Apartment", "Block", "City", "Country", "County", "Floor", "Number", "Street" },
                values: new object[] { new Guid("ec2856fc-8c84-4330-9299-15ffba7b697a"), "7A", "Solomon", "Iasi", "Romania", "Iasi", 7, 35, "Moara de foc" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "AddressId", "BirthDay", "Email", "FirstName", "LastName", "Password", "Phone", "SocialClass" },
                values: new object[] { new Guid("5e076492-8603-486c-a9df-1da58256938e"), null, new DateTime(1999, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "catalinbelu21@gmail.com", "Catalin", "Belu", "parola", "0770796616", 1 });
        }
    }
}
