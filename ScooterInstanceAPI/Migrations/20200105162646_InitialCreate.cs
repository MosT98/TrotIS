using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ScooterInstanceAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Scooter",
                keyColumn: "ScooterId",
                keyValue: new Guid("74327683-ba31-4bef-bca7-e3b23212d24d"));

            migrationBuilder.DeleteData(
                table: "ScooterInstances",
                keyColumn: "ScooterInstanceId",
                keyValue: new Guid("b3451766-f082-4981-9c44-add0d8d383c3"));

            migrationBuilder.InsertData(
                table: "Scooter",
                columns: new[] { "ScooterId", "AgeLimitMax", "AgeLimitMin", "BatteryLife", "Brand", "ClimbAngle", "Model", "SpeedLimit", "WeightMax" },
                values: new object[] { new Guid("6f9b6ef3-31d9-4f16-bb45-a6235aba003b"), 25, 15, 50, "Yamaha", 85, "v2", 500, 150 });

            migrationBuilder.InsertData(
                table: "ScooterInstances",
                columns: new[] { "ScooterInstanceId", "ScooterAutonomy", "ScooterId" },
                values: new object[] { new Guid("f05b7547-502f-4286-8aa2-d80df326b90c"), 7, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Scooter",
                keyColumn: "ScooterId",
                keyValue: new Guid("6f9b6ef3-31d9-4f16-bb45-a6235aba003b"));

            migrationBuilder.DeleteData(
                table: "ScooterInstances",
                keyColumn: "ScooterInstanceId",
                keyValue: new Guid("f05b7547-502f-4286-8aa2-d80df326b90c"));

            migrationBuilder.InsertData(
                table: "Scooter",
                columns: new[] { "ScooterId", "AgeLimitMax", "AgeLimitMin", "BatteryLife", "Brand", "ClimbAngle", "Model", "SpeedLimit", "WeightMax" },
                values: new object[] { new Guid("74327683-ba31-4bef-bca7-e3b23212d24d"), 25, 15, 50, "Yamaha", 85, "v2", 500, 150 });

            migrationBuilder.InsertData(
                table: "ScooterInstances",
                columns: new[] { "ScooterInstanceId", "ScooterAutonomy", "ScooterId" },
                values: new object[] { new Guid("b3451766-f082-4981-9c44-add0d8d383c3"), 7, null });
        }
    }
}
