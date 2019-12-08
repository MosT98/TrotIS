using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ScooterInstanceAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Scooter",
                columns: table => new
                {
                    ScooterId = table.Column<Guid>(nullable: false),
                    Brand = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    BatteryLife = table.Column<int>(nullable: false),
                    AgeLimitMin = table.Column<int>(nullable: false),
                    AgeLimitMax = table.Column<int>(nullable: false),
                    WeightMax = table.Column<int>(nullable: false),
                    SpeedLimit = table.Column<int>(nullable: false),
                    ClimbAngle = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scooter", x => x.ScooterId);
                });

            migrationBuilder.CreateTable(
                name: "ScooterInstances",
                columns: table => new
                {
                    ScooterInstanceId = table.Column<Guid>(nullable: false),
                    ScooterAutonomy = table.Column<int>(nullable: false),
                    ScooterId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScooterInstances", x => x.ScooterInstanceId);
                    table.ForeignKey(
                        name: "FK_ScooterInstances_Scooter_ScooterId",
                        column: x => x.ScooterId,
                        principalTable: "Scooter",
                        principalColumn: "ScooterId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Scooter",
                columns: new[] { "ScooterId", "AgeLimitMax", "AgeLimitMin", "BatteryLife", "Brand", "ClimbAngle", "Model", "SpeedLimit", "WeightMax" },
                values: new object[] { new Guid("74327683-ba31-4bef-bca7-e3b23212d24d"), 25, 15, 50, "Yamaha", 85, "v2", 500, 150 });

            migrationBuilder.InsertData(
                table: "ScooterInstances",
                columns: new[] { "ScooterInstanceId", "ScooterAutonomy", "ScooterId" },
                values: new object[] { new Guid("b3451766-f082-4981-9c44-add0d8d383c3"), 7, null });

            migrationBuilder.CreateIndex(
                name: "IX_ScooterInstances_ScooterId",
                table: "ScooterInstances",
                column: "ScooterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ScooterInstances");

            migrationBuilder.DropTable(
                name: "Scooter");
        }
    }
}
