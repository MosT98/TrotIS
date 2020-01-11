using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ScooterInstanceAPI.Migrations
{
    public partial class scooterInstMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Scooters",
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
                    ClimbAngle = table.Column<int>(nullable: false),
                    ImgName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scooters", x => x.ScooterId);
                });

            migrationBuilder.CreateTable(
                name: "ScooterInstances",
                columns: table => new
                {
                    ScooterInstanceId = table.Column<Guid>(nullable: false),
                    ScooterAutonomy = table.Column<int>(nullable: false),
                    ScooterId = table.Column<Guid>(nullable: true),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScooterInstances", x => x.ScooterInstanceId);
                    table.ForeignKey(
                        name: "FK_ScooterInstances_Scooters_ScooterId",
                        column: x => x.ScooterId,
                        principalTable: "Scooters",
                        principalColumn: "ScooterId",
                        onDelete: ReferentialAction.Restrict);
                });

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
                name: "Scooters");
        }
    }
}
