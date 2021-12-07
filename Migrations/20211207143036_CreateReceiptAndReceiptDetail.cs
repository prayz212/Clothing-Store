using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Clothing_Store.Migrations
{
    public partial class CreateReceiptAndReceiptDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Receipt",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fullname = table.Column<string>(type: "NVARCHAR(MAX)", maxLength: 255, nullable: false),
                    Phone = table.Column<string>(maxLength: 10, nullable: false),
                    Email = table.Column<string>(maxLength: 255, nullable: false),
                    Address = table.Column<string>(type: "NVARCHAR(MAX)", maxLength: 255, nullable: false),
                    Notes = table.Column<string>(type: "NVARCHAR(MAX)", maxLength: 255, nullable: true, defaultValue: ""),
                    TotalPrice = table.Column<int>(nullable: false),
                    TotalDiscount = table.Column<int>(nullable: false, defaultValue: 0),
                    ShippingCost = table.Column<int>(nullable: false),
                    TotalPay = table.Column<int>(nullable: false),
                    Method = table.Column<string>(type: "NVARCHAR(MAX)", maxLength: 255, nullable: true, defaultValue: "COD"),
                    Status = table.Column<string>(type: "NVARCHAR(MAX)", maxLength: 255, nullable: true, defaultValue: "Đang xử lý"),
                    OrderAt = table.Column<DateTime>(nullable: false),
                    DeliveryAt = table.Column<DateTime>(nullable: false),
                    CardNumber = table.Column<string>(maxLength: 12, nullable: true),
                    ValidDate = table.Column<DateTime>(nullable: false),
                    SecretNumber = table.Column<string>(maxLength: 7, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receipt", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ReceipDetail",
                columns: table => new
                {
                    ProductID = table.Column<int>(nullable: false),
                    ReceiptID = table.Column<int>(nullable: false),
                    Size = table.Column<string>(maxLength: 10, nullable: false),
                    Color = table.Column<string>(type: "NVARCHAR(MAX)", maxLength: 50, nullable: false),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceipDetail", x => new { x.ReceiptID, x.ProductID });
                    table.ForeignKey(
                        name: "FK_ReceipDetail_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReceipDetail_Receipt_ReceiptID",
                        column: x => x.ReceiptID,
                        principalTable: "Receipt",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReceipDetail_ProductID",
                table: "ReceipDetail",
                column: "ProductID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReceipDetail");

            migrationBuilder.DropTable(
                name: "Receipt");
        }
    }
}
