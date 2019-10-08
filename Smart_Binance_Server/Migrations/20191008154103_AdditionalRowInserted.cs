using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Smart_Binance_Server.Migrations
{
    public partial class AdditionalRowInserted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: new Guid("43cee40e-03d2-4e3a-b881-af689e1d81da"));

            migrationBuilder.DeleteData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: new Guid("58915a1e-2dbc-4cf1-8bb8-2e050982e90b"));

            migrationBuilder.InsertData(
                table: "ApplicationUsers",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { new Guid("d385637a-f8d2-46b3-a993-e517539e827d"), 24, "David Lagrange" });

            migrationBuilder.InsertData(
                table: "ApplicationUsers",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { new Guid("ecdd3716-faf1-4926-9d47-a29750739da2"), 24, "Sierra Seal" });

            migrationBuilder.InsertData(
                table: "ApplicationUsers",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { new Guid("680971b5-43dc-4f53-a3a4-b9479e9a4176"), 5, "Roma Michele" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: new Guid("680971b5-43dc-4f53-a3a4-b9479e9a4176"));

            migrationBuilder.DeleteData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: new Guid("d385637a-f8d2-46b3-a993-e517539e827d"));

            migrationBuilder.DeleteData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: new Guid("ecdd3716-faf1-4926-9d47-a29750739da2"));

            migrationBuilder.InsertData(
                table: "ApplicationUsers",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { new Guid("58915a1e-2dbc-4cf1-8bb8-2e050982e90b"), 24, "David Lagrange" });

            migrationBuilder.InsertData(
                table: "ApplicationUsers",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { new Guid("43cee40e-03d2-4e3a-b881-af689e1d81da"), 24, "Sierra Seal" });
        }
    }
}
