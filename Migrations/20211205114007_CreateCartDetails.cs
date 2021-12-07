using Microsoft.EntityFrameworkCore.Migrations;

namespace Clothing_Store.Migrations
{
    public partial class CreateCartDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateTable(
                name: "CartDetails",
                columns: table => new
                {
                    accountID = table.Column<int>(nullable: false),
                    warehouseID = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Visible = table.Column<bool>(nullable: false, defaultValue: true),
                    IsDelete = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartDetails", x => new { x.accountID, x.warehouseID });
                    table.ForeignKey(
                        name: "FK_CartDetails_Account_accountID",
                        column: x => x.accountID,
                        principalTable: "Account",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartDetails_Warehouse_warehouseID",
                        column: x => x.warehouseID,
                        principalTable: "Warehouse",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartDetails_warehouseID",
                table: "CartDetails",
                column: "warehouseID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartDetails");
        }
    }
}
