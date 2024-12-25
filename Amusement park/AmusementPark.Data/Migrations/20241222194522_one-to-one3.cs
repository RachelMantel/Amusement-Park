using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AmusementPark.Data.Migrations
{
    public partial class onetoone3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Tickets_TicketEntityId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_TicketEntityId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "TicketEntityId",
                table: "Orders");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_TicketId",
                table: "Orders",
                column: "TicketId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Tickets_TicketId",
                table: "Orders",
                column: "TicketId",
                principalTable: "Tickets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Tickets_TicketId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_TicketId",
                table: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "TicketEntityId",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_TicketEntityId",
                table: "Orders",
                column: "TicketEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Tickets_TicketEntityId",
                table: "Orders",
                column: "TicketEntityId",
                principalTable: "Tickets",
                principalColumn: "Id");
        }
    }
}
