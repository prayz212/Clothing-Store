using Microsoft.EntityFrameworkCore.Migrations;

namespace Clothing_Store.Migrations
{
    public partial class AdjustReceiptOfRating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rating_Account_accountID",
                table: "Rating");

            migrationBuilder.DropIndex(
                name: "IX_Rating_accountID",
                table: "Rating");

            migrationBuilder.DropColumn(
                name: "accountID",
                table: "Rating");

            migrationBuilder.AddColumn<int>(
                name: "receiptID",
                table: "Rating",
                nullable: false);

            migrationBuilder.CreateIndex(
                name: "IX_Rating_receiptID",
                table: "Rating",
                column: "receiptID");

            migrationBuilder.AddForeignKey(
                name: "FK_Rating_Receipt_receiptID",
                table: "Rating",
                column: "receiptID",
                principalTable: "Receipt",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rating_Receipt_receiptID",
                table: "Rating");

            migrationBuilder.DropIndex(
                name: "IX_Rating_receiptID",
                table: "Rating");

            migrationBuilder.DropColumn(
                name: "receiptID",
                table: "Rating");

            migrationBuilder.AddColumn<int>(
                name: "accountID",
                table: "Rating",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rating_accountID",
                table: "Rating",
                column: "accountID");

            migrationBuilder.AddForeignKey(
                name: "FK_Rating_Account_accountID",
                table: "Rating",
                column: "accountID",
                principalTable: "Account",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
