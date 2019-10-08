using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Smart_Binance_Server.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Age = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUsers", x => x.Id);
                });

            migrationBuilder.Sql(@"CREATE PROCEDURE MyCustomProcedure
                                   AS
                                   SELECT * FROM ApplicationUsers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUsers");

            migrationBuilder.Sql(@"DROP PROCEDURE MyCustomProcedure");
        }
    }
}
