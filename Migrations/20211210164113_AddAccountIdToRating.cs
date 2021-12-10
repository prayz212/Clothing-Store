using Microsoft.EntityFrameworkCore.Migrations;

namespace Clothing_Store.Migrations
{
    public partial class AddAccountIdToRating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "accountID",
                table: "Rating",
                nullable: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
