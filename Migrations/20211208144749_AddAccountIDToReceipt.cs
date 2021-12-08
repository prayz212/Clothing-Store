using Microsoft.EntityFrameworkCore.Migrations;

namespace Clothing_Store.Migrations
{
    public partial class AddAccountIDToReceipt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "accountID",
                table: "Receipt",
                nullable: false);

            migrationBuilder.CreateIndex(
                name: "IX_Receipt_accountID",
                table: "Receipt",
                column: "accountID");

            migrationBuilder.AddForeignKey(
                name: "FK_Receipt_Account_accountID",
                table: "Receipt",
                column: "accountID",
                principalTable: "Account",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Receipt_Account_accountID",
                table: "Receipt");

            migrationBuilder.DropIndex(
                name: "IX_Receipt_accountID",
                table: "Receipt");

            migrationBuilder.DropColumn(
                name: "accountID",
                table: "Receipt");
        }
    }
}
