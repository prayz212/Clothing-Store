using Microsoft.EntityFrameworkCore.Migrations;

namespace Clothing_Store.Migrations
{
    public partial class AdjustCartDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartDetails_Warehouse_warehouseID",
                table: "CartDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CartDetails",
                table: "CartDetails");

            migrationBuilder.DropIndex(
                name: "IX_CartDetails_warehouseID",
                table: "CartDetails");

            migrationBuilder.DropColumn(
                name: "warehouseID",
                table: "CartDetails");

            migrationBuilder.AddColumn<int>(
                name: "productID",
                table: "CartDetails",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartDetails",
                table: "CartDetails",
                columns: new[] { "accountID", "productID" });

            migrationBuilder.CreateIndex(
                name: "IX_CartDetails_productID",
                table: "CartDetails",
                column: "productID");

            migrationBuilder.AddForeignKey(
                name: "FK_CartDetails_Product_productID",
                table: "CartDetails",
                column: "productID",
                principalTable: "Product",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartDetails_Product_productID",
                table: "CartDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CartDetails",
                table: "CartDetails");

            migrationBuilder.DropIndex(
                name: "IX_CartDetails_productID",
                table: "CartDetails");

            migrationBuilder.DropColumn(
                name: "productID",
                table: "CartDetails");

            migrationBuilder.AddColumn<int>(
                name: "warehouseID",
                table: "CartDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartDetails",
                table: "CartDetails",
                columns: new[] { "accountID", "warehouseID" });

            migrationBuilder.CreateIndex(
                name: "IX_CartDetails_warehouseID",
                table: "CartDetails",
                column: "warehouseID");

            migrationBuilder.AddForeignKey(
                name: "FK_CartDetails_Warehouse_warehouseID",
                table: "CartDetails",
                column: "warehouseID",
                principalTable: "Warehouse",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
