using Microsoft.EntityFrameworkCore.Migrations;

namespace Clothing_Store.Migrations
{
    public partial class AddIDToCartDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CartDetails",
                table: "CartDetails");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "CartDetails",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartDetails",
                table: "CartDetails",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_CartDetails_accountID",
                table: "CartDetails",
                column: "accountID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CartDetails",
                table: "CartDetails");

            migrationBuilder.DropIndex(
                name: "IX_CartDetails_accountID",
                table: "CartDetails");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "CartDetails");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartDetails",
                table: "CartDetails",
                columns: new[] { "accountID", "productID" });
        }
    }
}
