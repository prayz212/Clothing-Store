using Microsoft.EntityFrameworkCore.Migrations;

namespace Clothing_Store.Migrations
{
    public partial class AddIdToReceptDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReceipDetail_Product_ProductID",
                table: "ReceipDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_ReceipDetail_Receipt_ReceiptID",
                table: "ReceipDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReceipDetail",
                table: "ReceipDetail");

            migrationBuilder.RenameTable(
                name: "ReceipDetail",
                newName: "ReceiptDetail");

            migrationBuilder.RenameIndex(
                name: "IX_ReceipDetail_ProductID",
                table: "ReceiptDetail",
                newName: "IX_ReceiptDetail_ProductID");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "ReceiptDetail",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReceiptDetail",
                table: "ReceiptDetail",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptDetail_ReceiptID",
                table: "ReceiptDetail",
                column: "ReceiptID");

            migrationBuilder.AddForeignKey(
                name: "FK_ReceiptDetail_Product_ProductID",
                table: "ReceiptDetail",
                column: "ProductID",
                principalTable: "Product",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReceiptDetail_Receipt_ReceiptID",
                table: "ReceiptDetail",
                column: "ReceiptID",
                principalTable: "Receipt",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReceiptDetail_Product_ProductID",
                table: "ReceiptDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_ReceiptDetail_Receipt_ReceiptID",
                table: "ReceiptDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReceiptDetail",
                table: "ReceiptDetail");

            migrationBuilder.DropIndex(
                name: "IX_ReceiptDetail_ReceiptID",
                table: "ReceiptDetail");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "ReceiptDetail");

            migrationBuilder.RenameTable(
                name: "ReceiptDetail",
                newName: "ReceipDetail");

            migrationBuilder.RenameIndex(
                name: "IX_ReceiptDetail_ProductID",
                table: "ReceipDetail",
                newName: "IX_ReceipDetail_ProductID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReceipDetail",
                table: "ReceipDetail",
                columns: new[] { "ReceiptID", "ProductID" });

            migrationBuilder.AddForeignKey(
                name: "FK_ReceipDetail_Product_ProductID",
                table: "ReceipDetail",
                column: "ProductID",
                principalTable: "Product",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReceipDetail_Receipt_ReceiptID",
                table: "ReceipDetail",
                column: "ReceiptID",
                principalTable: "Receipt",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
