using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rental_House_Management_System.Migrations.BillDb
{
    public partial class bills : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bills",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Room = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Electric_Num = table.Column<int>(type: "int", nullable: false),
                    Water_Num = table.Column<int>(type: "int", nullable: false),
                    Garbage_Fee = table.Column<int>(type: "int", nullable: false),
                    Wifi_Fee = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bills", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bills");
        }
    }
}
