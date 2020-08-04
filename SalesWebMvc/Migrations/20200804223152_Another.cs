using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesWebMvc.Migrations
{
    public partial class Another : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesRecord_Seller_Sellerid",
                table: "SalesRecord");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Seller",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "BithDate",
                table: "Seller",
                newName: "BirthDate");

            migrationBuilder.RenameColumn(
                name: "Sellerid",
                table: "SalesRecord",
                newName: "SellerId");

            migrationBuilder.RenameIndex(
                name: "IX_SalesRecord_Sellerid",
                table: "SalesRecord",
                newName: "IX_SalesRecord_SellerId");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesRecord_Seller_SellerId",
                table: "SalesRecord",
                column: "SellerId",
                principalTable: "Seller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesRecord_Seller_SellerId",
                table: "SalesRecord");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Seller",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "BirthDate",
                table: "Seller",
                newName: "BithDate");

            migrationBuilder.RenameColumn(
                name: "SellerId",
                table: "SalesRecord",
                newName: "Sellerid");

            migrationBuilder.RenameIndex(
                name: "IX_SalesRecord_SellerId",
                table: "SalesRecord",
                newName: "IX_SalesRecord_Sellerid");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesRecord_Seller_Sellerid",
                table: "SalesRecord",
                column: "Sellerid",
                principalTable: "Seller",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
