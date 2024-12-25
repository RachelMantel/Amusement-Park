using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AmusementPark.Data.Migrations
{
    public partial class onetomany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "facilitieId",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_facilitieId",
                table: "Employees",
                column: "facilitieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Facilities_facilitieId",
                table: "Employees",
                column: "facilitieId",
                principalTable: "Facilities",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Facilities_facilitieId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_facilitieId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "facilitieId",
                table: "Employees");
        }
    }
}
