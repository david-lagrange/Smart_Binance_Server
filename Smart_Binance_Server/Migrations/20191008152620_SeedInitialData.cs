using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Smart_Binance_Server.Migrations
{
    public partial class SeedInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ApplicationUsers",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { new Guid("58915a1e-2dbc-4cf1-8bb8-2e050982e90b"), 24, "David Lagrange" });

            migrationBuilder.InsertData(
                table: "ApplicationUsers",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { new Guid("43cee40e-03d2-4e3a-b881-af689e1d81da"), 24, "Sierra Seal" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: new Guid("43cee40e-03d2-4e3a-b881-af689e1d81da"));

            migrationBuilder.DeleteData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: new Guid("58915a1e-2dbc-4cf1-8bb8-2e050982e90b"));
        }
    }
}
