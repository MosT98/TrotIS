using Microsoft.EntityFrameworkCore.Migrations;

namespace ScooterInstanceAPI.Migrations
{
    public partial class PriceAddedOnScooterInstances : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "ScooterInstances",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "ScooterInstances");
        }
    }
}
