using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Smart_Binance_Server.Migrations
{
    public partial class RevertTestMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[,]
                {
                    { new Guid("64ede92e-b141-4cdb-8649-46dc9b283caa"), 24, "David Lagrange" },
                    { new Guid("8e394d0c-0977-42d6-9a95-8bb82049d1ab"), 24, "Sierra Seal" },
                    { new Guid("988b7471-21ff-469e-ba51-29ba514b7242"), 5, "Roma Michele" },
                    { new Guid("83577070-05a7-444a-8175-6963017d94ee"), 1, "Harper Lagrange" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: new Guid("64ede92e-b141-4cdb-8649-46dc9b283caa"));

            migrationBuilder.DeleteData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: new Guid("83577070-05a7-444a-8175-6963017d94ee"));

            migrationBuilder.DeleteData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: new Guid("8e394d0c-0977-42d6-9a95-8bb82049d1ab"));

            migrationBuilder.DeleteData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: new Guid("988b7471-21ff-469e-ba51-29ba514b7242"));

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
    }
}
