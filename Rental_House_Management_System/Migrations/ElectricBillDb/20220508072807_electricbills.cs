using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rental_House_Management_System.Migrations.ElectricBillDb
{
    public partial class electricbills : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "electricbills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Electric_Number = table.Column<int>(type: "int", nullable: false),
                    Electric_Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_electricbills", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "electricbills");
        }
    }
}
