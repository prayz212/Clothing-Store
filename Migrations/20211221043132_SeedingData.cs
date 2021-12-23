using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Clothing_Store.Migrations
{
    public partial class SeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Image_Product_productID",
                table: "Image");

            migrationBuilder.DropForeignKey(
                name: "FK_Rating_Product_productID",
                table: "Rating");

            migrationBuilder.DropForeignKey(
                name: "FK_Rating_Receipt_receiptID",
                table: "Rating");

            migrationBuilder.DropForeignKey(
                name: "FK_Warehouse_Product_productID",
                table: "Warehouse");

            migrationBuilder.RenameColumn(
                name: "productID",
                table: "Warehouse",
                newName: "ProductID");

            migrationBuilder.RenameIndex(
                name: "IX_Warehouse_productID",
                table: "Warehouse",
                newName: "IX_Warehouse_ProductID");

            migrationBuilder.RenameColumn(
                name: "receiptID",
                table: "Rating",
                newName: "ReceiptID");

            migrationBuilder.RenameColumn(
                name: "productID",
                table: "Rating",
                newName: "ProductID");

            migrationBuilder.RenameIndex(
                name: "IX_Rating_receiptID",
                table: "Rating",
                newName: "IX_Rating_ReceiptID");

            migrationBuilder.RenameIndex(
                name: "IX_Rating_productID",
                table: "Rating",
                newName: "IX_Rating_ProductID");

            migrationBuilder.RenameColumn(
                name: "productID",
                table: "Image",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Image_productID",
                table: "Image",
                newName: "IX_Image_ProductId");

            migrationBuilder.AlterColumn<int>(
                name: "ReceiptID",
                table: "Rating",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductID",
                table: "Rating",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Image_Product_ProductId",
                table: "Image",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rating_Product_ProductID",
                table: "Rating",
                column: "ProductID",
                principalTable: "Product",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rating_Receipt_ReceiptID",
                table: "Rating",
                column: "ReceiptID",
                principalTable: "Receipt",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Warehouse_Product_ProductID",
                table: "Warehouse",
                column: "ProductID",
                principalTable: "Product",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "ID", "Email", "IsDelete", "Password", "Username" },
                values: new object[,]
                {
                    { 1, "diecluchivi2701@gmail.com", false, "$2a$11$/VFMOT9NcFNk1NmgvPTL/OJ7gpBru8bSoT6XjDiAF2xIEMb6lsTbi", "vidiec" },
                    { 15, "admin3@coolmate.edu.vn", false, "$2a$11$/VFMOT9NcFNk1NmgvPTL/OJ7gpBru8bSoT6XjDiAF2xIEMb6lsTbi", "admin3" },
                    { 14, "admin2@coolmate.edu.vn", false, "$2a$11$/VFMOT9NcFNk1NmgvPTL/OJ7gpBru8bSoT6XjDiAF2xIEMb6lsTbi", "admin2" },
                    { 12, "khoidang@student.tdtu.edu.vn", false, "$2a$11$/VFMOT9NcFNk1NmgvPTL/OJ7gpBru8bSoT6XjDiAF2xIEMb6lsTbi", "khoidang" },
                    { 11, "huyhua@student.tdtu.edu.vn", false, "$2a$11$/VFMOT9NcFNk1NmgvPTL/OJ7gpBru8bSoT6XjDiAF2xIEMb6lsTbi", "huyhua" },
                    { 10, "huytran@student.tdtu.edu.vn", false, "$2a$11$/VFMOT9NcFNk1NmgvPTL/OJ7gpBru8bSoT6XjDiAF2xIEMb6lsTbi", "huytran" },
                    { 9, "tungtran@student.tdtu.edu.vn", false, "$2a$11$/VFMOT9NcFNk1NmgvPTL/OJ7gpBru8bSoT6XjDiAF2xIEMb6lsTbi", "tungtran" },
                    { 13, "admin1@coolmate.edu.vn", false, "$2a$11$/VFMOT9NcFNk1NmgvPTL/OJ7gpBru8bSoT6XjDiAF2xIEMb6lsTbi", "admin1" },
                    { 7, "huyhuy@student.tdtu.edu.vn", false, "$2a$11$/VFMOT9NcFNk1NmgvPTL/OJ7gpBru8bSoT6XjDiAF2xIEMb6lsTbi", "huyhuy" },
                    { 6, "quynhha@student.tdtu.edu.vn", false, "$2a$11$/VFMOT9NcFNk1NmgvPTL/OJ7gpBru8bSoT6XjDiAF2xIEMb6lsTbi", "quynhha" },
                    { 5, "nhily@student.tdtu.edu.vn", false, "$2a$11$/VFMOT9NcFNk1NmgvPTL/OJ7gpBru8bSoT6XjDiAF2xIEMb6lsTbi", "nhily" },
                    { 4, "hongtran@student.tdtu.edu.vn", false, "$2a$11$/VFMOT9NcFNk1NmgvPTL/OJ7gpBru8bSoT6XjDiAF2xIEMb6lsTbi", "hongtran" },
                    { 3, "trannguyen@student.tdtu.edu.vn", false, "$2a$11$/VFMOT9NcFNk1NmgvPTL/OJ7gpBru8bSoT6XjDiAF2xIEMb6lsTbi", "trannguyen" },
                    { 2, "camphu480@gmail.com", false, "$2a$11$/VFMOT9NcFNk1NmgvPTL/OJ7gpBru8bSoT6XjDiAF2xIEMb6lsTbi", "phutang" },
                    { 8, "thanhthanh@student.tdtu.edu.vn", false, "$2a$11$/VFMOT9NcFNk1NmgvPTL/OJ7gpBru8bSoT6XjDiAF2xIEMb6lsTbi", "thanhthanh" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "Description", "IsDelete", "Name", "Price", "ProductType", "Visible" },
                values: new object[,]
                {
                    { 68, "Lắng nghe khách hàng của mình và hiểu được mỗi chàng trai đều cần có trong tủ đồ mình 1 chiếc quần đặc biệt thoải mái trong mọi vận động. Và Coolmate đặc biệt cho ra mắt sản phẩm Quần phiên bản mới với chất liệu vải 100% Polyester PTT đặc biệt CO GIÃN TUYỆT VỜI đem đến sự thoải mái tối đa.", false, "Quần Dài QD006", 199000, "Quần dài", true },
                    { 69, "Lắng nghe khách hàng của mình và hiểu được mỗi chàng trai đều cần có trong tủ đồ mình 1 chiếc quần đặc biệt thoải mái trong mọi vận động. Và Coolmate đặc biệt cho ra mắt sản phẩm Quần phiên bản mới với chất liệu vải 100% Polyester PTT đặc biệt CO GIÃN TUYỆT VỜI đem đến sự thoải mái tối đa.", false, "Quần Dài QD007", 230000, "Quần dài", true },
                    { 70, "Lắng nghe khách hàng của mình và hiểu được mỗi chàng trai đều cần có trong tủ đồ mình 1 chiếc quần đặc biệt thoải mái trong mọi vận động. Và Coolmate đặc biệt cho ra mắt sản phẩm Quần phiên bản mới với chất liệu vải 100% Polyester PTT đặc biệt CO GIÃN TUYỆT VỜI đem đến sự thoải mái tối đa.", false, "Quần Dài QD008", 230000, "Quần dài", true },
                    { 71, "Lắng nghe khách hàng của mình và hiểu được mỗi chàng trai đều cần có trong tủ đồ mình 1 chiếc quần đặc biệt thoải mái trong mọi vận động. Và Coolmate đặc biệt cho ra mắt sản phẩm Quần phiên bản mới với chất liệu vải 100% Polyester PTT đặc biệt CO GIÃN TUYỆT VỜI đem đến sự thoải mái tối đa.", false, "Quần Dài QD009", 199000, "Quần dài", true },
                    { 75, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Dài QD013", 199000, "Quần dài", true },
                    { 73, "Lắng nghe khách hàng của mình và hiểu được mỗi chàng trai đều cần có trong tủ đồ mình 1 chiếc quần đặc biệt thoải mái trong mọi vận động. Và Coolmate đặc biệt cho ra mắt sản phẩm Quần phiên bản mới với chất liệu vải 100% Polyester PTT đặc biệt CO GIÃN TUYỆT VỜI đem đến sự thoải mái tối đa.", false, "Quần Dài QD011", 199000, "Quần dài", true },
                    { 74, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Dài QD012", 230000, "Quần dài", true },
                    { 76, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Dài QD014", 230000, "Quần dài", true },
                    { 67, "Lắng nghe khách hàng của mình và hiểu được mỗi chàng trai đều cần có trong tủ đồ mình 1 chiếc quần đặc biệt thoải mái trong mọi vận động. Và Coolmate đặc biệt cho ra mắt sản phẩm Quần phiên bản mới với chất liệu vải 100% Polyester PTT đặc biệt CO GIÃN TUYỆT VỜI đem đến sự thoải mái tối đa.", false, "Quần Dài QD005", 230000, "Quần dài", true },
                    { 72, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Dài QD010", 199000, "Quần dài", true },
                    { 66, "Lắng nghe khách hàng của mình và hiểu được mỗi chàng trai đều cần có trong tủ đồ mình 1 chiếc quần đặc biệt thoải mái trong mọi vận động. Và Coolmate đặc biệt cho ra mắt sản phẩm Quần phiên bản mới với chất liệu vải 100% Polyester PTT đặc biệt CO GIÃN TUYỆT VỜI đem đến sự thoải mái tối đa.", false, "Quần Dài QD004", 199000, "Quần dài", true },
                    { 59, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu modal (gỗ sồi), sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo sơ mi Modal này có gì đặc biệt nhé!", false, "Áo Sơ Mi N010", 230000, "Áo sơ mi tay ngắn", true },
                    { 64, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Dài QD002", 230000, "Quần dài", true },
                    { 63, "Lắng nghe khách hàng của mình và hiểu được mỗi chàng trai đều cần có trong tủ đồ mình 1 chiếc quần đặc biệt thoải mái trong mọi vận động. Và Coolmate đặc biệt cho ra mắt sản phẩm Quần phiên bản mới với chất liệu vải 100% Polyester PTT đặc biệt CO GIÃN TUYỆT VỜI đem đến sự thoải mái tối đa.", false, "Quần Dài QD001", 230000, "Quần dài", true },
                    { 62, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu bamboo (vải tre) Ex-Soft này, sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo bamboo này có gì đặc biệt nhé!", false, "Áo Sơ Mi N013", 230000, "Áo sơ mi tay ngắn", true },
                    { 61, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu bamboo (vải tre) Ex-Soft này, sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo bamboo này có gì đặc biệt nhé!", false, "Áo Sơ Mi N012", 230000, "Áo sơ mi tay ngắn", true },
                    { 60, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu modal (gỗ sồi), sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo sơ mi Modal này có gì đặc biệt nhé!", false, "Áo Sơ Mi N011", 230000, "Áo sơ mi tay ngắn", true },
                    { 77, "Lắng nghe khách hàng của mình và hiểu được mỗi chàng trai đều cần có trong tủ đồ mình 1 chiếc quần đặc biệt thoải mái trong mọi vận động. Và Coolmate đặc biệt cho ra mắt sản phẩm Quần phiên bản mới với chất liệu vải 100% Polyester PTT đặc biệt CO GIÃN TUYỆT VỜI đem đến sự thoải mái tối đa.", false, "Quần Dài QD015", 199000, "Quần dài", true },
                    { 58, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu modal (gỗ sồi), sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo sơ mi Modal này có gì đặc biệt nhé!", false, "Áo Sơ Mi N009", 230000, "Áo sơ mi tay ngắn", true },
                    { 57, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu modal (gỗ sồi), sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo sơ mi Modal này có gì đặc biệt nhé!", false, "Áo Sơ Mi N008", 230000, "Áo sơ mi tay ngắn", true },
                    { 56, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu modal (gỗ sồi), sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo sơ mi Modal này có gì đặc biệt nhé!", false, "Áo Sơ Mi N007", 230000, "Áo sơ mi tay ngắn", true },
                    { 55, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu modal (gỗ sồi), sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo sơ mi Modal này có gì đặc biệt nhé!", false, "Áo Sơ Mi N006", 230000, "Áo sơ mi tay ngắn", true },
                    { 65, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Dài QD003", 230000, "Quần dài", true },
                    { 78, "Lắng nghe khách hàng của mình và hiểu được mỗi chàng trai đều cần có trong tủ đồ mình 1 chiếc quần đặc biệt thoải mái trong mọi vận động. Và Coolmate đặc biệt cho ra mắt sản phẩm Quần phiên bản mới với chất liệu vải 100% Polyester PTT đặc biệt CO GIÃN TUYỆT VỜI đem đến sự thoải mái tối đa.", false, "Quần Dài QD016", 199000, "Quần dài", true },
                    { 85, "Lắng nghe khách hàng của mình và hiểu được mỗi chàng trai đều cần có trong tủ đồ mình 1 chiếc quần đặc biệt thoải mái trong mọi vận động. Và Coolmate đặc biệt cho ra mắt sản phẩm Quần phiên bản mới với chất liệu vải 100% Polyester PTT đặc biệt CO GIÃN TUYỆT VỜI đem đến sự thoải mái tối đa.", false, "Quần Ngắn QN003", 230000, "Quần ngắn", true },
                    { 80, "Lắng nghe khách hàng của mình và hiểu được mỗi chàng trai đều cần có trong tủ đồ mình 1 chiếc quần đặc biệt thoải mái trong mọi vận động. Và Coolmate đặc biệt cho ra mắt sản phẩm Quần phiên bản mới với chất liệu vải 100% Polyester PTT đặc biệt CO GIÃN TUYỆT VỜI đem đến sự thoải mái tối đa.", false, "Quần Dài QD018", 230000, "Quần dài", true },
                    { 102, "Lắng nghe khách hàng của mình và hiểu được mỗi chàng trai đều cần có trong tủ đồ mình 1 chiếc quần đặc biệt thoải mái trong mọi vận động. Và Coolmate đặc biệt cho ra mắt sản phẩm Quần phiên bản mới với chất liệu vải 100% Polyester PTT đặc biệt CO GIÃN TUYỆT VỜI đem đến sự thoải mái tối đa.", false, "Quần Ngắn QN020", 230000, "Quần ngắn", true },
                    { 101, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Ngắn QN019", 230000, "Quần ngắn", true },
                    { 100, "Lắng nghe khách hàng của mình và hiểu được mỗi chàng trai đều cần có trong tủ đồ mình 1 chiếc quần đặc biệt thoải mái trong mọi vận động. Và Coolmate đặc biệt cho ra mắt sản phẩm Quần phiên bản mới với chất liệu vải 100% Polyester PTT đặc biệt CO GIÃN TUYỆT VỜI đem đến sự thoải mái tối đa.", false, "Quần Ngắn QN018", 199000, "Quần ngắn", true },
                    { 99, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Ngắn QN017", 199000, "Quần ngắn", true },
                    { 98, "Lắng nghe khách hàng của mình và hiểu được mỗi chàng trai đều cần có trong tủ đồ mình 1 chiếc quần đặc biệt thoải mái trong mọi vận động. Và Coolmate đặc biệt cho ra mắt sản phẩm Quần phiên bản mới với chất liệu vải 100% Polyester PTT đặc biệt CO GIÃN TUYỆT VỜI đem đến sự thoải mái tối đa.", false, "Quần Ngắn QN016", 230000, "Quần ngắn", true },
                    { 97, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Ngắn QN015", 199000, "Quần ngắn", true },
                    { 96, "Lắng nghe khách hàng của mình và hiểu được mỗi chàng trai đều cần có trong tủ đồ mình 1 chiếc quần đặc biệt thoải mái trong mọi vận động. Và Coolmate đặc biệt cho ra mắt sản phẩm Quần phiên bản mới với chất liệu vải 100% Polyester PTT đặc biệt CO GIÃN TUYỆT VỜI đem đến sự thoải mái tối đa.", false, "Quần Ngắn QN014", 199000, "Quần ngắn", true },
                    { 95, "Lắng nghe khách hàng của mình và hiểu được mỗi chàng trai đều cần có trong tủ đồ mình 1 chiếc quần đặc biệt thoải mái trong mọi vận động. Và Coolmate đặc biệt cho ra mắt sản phẩm Quần phiên bản mới với chất liệu vải 100% Polyester PTT đặc biệt CO GIÃN TUYỆT VỜI đem đến sự thoải mái tối đa.", false, "Quần Ngắn QN013", 199000, "Quần ngắn", true },
                    { 94, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Ngắn QN012", 230000, "Quần ngắn", true },
                    { 93, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Ngắn QN011", 199000, "Quần ngắn", true },
                    { 79, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Dài QD017", 199000, "Quần dài", true },
                    { 92, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Ngắn QN010", 199000, "Quần ngắn", true },
                    { 90, "Lắng nghe khách hàng của mình và hiểu được mỗi chàng trai đều cần có trong tủ đồ mình 1 chiếc quần đặc biệt thoải mái trong mọi vận động. Và Coolmate đặc biệt cho ra mắt sản phẩm Quần phiên bản mới với chất liệu vải 100% Polyester PTT đặc biệt CO GIÃN TUYỆT VỜI đem đến sự thoải mái tối đa.", false, "Quần Ngắn QN008", 230000, "Quần ngắn", true },
                    { 89, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Ngắn QN007", 199000, "Quần ngắn", true },
                    { 88, "Lắng nghe khách hàng của mình và hiểu được mỗi chàng trai đều cần có trong tủ đồ mình 1 chiếc quần đặc biệt thoải mái trong mọi vận động. Và Coolmate đặc biệt cho ra mắt sản phẩm Quần phiên bản mới với chất liệu vải 100% Polyester PTT đặc biệt CO GIÃN TUYỆT VỜI đem đến sự thoải mái tối đa.", false, "Quần Ngắn QN006", 199000, "Quần ngắn", true },
                    { 87, "Lắng nghe khách hàng của mình và hiểu được mỗi chàng trai đều cần có trong tủ đồ mình 1 chiếc quần đặc biệt thoải mái trong mọi vận động. Và Coolmate đặc biệt cho ra mắt sản phẩm Quần phiên bản mới với chất liệu vải 100% Polyester PTT đặc biệt CO GIÃN TUYỆT VỜI đem đến sự thoải mái tối đa.", false, "Quần Ngắn QN005", 199000, "Quần ngắn", true },
                    { 86, "Lắng nghe khách hàng của mình và hiểu được mỗi chàng trai đều cần có trong tủ đồ mình 1 chiếc quần đặc biệt thoải mái trong mọi vận động. Và Coolmate đặc biệt cho ra mắt sản phẩm Quần phiên bản mới với chất liệu vải 100% Polyester PTT đặc biệt CO GIÃN TUYỆT VỜI đem đến sự thoải mái tối đa.", false, "Quần Ngắn QN004", 199000, "Quần ngắn", true },
                    { 54, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu bamboo (vải tre) Ex-Soft này, sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo bamboo này có gì đặc biệt nhé!", false, "Áo Sơ Mi N005", 199000, "Áo sơ mi tay ngắn", true },
                    { 84, "Lắng nghe khách hàng của mình và hiểu được mỗi chàng trai đều cần có trong tủ đồ mình 1 chiếc quần đặc biệt thoải mái trong mọi vận động. Và Coolmate đặc biệt cho ra mắt sản phẩm Quần phiên bản mới với chất liệu vải 100% Polyester PTT đặc biệt CO GIÃN TUYỆT VỜI đem đến sự thoải mái tối đa.", false, "Quần Ngắn QN002", 199000, "Quần ngắn", true },
                    { 83, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Ngắn QN001", 230000, "Quần ngắn", true },
                    { 82, "Lắng nghe khách hàng của mình và hiểu được mỗi chàng trai đều cần có trong tủ đồ mình 1 chiếc quần đặc biệt thoải mái trong mọi vận động. Và Coolmate đặc biệt cho ra mắt sản phẩm Quần phiên bản mới với chất liệu vải 100% Polyester PTT đặc biệt CO GIÃN TUYỆT VỜI đem đến sự thoải mái tối đa.", false, "Quần Dài QD020", 199000, "Quần dài", true },
                    { 81, "Lắng nghe khách hàng của mình và hiểu được mỗi chàng trai đều cần có trong tủ đồ mình 1 chiếc quần đặc biệt thoải mái trong mọi vận động. Và Coolmate đặc biệt cho ra mắt sản phẩm Quần phiên bản mới với chất liệu vải 100% Polyester PTT đặc biệt CO GIÃN TUYỆT VỜI đem đến sự thoải mái tối đa.", false, "Quần Dài QD019", 199000, "Quần dài", true },
                    { 91, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Ngắn QN009", 230000, "Quần ngắn", true },
                    { 53, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu bamboo (vải tre) Ex-Soft này, sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo bamboo này có gì đặc biệt nhé!", false, "Áo Sơ Mi N004", 199000, "Áo sơ mi tay ngắn", true },
                    { 52, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu modal (gỗ sồi), sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo sơ mi Modal này có gì đặc biệt nhé!", false, "Áo Sơ Mi N003", 199000, "Áo sơ mi tay ngắn", true },
                    { 18, "Bạn có đang tìm kiếm cho mình một một chiếc áo dài tay ấm áp. Coolmate hiểu được điều đó và đã nghiên cứu để gửi đến bạn một chiếc áo Sweatshirt với thiết kế vừa vặn, vô cùng thoải mái với chất liệu đặc biệt mềm mại. Và đó chính là áo nam Casual Sweatshirt - hoàn hảo cho những ngày thoải mái ở nhà, nhưng đủ tự tin để dạo phố cùng bạn bè.", false, "Áo Thun D018", 199000, "Áo thun tay dài", true },
                    { 22, "", false, "Áo Thun N003", 230000, "Áo thun tay ngắn ", true },
                    { 21, "", false, "Áo Thun N002", 199000, "Áo thun tay ngắn ", true },
                    { 20, "", false, "Áo Thun N001", 230000, "Áo thun tay ngắn ", true },
                    { 19, "Rất nhiều thời gian và công sức để nghiên cứu và phát triển một sản phẩm, thay vì những vải lót bông bình thường dễ bị xù hoặc rụng bông nhỏ trong quá trình giặt và sử dụng, Coolmate lựa chọn chất liệu là 90% Cotton giúp chiếc áo của bạn vẫn thoát mồ hôi mà không hề gây bí, khó chịu; kết hợp với 10% Polyester giúp áo không nhăn và luôn bền dù có giặt, sấy bằng máy.", false, "Áo Thun D019", 199000, "Áo thun tay dài", true },
                    { 51, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu modal (gỗ sồi), sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo sơ mi Modal này có gì đặc biệt nhé!", false, "Áo Sơ Mi N002", 230000, "Áo sơ mi tay ngắn", true },
                    { 17, "Bạn có đang tìm kiếm cho mình một một chiếc áo dài tay ấm áp. Coolmate hiểu được điều đó và đã nghiên cứu để gửi đến bạn một chiếc áo Sweatshirt với thiết kế vừa vặn, vô cùng thoải mái với chất liệu đặc biệt mềm mại. Và đó chính là áo nam Casual Sweatshirt - hoàn hảo cho những ngày thoải mái ở nhà, nhưng đủ tự tin để dạo phố cùng bạn bè.", false, "Áo Thun D017", 199000, "Áo thun tay dài", true },
                    { 16, "Rất nhiều thời gian và công sức để nghiên cứu và phát triển một sản phẩm, thay vì những vải lót bông bình thường dễ bị xù hoặc rụng bông nhỏ trong quá trình giặt và sử dụng, Coolmate lựa chọn chất liệu là 90% Cotton giúp chiếc áo của bạn vẫn thoát mồ hôi mà không hề gây bí, khó chịu; kết hợp với 10% Polyester giúp áo không nhăn và luôn bền dù có giặt, sấy bằng máy.", false, "Áo Thun D016", 230000, "Áo thun tay dài", true },
                    { 15, "Bạn có đang tìm kiếm cho mình một một chiếc áo dài tay ấm áp. Coolmate hiểu được điều đó và đã nghiên cứu để gửi đến bạn một chiếc áo Sweatshirt với thiết kế vừa vặn, vô cùng thoải mái với chất liệu đặc biệt mềm mại. Và đó chính là áo nam Casual Sweatshirt - hoàn hảo cho những ngày thoải mái ở nhà, nhưng đủ tự tin để dạo phố cùng bạn bè.", false, "Áo Thun D015", 199000, "Áo thun tay dài", true },
                    { 14, "Bạn có đang tìm kiếm cho mình một một chiếc áo dài tay ấm áp. Coolmate hiểu được điều đó và đã nghiên cứu để gửi đến bạn một chiếc áo Sweatshirt với thiết kế vừa vặn, vô cùng thoải mái với chất liệu đặc biệt mềm mại. Và đó chính là áo nam Casual Sweatshirt - hoàn hảo cho những ngày thoải mái ở nhà, nhưng đủ tự tin để dạo phố cùng bạn bè.", false, "Áo Thun D014", 230000, "Áo thun tay dài", true },
                    { 13, "Bạn có đang tìm kiếm cho mình một một chiếc áo dài tay ấm áp. Coolmate hiểu được điều đó và đã nghiên cứu để gửi đến bạn một chiếc áo Sweatshirt với thiết kế vừa vặn, vô cùng thoải mái với chất liệu đặc biệt mềm mại. Và đó chính là áo nam Casual Sweatshirt - hoàn hảo cho những ngày thoải mái ở nhà, nhưng đủ tự tin để dạo phố cùng bạn bè.", false, "Áo Thun D013", 230000, "Áo thun tay dài", true },
                    { 24, "", false, "Áo Thun N005", 230000, "Áo thun tay ngắn ", true },
                    { 12, "Bạn có đang tìm kiếm cho mình một một chiếc áo dài tay ấm áp. Coolmate hiểu được điều đó và đã nghiên cứu để gửi đến bạn một chiếc áo Sweatshirt với thiết kế vừa vặn, vô cùng thoải mái với chất liệu đặc biệt mềm mại. Và đó chính là áo nam Casual Sweatshirt - hoàn hảo cho những ngày thoải mái ở nhà, nhưng đủ tự tin để dạo phố cùng bạn bè.", false, "Áo Thun D012", 199000, "Áo thun tay dài", true },
                    { 10, "Bạn có đang tìm kiếm cho mình một một chiếc áo dài tay ấm áp. Coolmate hiểu được điều đó và đã nghiên cứu để gửi đến bạn một chiếc áo Sweatshirt với thiết kế vừa vặn, vô cùng thoải mái với chất liệu đặc biệt mềm mại. Và đó chính là áo nam Casual Sweatshirt - hoàn hảo cho những ngày thoải mái ở nhà, nhưng đủ tự tin để dạo phố cùng bạn bè.", false, "Áo Thun D010", 230000, "Áo thun tay dài", true },
                    { 9, "Bạn có đang tìm kiếm cho mình một một chiếc áo dài tay ấm áp. Coolmate hiểu được điều đó và đã nghiên cứu để gửi đến bạn một chiếc áo Sweatshirt với thiết kế vừa vặn, vô cùng thoải mái với chất liệu đặc biệt mềm mại. Và đó chính là áo nam Casual Sweatshirt - hoàn hảo cho những ngày thoải mái ở nhà, nhưng đủ tự tin để dạo phố cùng bạn bè.", false, "Áo Thun D009", 199000, "Áo thun tay dài", true },
                    { 8, "Rất nhiều thời gian và công sức để nghiên cứu và phát triển một sản phẩm, thay vì những vải lót bông bình thường dễ bị xù hoặc rụng bông nhỏ trong quá trình giặt và sử dụng, Coolmate lựa chọn chất liệu là 90% Cotton giúp chiếc áo của bạn vẫn thoát mồ hôi mà không hề gây bí, khó chịu; kết hợp với 10% Polyester giúp áo không nhăn và luôn bền dù có giặt, sấy bằng máy.", false, "Áo Thun D008", 199000, "Áo thun tay dài", true },
                    { 7, "Bạn có đang tìm kiếm cho mình một một chiếc áo dài tay ấm áp. Coolmate hiểu được điều đó và đã nghiên cứu để gửi đến bạn một chiếc áo Sweatshirt với thiết kế vừa vặn, vô cùng thoải mái với chất liệu đặc biệt mềm mại. Và đó chính là áo nam Casual Sweatshirt - hoàn hảo cho những ngày thoải mái ở nhà, nhưng đủ tự tin để dạo phố cùng bạn bè.", false, "Áo Thun D007", 230000, "Áo thun tay dài", true },
                    { 6, "Rất nhiều thời gian và công sức để nghiên cứu và phát triển một sản phẩm, thay vì những vải lót bông bình thường dễ bị xù hoặc rụng bông nhỏ trong quá trình giặt và sử dụng, Coolmate lựa chọn chất liệu là 90% Cotton giúp chiếc áo của bạn vẫn thoát mồ hôi mà không hề gây bí, khó chịu; kết hợp với 10% Polyester giúp áo không nhăn và luôn bền dù có giặt, sấy bằng máy.", false, "Áo Thun D006", 230000, "Áo thun tay dài", true },
                    { 5, "Bạn có đang tìm kiếm cho mình một một chiếc áo dài tay ấm áp. Coolmate hiểu được điều đó và đã nghiên cứu để gửi đến bạn một chiếc áo Sweatshirt với thiết kế vừa vặn, vô cùng thoải mái với chất liệu đặc biệt mềm mại. Và đó chính là áo nam Casual Sweatshirt - hoàn hảo cho những ngày thoải mái ở nhà, nhưng đủ tự tin để dạo phố cùng bạn bè.", false, "Áo Thun D005", 230000, "Áo thun tay dài", true },
                    { 4, "Bạn có đang tìm kiếm cho mình một một chiếc áo dài tay ấm áp. Coolmate hiểu được điều đó và đã nghiên cứu để gửi đến bạn một chiếc áo Sweatshirt với thiết kế vừa vặn, vô cùng thoải mái với chất liệu đặc biệt mềm mại. Và đó chính là áo nam Casual Sweatshirt - hoàn hảo cho những ngày thoải mái ở nhà, nhưng đủ tự tin để dạo phố cùng bạn bè.", false, "Áo Thun D004", 199000, "Áo thun tay dài", true },
                    { 3, "Rất nhiều thời gian và công sức để nghiên cứu và phát triển một sản phẩm, thay vì những vải lót bông bình thường dễ bị xù hoặc rụng bông nhỏ trong quá trình giặt và sử dụng, Coolmate lựa chọn chất liệu là 90% Cotton giúp chiếc áo của bạn vẫn thoát mồ hôi mà không hề gây bí, khó chịu; kết hợp với 10% Polyester giúp áo không nhăn và luôn bền dù có giặt, sấy bằng máy.", false, "Áo Thun D003", 230000, "Áo thun tay dài", true },
                    { 2, "Rất nhiều thời gian và công sức để nghiên cứu và phát triển một sản phẩm, thay vì những vải lót bông bình thường dễ bị xù hoặc rụng bông nhỏ trong quá trình giặt và sử dụng, Coolmate lựa chọn chất liệu là 90% Cotton giúp chiếc áo của bạn vẫn thoát mồ hôi mà không hề gây bí, khó chịu; kết hợp với 10% Polyester giúp áo không nhăn và luôn bền dù có giặt, sấy bằng máy.", false, "Áo Thun D002", 230000, "Áo thun tay dài", true },
                    { 1, "Bạn có đang tìm kiếm cho mình một một chiếc áo dài tay ấm áp. Coolmate hiểu được điều đó và đã nghiên cứu để gửi đến bạn một chiếc áo Sweatshirt với thiết kế vừa vặn, vô cùng thoải mái với chất liệu đặc biệt mềm mại. Và đó chính là áo nam Casual Sweatshirt - hoàn hảo cho những ngày thoải mái ở nhà, nhưng đủ tự tin để dạo phố cùng bạn bè.", false, "Áo Thun D001", 199000, "Áo thun tay dài", true },
                    { 11, "Bạn có đang tìm kiếm cho mình một một chiếc áo dài tay ấm áp. Coolmate hiểu được điều đó và đã nghiên cứu để gửi đến bạn một chiếc áo Sweatshirt với thiết kế vừa vặn, vô cùng thoải mái với chất liệu đặc biệt mềm mại. Và đó chính là áo nam Casual Sweatshirt - hoàn hảo cho những ngày thoải mái ở nhà, nhưng đủ tự tin để dạo phố cùng bạn bè.", false, "Áo Thun D011", 199000, "Áo thun tay dài", true },
                    { 25, "", false, "Áo Thun N006", 199000, "Áo thun tay ngắn ", true },
                    { 23, "", false, "Áo Thun N004", 199000, "Áo thun tay ngắn ", true },
                    { 27, "", false, "Áo Thun N008", 199000, "Áo thun tay ngắn ", true },
                    { 50, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu modal (gỗ sồi), sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo sơ mi Modal này có gì đặc biệt nhé!", false, "Áo Sơ Mi N001", 199000, "Áo sơ mi tay ngắn", true },
                    { 49, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu modal (gỗ sồi), sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo sơ mi Modal này có gì đặc biệt nhé!", false, "Áo Sơ Mi D011", 230000, "Áo sơ mi tay dài", true },
                    { 48, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu modal (gỗ sồi), sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo sơ mi Modal này có gì đặc biệt nhé!", false, "Áo Sơ Mi D010", 230000, "Áo sơ mi tay dài", true },
                    { 47, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu bamboo (vải tre) Ex-Soft này, sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo bamboo này có gì đặc biệt nhé!", false, "Áo Sơ Mi D009", 199000, "Áo sơ mi tay dài", true },
                    { 46, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu modal (gỗ sồi), sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo sơ mi Modal này có gì đặc biệt nhé!", false, "Áo Sơ Mi D008", 199000, "Áo sơ mi tay dài", true },
                    { 45, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu modal (gỗ sồi), sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo sơ mi Modal này có gì đặc biệt nhé!", false, "Áo Sơ Mi D007", 230000, "Áo sơ mi tay dài", true },
                    { 44, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu bamboo (vải tre) Ex-Soft này, sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo bamboo này có gì đặc biệt nhé!", false, "Áo Sơ Mi D006", 230000, "Áo sơ mi tay dài", true },
                    { 43, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu modal (gỗ sồi), sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo sơ mi Modal này có gì đặc biệt nhé!", false, "Áo Sơ Mi D005", 199000, "Áo sơ mi tay dài", true },
                    { 42, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu modal (gỗ sồi), sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo sơ mi Modal này có gì đặc biệt nhé!", false, "Áo Sơ Mi D004", 230000, "Áo sơ mi tay dài", true },
                    { 26, "", false, "Áo Thun N007", 199000, "Áo thun tay ngắn ", true },
                    { 40, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu bamboo (vải tre) Ex-Soft này, sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo bamboo này có gì đặc biệt nhé!", false, "Áo Sơ Mi D002", 230000, "Áo sơ mi tay dài", true },
                    { 39, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu modal (gỗ sồi), sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo sơ mi Modal này có gì đặc biệt nhé!", false, "Áo Sơ Mi D001", 230000, "Áo sơ mi tay dài", true },
                    { 41, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu modal (gỗ sồi), sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo sơ mi Modal này có gì đặc biệt nhé!", false, "Áo Sơ Mi D003", 199000, "Áo sơ mi tay dài", true },
                    { 37, "", false, "Áo Thun N018", 199000, "Áo thun tay ngắn ", true },
                    { 28, "", false, "Áo Thun N009", 199000, "Áo thun tay ngắn ", true },
                    { 38, "", false, "Áo Thun N019", 230000, "Áo thun tay ngắn ", true },
                    { 30, "", false, "Áo Thun N011", 230000, "Áo thun tay ngắn ", true },
                    { 31, "", false, "Áo Thun N012", 199000, "Áo thun tay ngắn ", true },
                    { 29, "", false, "Áo Thun N010", 199000, "Áo thun tay ngắn ", true },
                    { 33, "", false, "Áo Thun N014", 230000, "Áo thun tay ngắn ", true },
                    { 34, "", false, "Áo Thun N015", 199000, "Áo thun tay ngắn ", true },
                    { 35, "", false, "Áo Thun N016", 199000, "Áo thun tay ngắn ", true },
                    { 36, "", false, "Áo Thun N017", 199000, "Áo thun tay ngắn ", true },
                    { 32, "", false, "Áo Thun N013", 230000, "Áo thun tay ngắn ", true }
                });

            migrationBuilder.InsertData(
                table: "Tag",
                columns: new[] { "ID", "IsDelete", "Name" },
                values: new object[,]
                {
                    { 9, false, "Ao So Mi Tay Ngan" },
                    { 14, false, "Thoi Trang Cong So" },
                    { 13, false, "Thoi Trang Teen" },
                    { 12, false, "Thoi Trang Nang Dong" },
                    { 11, false, "Thoi Trang Tre" },
                    { 10, false, "Ao So Mi Tay Dai" },
                    { 8, false, "Ao So Mi Cong So" },
                    { 15, false, "Quan Di Choi" },
                    { 6, false, "Ao Thun Cotton" },
                    { 5, false, "Ao Thun Hien Dai" },
                    { 4, false, "Ao Thun Thoi Trang" },
                    { 3, false, "San Pham Duoc Ua Thich" },
                    { 2, false, "San Pham Ban Chay" },
                    { 1, false, "San Pham Moi" },
                    { 7, false, "Ao So Mi Cotton" },
                    { 16, false, "Quan Cong So" }
                });

            migrationBuilder.Sql(
                "INSERT [dbo].[ProductTag] ([ProductID], [TagID]) VALUES (1, 1), (2, 1), (20, 1), (21, 1), (22, 1), (40, 1), (50, 1), (51, 1), (52, 1), (63, 1), (64, 1), (1, 2), (5, 2), (20, 2), (22, 2), (50, 2), (52, 2), (63, 2), (64, 2), (83, 2), (84, 2), (3, 3), (1, 4), (2, 4), (4, 4), (5, 4), (6, 4), (7, 4), (8, 4), (10, 4), (11, 4), (13, 4), (14, 4), (15, 4), (16, 4), (18, 4), (19, 4), (20, 4), (27, 4), (30, 4), (31, 4), (34, 4), (36, 4), (37, 4), (1, 5), (2, 5), (4, 5), (5, 5), (6, 5), (7, 5), (8, 5), (9, 5), (10, 5), (11, 5), (12, 5), (13, 5), (14, 5), (15, 5), (16, 5), (17, 5), (18, 5), (19, 5), (20, 5), (21, 5), (22, 5), (24, 5), (26, 5), (28, 5), (32, 5), (33, 5), (35, 5), (38, 5), (3, 6), (7, 6), (8, 6), (9, 6), (12, 6), (14, 6), (15, 6), (16, 6), (17, 6), (18, 6), (21, 6), (22, 6), (23, 6), (29, 6), (39, 7), (41, 7), (43, 7), (44, 7), (46, 7), (48, 7), (50, 7), (51, 7), (52, 7), (53, 7), (54, 7), (55, 7), (56, 7), (58, 7)"
                + "INSERT [dbo].[ProductTag] ([ProductID], [TagID]) VALUES (59, 7), (61, 7), (62, 7), (40, 8), (45, 8), (47, 8), (49, 8), (50, 9), (51, 9), (52, 9), (56, 9), (57, 9), (60, 9), (39, 10), (40, 10), (41, 10), (42, 10), (45, 10), (73, 11), (75, 11), (77, 11), (78, 11), (91, 11), (92, 11), (93, 11), (94, 11), (95, 11), (96, 11), (97, 11), (99, 11), (100, 11), (101, 11), (102, 11), (17, 12), (67, 12), (68, 12), (69, 12), (71, 12), (75, 12), (78, 12), (81, 12), (82, 12), (83, 12), (84, 12), (85, 12), (86, 12), (87, 12), (88, 12), (89, 12), (90, 12), (91, 12), (92, 12), (93, 12), (94, 12), (96, 12), (98, 12), (99, 12), (101, 12), (102, 12), (67, 13), (68, 13), (69, 13), (71, 13), (72, 13), (73, 13), (74, 13), (75, 13), (77, 13), (79, 13), (81, 13), (82, 13), (83, 13), (84, 13), (85, 13), (86, 13), (87, 13), (88, 13), (89, 13), (90, 13), (91, 13), (92, 13), (93, 13), (94, 13), (95, 13), (96, 13), (97, 13), (98, 13), (99, 13), (100, 13), (101, 13), (63, 15), (64, 15), (65, 15), (66, 15), (68, 15), (71, 15), (76, 15), (77, 15), (78, 15), (80, 15)"
                + "INSERT [dbo].[ProductTag] ([ProductID], [TagID]) VALUES (81, 15), (83, 15), (84, 15), (85, 15), (86, 15), (87, 15), (88, 15), (89, 15), (95, 15), (96, 15), (97, 15), (98, 15), (100, 15), (101, 15), (102, 15), (64, 16), (65, 16), (67, 16), (69, 16), (70, 16), (72, 16), (73, 16), (74, 16), (75, 16), (79, 16), (82, 16)"
            );

            migrationBuilder.InsertData(
                table: "Admin",
                columns: new[] { "ID", "AccountID", "Fullname", "Phone" },
                values: new object[,]
                {
                    { 3, 15, "Đặng Kim Thư", "0904448888" },
                    { 2, 14, "Nguyễn Thành Nhân", "0903338888" },
                    { 1, 13, "Doãn Xuân Thanh", "0902228888" }
                });

            migrationBuilder.InsertData(
                table: "CartDetails",
                columns: new[] { "ID", "Color", "IsDelete", "IsSelected", "Quantity", "Size", "accountID", "productID" },
                values: new object[,]
                {
                    { 6, "Vàng", false, true, 1, "L", 2, 5 },
                    { 8, "Đen", false, true, 2, "L", 2, 88 },
                    { 5, "Trắng", false, true, 1, "L", 1, 52 },
                    { 7, "Xám", false, false, 4, "L", 2, 74 },
                    { 2, "Xanh mint", false, true, 1, "L", 1, 7 },
                    { 10, "Xanh jean", false, true, 1, "M", 2, 85 },
                    { 4, "Trắng", false, true, 2, "M", 1, 25 },
                    { 3, "Đen", false, false, 3, "L", 1, 26 },
                    { 1, "Đỏ", false, true, 2, "M", 1, 5 },
                    { 9, "Đen", false, true, 2, "M", 2, 83 }
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "ID", "AccountID", "Address", "CardNumber", "Fullname", "Phone", "SecretNumber", "ValidDate" },
                values: new object[,]
                {
                    { 1, 1, "12 Nguyễn Huệ P.Bến Nghé Q.1", "271119473238", "Diệc Lữ Chí Vĩ", "0909010003", "2986361", new DateTime(2023, 12, 21, 11, 31, 31, 639, DateTimeKind.Local).AddTicks(5550) },
                    { 11, 11, "12 Nguyễn Huệ P.Bến Nghé Q.11", "271219473238", "Hứa Huy", "0900010203", "2982361", new DateTime(2023, 12, 21, 11, 31, 31, 639, DateTimeKind.Local).AddTicks(7640) },
                    { 12, 12, "12 Nguyễn Huệ P.Bến Nghé Q.12", "274612273238", "Đặng Khôi", "0990210203", "2186361", new DateTime(2023, 12, 21, 11, 31, 31, 639, DateTimeKind.Local).AddTicks(7650) },
                    { 8, 8, "12 Nguyễn Huệ P.Bến Nghé Q.8", "118629473238", "Thanh Thanh", "0309010203", "2886361", new DateTime(2022, 12, 21, 11, 31, 31, 639, DateTimeKind.Local).AddTicks(7630) },
                    { 9, 9, "12 Nguyễn Huệ P.Bến Nghé Q.9", "271199473238", "Tùng Trần", "0904010203", "2989361", new DateTime(2022, 12, 21, 11, 31, 31, 639, DateTimeKind.Local).AddTicks(7630) },
                    { 6, 6, "12 Nguyễn Huệ P.Bến Nghé Q.6", "116629473238", "Hà Quỳnh", "0989010203", "2986661", new DateTime(2022, 12, 21, 11, 31, 31, 639, DateTimeKind.Local).AddTicks(7620) },
                    { 5, 5, "12 Nguyễn Huệ P.Bến Nghé Q.5", "115629473238", "Nhi Lý", "0909610203", "2986364", new DateTime(2023, 12, 21, 11, 31, 31, 639, DateTimeKind.Local).AddTicks(7620) },
                    { 10, 10, "12 Nguyễn Huệ P.Bến Nghé Q.10", "212029473238", "Trần Huy", "0908010203", "2196361", new DateTime(2022, 12, 21, 11, 31, 31, 639, DateTimeKind.Local).AddTicks(7640) },
                    { 4, 4, "12 Nguyễn Huệ P.Bến Nghé Q.4", "274629411438", "Trần Hồng", "0909010303", "2986331", new DateTime(2023, 12, 21, 11, 31, 31, 639, DateTimeKind.Local).AddTicks(7610) },
                    { 3, 3, "12 Nguyễn Huệ P.Bến Nghé Q.3", "274621133238", "Nguyễn Trân", "0909020203", "2982360", new DateTime(2023, 12, 21, 11, 31, 31, 639, DateTimeKind.Local).AddTicks(7610) },
                    { 7, 7, "12 Nguyễn Huệ P.Bến Nghé Q.7", "211729473238", "Huy Huy", "0909010203", "2986371", new DateTime(2022, 12, 21, 11, 31, 31, 639, DateTimeKind.Local).AddTicks(7620) },
                    { 2, 2, "12 Nguyễn Huệ P.Bến Nghé Q.2", "274611273238", "Tăng Cẩm Phú", "0909110203", "2916361", new DateTime(2022, 12, 21, 11, 31, 31, 639, DateTimeKind.Local).AddTicks(7550) }
                });

            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "ID", "IsDelete", "Name", "ProductId", "URL" },
                values: new object[,]
                {
                    { 33, false, "Ảnh minh hoạ D019", 19, "19_1_D019.jpg" },
                    { 42, false, "Ảnh minh hoạ N003", 22, "22_3_N003.jpg" },
                    { 111, false, "Ảnh minh hoạ QD010", 72, "72_1_QD010.jpg" },
                    { 113, false, "Ảnh minh hoạ QD012", 74, "74_1_QD012.jpg" },
                    { 30, false, "Ảnh minh hoạ D016", 16, "16_1_D016.jpg" },
                    { 43, false, "Ảnh minh hoạ N004", 23, "23_1_N004.jpg" },
                    { 79, false, "Ảnh minh hoạ N001", 50, "50_4_N001.jpg" },
                    { 87, false, "Ảnh minh hoạ N004", 53, "53_1_N004.jpg" },
                    { 78, false, "Ảnh minh hoạ N001", 50, "50_3_N001.jpg" },
                    { 128, false, "Ảnh minh hoạ QN002", 84, "84_3_QN002.jpg" },
                    { 127, false, "Ảnh minh hoạ QN002", 84, "84_2_QN002.jpg" },
                    { 126, false, "Ảnh minh hoạ QN002", 84, "84_1_QN002.jpg" },
                    { 44, false, "Ảnh minh hoạ N005", 24, "24_1_N005.jpg" },
                    { 29, false, "Ảnh minh hoạ D015", 15, "15_1_D015.jpg" },
                    { 77, false, "Ảnh minh hoạ N001", 50, "50_2_N001.jpg" },
                    { 88, false, "Ảnh minh hoạ N005", 54, "54_1_N005.jpg" },
                    { 41, false, "Ảnh minh hoạ N003", 22, "22_2_N003.jpg" },
                    { 39, false, "Ảnh minh hoạ N003", 22, "22_1_N003.jpg" },
                    { 129, false, "Ảnh minh hoạ QN003", 85, "85_1_QN003.jpg" },
                    { 32, false, "Ảnh minh hoạ D018", 18, "18_1_D018.jpg" },
                    { 85, false, "Ảnh minh hoạ N003", 52, "52_2_N003.jpg" },
                    { 132, false, "Ảnh minh hoạ QN004", 86, "86_1_QN004.jpg" },
                    { 34, false, "Ảnh minh hoạ N001", 20, "20_1_N001.jpg" },
                    { 35, false, "Ảnh minh hoạ N001", 20, "20_2_N001.jpg" },
                    { 36, false, "Ảnh minh hoạ N001", 20, "20_3_N001.jpg" },
                    { 84, false, "Ảnh minh hoạ N003", 52, "52_1_N003.jpg" },
                    { 112, false, "Ảnh minh hoạ QD011", 73, "73_1_QD011.jpg" },
                    { 133, false, "Ảnh minh hoạ QN004", 86, "86_2_QN004.jpg" },
                    { 83, false, "Ảnh minh hoạ N002", 51, "51_4_N002.jpg" },
                    { 37, false, "Ảnh minh hoạ N002", 21, "21_1_N002.jpg" },
                    { 38, false, "Ảnh minh hoạ N002", 21, "21_2_N002.jpg" },
                    { 81, false, "Ảnh minh hoạ N002", 51, "51_2_N002.jpg" },
                    { 76, false, "Ảnh minh hoạ N001", 50, "50_1_N001.jpg" },
                    { 86, false, "Ảnh minh hoạ N003", 52, "52_3_N003.jpg" },
                    { 131, false, "Ảnh minh hoạ QN003", 85, "85_3_QN003.jpg" },
                    { 130, false, "Ảnh minh hoạ QN003", 85, "85_2_QN003.jpg" },
                    { 82, false, "Ảnh minh hoạ N002", 51, "51_3_N002.jpg" },
                    { 80, false, "Ảnh minh hoạ N002", 51, "51_1_N002.jpg" },
                    { 75, false, "Ảnh minh hoạ D011", 49, "49_1_D011.jpg" },
                    { 114, false, "Ảnh minh hoạ QD013", 75, "75_1_QD013.jpg" },
                    { 116, false, "Ảnh minh hoạ QD015", 77, "77_1_QD015.jpg" },
                    { 58, false, "Ảnh minh hoạ N019", 38, "38_1_N019.jpg" },
                    { 120, false, "Ảnh minh hoạ QD019", 81, "81_1_QD019.jpg" },
                    { 59, false, "Ảnh minh hoạ D001", 39, "39_1_D001.jpg" },
                    { 60, false, "Ảnh minh hoạ D001", 39, "39_2_D001.jpg" },
                    { 71, false, "Ảnh minh hoạ D007", 45, "45_1_D007.jpg" },
                    { 70, false, "Ảnh minh hoạ D006", 44, "44_1_D006.jpg" },
                    { 69, false, "Ảnh minh hoạ D005", 43, "43_1_D005.jpg" },
                    { 72, false, "Ảnh minh hoạ D008", 46, "46_1_D008.jpg" },
                    { 61, false, "Ảnh minh hoạ D002", 40, "40_1_D002.jpg" },
                    { 63, false, "Ảnh minh hoạ D002", 40, "40_3_D002.jpg" },
                    { 64, false, "Ảnh minh hoạ D002", 40, "40_4_D002.jpg" },
                    { 117, false, "Ảnh minh hoạ QD016", 78, "78_1_QD016.jpg" },
                    { 119, false, "Ảnh minh hoạ QD018", 80, "80_1_QD018.jpg" },
                    { 65, false, "Ảnh minh hoạ D003", 41, "41_1_D003.jpg" },
                    { 66, false, "Ảnh minh hoạ D003", 41, "41_2_D003.jpg" },
                    { 68, false, "Ảnh minh hoạ D004", 42, "42_2_D004.jpg" },
                    { 67, false, "Ảnh minh hoạ D004", 42, "42_1_D004.jpg" },
                    { 62, false, "Ảnh minh hoạ D002", 40, "40_2_D002.jpg" },
                    { 57, false, "Ảnh minh hoạ N018", 37, "37_1_N018.jpg" },
                    { 56, false, "Ảnh minh hoạ N017", 36, "36_1_N017.jpg" },
                    { 121, false, "Ảnh minh hoạ QD020", 82, "82_1_QD020.jpg" },
                    { 46, false, "Ảnh minh hoạ N007", 26, "26_1_N007.jpg" },
                    { 47, false, "Ảnh minh hoạ N008", 27, "27_1_N008.jpg" },
                    { 105, false, "Ảnh minh hoạ QD004", 66, "66_1_QD004.jpg" },
                    { 48, false, "Ảnh minh hoạ N009", 28, "28_1_N009.jpg" },
                    { 28, false, "Ảnh minh hoạ D014", 14, "14_1_D014.jpg" },
                    { 74, false, "Ảnh minh hoạ D010", 48, "48_1_D010.jpg" },
                    { 125, false, "Ảnh minh hoạ QN001", 83, "83_4_QN001.jpg" },
                    { 49, false, "Ảnh minh hoạ N010", 29, "29_1_N010.jpg" },
                    { 124, false, "Ảnh minh hoạ QN001", 83, "83_3_QN001.jpg" },
                    { 50, false, "Ảnh minh hoạ N011", 30, "30_1_N011.jpg" },
                    { 123, false, "Ảnh minh hoạ QN001", 83, "83_2_QN001.jpg" },
                    { 51, false, "Ảnh minh hoạ N012", 31, "31_1_N012.jpg" },
                    { 122, false, "Ảnh minh hoạ QN001", 83, "83_1_QN001.jpg" },
                    { 52, false, "Ảnh minh hoạ N013", 32, "32_1_N013.jpg" },
                    { 53, false, "Ảnh minh hoạ N014", 33, "33_1_N014.jpg" },
                    { 115, false, "Ảnh minh hoạ QD014", 76, "76_1_QD014.jpg" },
                    { 54, false, "Ảnh minh hoạ N015", 34, "34_1_N015.jpg" },
                    { 55, false, "Ảnh minh hoạ N016", 35, "35_1_N016.jpg" },
                    { 73, false, "Ảnh minh hoạ D009", 47, "47_1_D009.jpg" },
                    { 45, false, "Ảnh minh hoạ N006", 25, "25_1_N006.jpg" },
                    { 134, false, "Ảnh minh hoạ QN005", 87, "87_1_QN005.jpg" },
                    { 31, false, "Ảnh minh hoạ D017", 17, "17_1_D017.jpg" },
                    { 118, false, "Ảnh minh hoạ QD017", 79, "79_1_QD017.jpg" },
                    { 142, false, "Ảnh minh hoạ QN013", 95, "95_1_QN013.jpg" },
                    { 5, false, "Ảnh minh hoạ D002", 2, "2_1_D002.jpg" },
                    { 14, false, "Ảnh minh hoạ D006", 6, "6_1_D006.jpg" },
                    { 15, false, "Ảnh minh hoạ D006", 6, "6_2_D006.jpg" },
                    { 16, false, "Ảnh minh hoạ D006", 6, "6_3_D006.jpg" },
                    { 141, false, "Ảnh minh hoạ QN012", 94, "94_1_QN012.jpg" },
                    { 96, false, "Ảnh minh hoạ N013", 62, "62_1_N013.jpg" },
                    { 140, false, "Ảnh minh hoạ QN011", 93, "93_1_QN011.jpg" },
                    { 7, false, "Ảnh minh hoạ D003", 3, "3_1_D003.jpg" },
                    { 148, false, "Ảnh minh hoạ QN019", 101, "101_1_QN019.jpg" },
                    { 139, false, "Ảnh minh hoạ QN010", 92, "92_1_QN010.jpg" },
                    { 17, false, "Ảnh minh hoạ D007", 7, "7_1_D007.jpg" },
                    { 18, false, "Ảnh minh hoạ D007", 7, "7_2_D007.jpg" },
                    { 108, false, "Ảnh minh hoạ QD007", 69, "69_1_QD007.jpg" },
                    { 94, false, "Ảnh minh hoạ N011", 60, "60_1_N011.jpg" },
                    { 97, false, "Ảnh minh hoạ QD001", 63, "63_1_QD001.jpg" },
                    { 27, false, "Ảnh minh hoạ D013", 13, "13_1_D013.jpg" },
                    { 98, false, "Ảnh minh hoạ QD001", 63, "63_2_QD001.jpg" },
                    { 143, false, "Ảnh minh hoạ QN014", 96, "96_1_QN014.jpg" },
                    { 8, false, "Ảnh minh hoạ D003", 3, "3_2_D003.jpg" },
                    { 101, false, "Ảnh minh hoạ QD002", 64, "64_2_QD002.jpg" },
                    { 102, false, "Ảnh minh hoạ QD002", 64, "64_3_QD002.jpg" },
                    { 100, false, "Ảnh minh hoạ QD002", 64, "64_1_QD002.jpg" },
                    { 106, false, "Ảnh minh hoạ QD005", 67, "67_1_QD005.jpg" },
                    { 145, false, "Ảnh minh hoạ QN016", 98, "98_1_QN016.jpg" },
                    { 147, false, "Ảnh minh hoạ QN018", 100, "100_1_QN018.jpg" },
                    { 103, false, "Ảnh minh hoạ QD003", 65, "65_1_QD003.jpg" },
                    { 9, false, "Ảnh minh hoạ D004", 4, "4_1_D004.jpg" },
                    { 107, false, "Ảnh minh hoạ QD006", 68, "68_1_QD006.jpg" },
                    { 144, false, "Ảnh minh hoạ QN015", 97, "97_1_QN015.jpg" },
                    { 11, false, "Ảnh minh hoạ D005", 5, "5_1_D005.jpg" },
                    { 12, false, "Ảnh minh hoạ D005", 5, "5_2_D005.jpg" },
                    { 13, false, "Ảnh minh hoạ D005", 5, "5_3_D005.jpg" },
                    { 6, false, "Ảnh minh hoạ D002", 2, "2_2_D002.jpg" },
                    { 99, false, "Ảnh minh hoạ QD001", 63, "63_3_QD001.jpg" },
                    { 10, false, "Ảnh minh hoạ D004", 4, "4_2_D004.jpg" },
                    { 138, false, "Ảnh minh hoạ QN009", 91, "91_1_QN009.jpg" },
                    { 95, false, "Ảnh minh hoạ N012", 61, "61_1_N012.jpg" },
                    { 93, false, "Ảnh minh hoạ N010", 59, "59_1_N010.jpg" },
                    { 1, false, "Ảnh minh hoạ D001", 1, "1_1_D001.jpg" },
                    { 2, false, "Ảnh minh hoạ D001", 1, "1_2_D001.jpg" },
                    { 26, false, "Ảnh minh hoạ D012", 12, "12_1_D012.jpg" },
                    { 110, false, "Ảnh minh hoạ QD009", 71, "71_1_QD009.jpg" },
                    { 3, false, "Ảnh minh hoạ D001", 1, "1_3_D001.jpg" },
                    { 89, false, "Ảnh minh hoạ N006", 55, "55_1_N006.jpg" },
                    { 25, false, "Ảnh minh hoạ D011", 11, "11_1_D011.jpg" },
                    { 4, false, "Ảnh minh hoạ D001", 1, "1_4_D001.jpg" },
                    { 24, false, "Ảnh minh hoạ D010", 10, "10_1_D010.jpg" },
                    { 135, false, "Ảnh minh hoạ QN006", 88, "88_1_QN006.jpg" },
                    { 23, false, "Ảnh minh hoạ D009", 9, "9_2_D009.jpg" },
                    { 22, false, "Ảnh minh hoạ D009", 9, "9_1_D009.jpg" },
                    { 91, false, "Ảnh minh hoạ N008", 57, "57_1_N008.jpg" },
                    { 136, false, "Ảnh minh hoạ QN007", 89, "89_1_QN007.jpg" },
                    { 109, false, "Ảnh minh hoạ QD008", 70, "70_1_QD008.jpg" },
                    { 90, false, "Ảnh minh hoạ N007", 56, "56_1_N007.jpg" },
                    { 149, false, "Ảnh minh hoạ QN020", 102, "102_1_QN020.jpg" },
                    { 19, false, "Ảnh minh hoạ D008", 8, "8_1_D008.jpg" },
                    { 20, false, "Ảnh minh hoạ D008", 8, "8_2_D008.jpg" },
                    { 21, false, "Ảnh minh hoạ D008", 8, "8_3_D008.jpg" },
                    { 104, false, "Ảnh minh hoạ QD003", 65, "65_2_QD003.jpg" },
                    { 92, false, "Ảnh minh hoạ N009", 58, "58_1_N009.jpg" },
                    { 137, false, "Ảnh minh hoạ QN008", 90, "90_1_QN008.jpg" },
                    { 146, false, "Ảnh minh hoạ QN017", 99, "99_1_QN017.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Promotion",
                columns: new[] { "ID", "Description", "Discount", "From", "IsDelete", "Name", "ProductID", "To", "Visible" },
                values: new object[,]
                {
                    { 18, "Giảm giá cực sốc từ 10% đến 50% nhân dịp cuối năm", 30, new DateTime(2021, 12, 21, 11, 31, 31, 638, DateTimeKind.Local).AddTicks(6700), false, "Sale cuối năm", 65, new DateTime(2022, 1, 30, 11, 31, 31, 638, DateTimeKind.Local).AddTicks(6700), true },
                    { 17, "Giảm giá cực sốc từ 10% đến 50% nhân dịp cuối năm", 30, new DateTime(2021, 12, 21, 11, 31, 31, 638, DateTimeKind.Local).AddTicks(6690), false, "Sale cuối năm", 64, new DateTime(2022, 1, 30, 11, 31, 31, 638, DateTimeKind.Local).AddTicks(6690), true },
                    { 9, "Giảm giá cực sốc từ 10% đến 50% nhân dịp cuối năm", 50, new DateTime(2021, 12, 21, 11, 31, 31, 638, DateTimeKind.Local).AddTicks(6650), false, "Sale cuối năm", 22, new DateTime(2022, 1, 30, 11, 31, 31, 638, DateTimeKind.Local).AddTicks(6650), true },
                    { 13, "Giảm giá cực sốc từ 10% đến 50% nhân dịp cuối năm", 20, new DateTime(2021, 12, 21, 11, 31, 31, 638, DateTimeKind.Local).AddTicks(6670), false, "Sale cuối năm", 50, new DateTime(2022, 1, 30, 11, 31, 31, 638, DateTimeKind.Local).AddTicks(6670), true },
                    { 7, "Giảm giá cực sốc từ 10% đến 50% nhân dịp cuối năm", 10, new DateTime(2021, 12, 21, 11, 31, 31, 638, DateTimeKind.Local).AddTicks(6640), false, "Sale cuối năm", 20, new DateTime(2022, 1, 30, 11, 31, 31, 638, DateTimeKind.Local).AddTicks(6640), true },
                    { 4, "Giảm giá cực sốc từ 10% đến 50% nhân dịp cuối năm", 20, new DateTime(2021, 12, 21, 11, 31, 31, 638, DateTimeKind.Local).AddTicks(6620), false, "Sale cuối năm", 4, new DateTime(2022, 1, 30, 11, 31, 31, 638, DateTimeKind.Local).AddTicks(6630), true },
                    { 12, "Giảm giá cực sốc từ 10% đến 50% nhân dịp cuối năm", 20, new DateTime(2021, 12, 21, 11, 31, 31, 638, DateTimeKind.Local).AddTicks(6660), false, "Sale cuối năm", 42, new DateTime(2022, 1, 30, 11, 31, 31, 638, DateTimeKind.Local).AddTicks(6670), true },
                    { 11, "Giảm giá cực sốc từ 10% đến 50% nhân dịp cuối năm", 20, new DateTime(2021, 12, 21, 11, 31, 31, 638, DateTimeKind.Local).AddTicks(6660), false, "Sale cuối năm", 41, new DateTime(2022, 1, 30, 11, 31, 31, 638, DateTimeKind.Local).AddTicks(6660), true },
                    { 1, "Giảm giá cực sốc từ 10% đến 50% nhân dịp cuối năm", 10, new DateTime(2021, 12, 21, 11, 31, 31, 638, DateTimeKind.Local).AddTicks(2070), false, "Sale cuối năm", 1, new DateTime(2022, 1, 30, 11, 31, 31, 638, DateTimeKind.Local).AddTicks(3250), true },
                    { 8, "Giảm giá cực sốc từ 10% đến 50% nhân dịp cuối năm", 50, new DateTime(2021, 12, 21, 11, 31, 31, 638, DateTimeKind.Local).AddTicks(6640), false, "Sale cuối năm", 21, new DateTime(2022, 1, 30, 11, 31, 31, 638, DateTimeKind.Local).AddTicks(6650), true },
                    { 16, "Giảm giá cực sốc từ 10% đến 50% nhân dịp cuối năm", 40, new DateTime(2021, 12, 21, 11, 31, 31, 638, DateTimeKind.Local).AddTicks(6690), false, "Sale cuối năm", 63, new DateTime(2022, 1, 30, 11, 31, 31, 638, DateTimeKind.Local).AddTicks(6690), true },
                    { 10, "Giảm giá cực sốc từ 10% đến 50% nhân dịp cuối năm", 10, new DateTime(2021, 12, 21, 11, 31, 31, 638, DateTimeKind.Local).AddTicks(6650), false, "Sale cuối năm", 40, new DateTime(2022, 1, 30, 11, 31, 31, 638, DateTimeKind.Local).AddTicks(6660), true },
                    { 6, "Giảm giá cực sốc từ 10% đến 50% nhân dịp cuối năm", 10, new DateTime(2021, 12, 21, 11, 31, 31, 638, DateTimeKind.Local).AddTicks(6630), false, "Sale cuối năm", 6, new DateTime(2022, 1, 30, 11, 31, 31, 638, DateTimeKind.Local).AddTicks(6640), true },
                    { 15, "Giảm giá cực sốc từ 10% đến 50% nhân dịp cuối năm", 40, new DateTime(2021, 12, 21, 11, 31, 31, 638, DateTimeKind.Local).AddTicks(6680), false, "Sale cuối năm", 52, new DateTime(2022, 1, 30, 11, 31, 31, 638, DateTimeKind.Local).AddTicks(6680), true },
                    { 2, "Giảm giá cực sốc từ 10% đến 50% nhân dịp cuối năm", 20, new DateTime(2021, 12, 21, 11, 31, 31, 638, DateTimeKind.Local).AddTicks(6510), false, "Sale cuối năm", 2, new DateTime(2022, 1, 30, 11, 31, 31, 638, DateTimeKind.Local).AddTicks(6540), true },
                    { 14, "Giảm giá cực sốc từ 10% đến 50% nhân dịp cuối năm", 50, new DateTime(2021, 12, 21, 11, 31, 31, 638, DateTimeKind.Local).AddTicks(6680), false, "Sale cuối năm", 51, new DateTime(2022, 1, 30, 11, 31, 31, 638, DateTimeKind.Local).AddTicks(6680), true },
                    { 5, "Giảm giá cực sốc từ 10% đến 50% nhân dịp cuối năm", 10, new DateTime(2021, 12, 21, 11, 31, 31, 638, DateTimeKind.Local).AddTicks(6630), false, "Sale cuối năm", 5, new DateTime(2022, 1, 30, 11, 31, 31, 638, DateTimeKind.Local).AddTicks(6630), true },
                    { 20, "Giảm giá cực sốc từ 10% đến 50% nhân dịp cuối năm", 10, new DateTime(2021, 12, 21, 11, 31, 31, 638, DateTimeKind.Local).AddTicks(6700), false, "Sale cuối năm", 85, new DateTime(2022, 1, 30, 11, 31, 31, 638, DateTimeKind.Local).AddTicks(6710), true },
                    { 3, "Giảm giá cực sốc từ 10% đến 50% nhân dịp cuối năm", 30, new DateTime(2021, 12, 21, 11, 31, 31, 638, DateTimeKind.Local).AddTicks(6620), false, "Sale cuối năm", 3, new DateTime(2022, 1, 30, 11, 31, 31, 638, DateTimeKind.Local).AddTicks(6620), true },
                    { 19, "Giảm giá cực sốc từ 10% đến 50% nhân dịp cuối năm", 10, new DateTime(2021, 12, 21, 11, 31, 31, 638, DateTimeKind.Local).AddTicks(6700), false, "Sale cuối năm", 83, new DateTime(2022, 1, 30, 11, 31, 31, 638, DateTimeKind.Local).AddTicks(6700), true }
                });

            migrationBuilder.Sql(
                "INSERT [dbo].[Receipt] ([Fullname], [Phone], [Email], [Address], [Notes], [TotalPrice], [TotalDiscount], [ShippingCost], [TotalPay], [Method], [Status], [OrderAt], [DeliveryAt], [CardNumber], [ValidDate], [SecretNumber], [accountID])"
                + "VALUES (N'Diệc Lữ Chí Vĩ', N'0909010003', N'diecluchivi2701@gmail.com', N'12 Nguyễn Huệ P.Bến Nghé Q.1', N'', 858000, 154800, 25000, 728200, N'COD', N'Đã giao hàng', CAST(N'2021-12-20T20:26:29.7779545' AS DateTime2), CAST(N'2021-12-20T21:34:12.0857144' AS DateTime2), NULL, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, 1), "
                + "(N'Diệc Lữ Chí Vĩ', N'0909010003', N'diecluchivi2701@gmail.com', N'12 Nguyễn Huệ P.Bến Nghé Q.1', N'', 1026000, 421000, 25000, 630000, N'CreditCard', N'Đã giao hàng', CAST(N'2021-12-20T20:27:26.4262472' AS DateTime2), CAST(N'2021-12-20T21:34:20.6306533' AS DateTime2), N'271119473238', CAST(N'2023-12-20T00:00:00.0000000' AS DateTime2), N'2986361', 1), "
                + "(N'Diệc Lữ Chí Vĩ', N'0909010003', N'diecluchivi2701@gmail.com', N'12 Nguyễn Huệ P.Bến Nghé Q.1', N'', 1225000, 85800, 25000, 1164200, N'COD', N'Đã giao hàng', CAST(N'2021-12-20T20:28:44.0234232' AS DateTime2), CAST(N'2021-12-20T21:34:25.4144703' AS DateTime2), NULL, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, 1), "
                + "(N'Diệc Lữ Chí Vĩ', N'0909010003', N'diecluchivi2701@gmail.com', N'12 Nguyễn Huệ P.Bến Nghé Q.1', N'', 827000, 344500, 25000, 507500, N'CreditCard', N'Đã giao hàng', CAST(N'2021-12-20T20:29:19.8517980' AS DateTime2), CAST(N'2021-12-20T21:34:30.7341374' AS DateTime2), N'271119473238', CAST(N'2023-12-20T00:00:00.0000000' AS DateTime2), N'2986361', 1), "
                + "(N'Tăng Cẩm Phú', N'0909110203', N'camphu480@gmail.com', N'12 Nguyễn Huệ P.Bến Nghé Q.2', N'', 2039000, 726700, 25000, 1337300, N'COD', N'Đã giao hàng', CAST(N'2021-12-20T20:30:52.5553498' AS DateTime2), CAST(N'2021-12-20T21:34:38.1017426' AS DateTime2), NULL, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, 2), "
                + "(N'Tăng Cẩm Phú', N'0909110203', N'camphu480@gmail.com', N'12 Nguyễn Huệ P.Bến Nghé Q.2', N'', 1393000, 99500, 25000, 1318500, N'CreditCard', N'Đã giao hàng', CAST(N'2021-12-20T20:31:29.4476637' AS DateTime2), CAST(N'2021-12-20T21:34:48.8133903' AS DateTime2), N'274611273238', CAST(N'2022-12-20T00:00:00.0000000' AS DateTime2), N'2916361', 2), "
                + "(N'Tăng Cẩm Phú', N'0909110203', N'camphu480@gmail.com', N'12 Nguyễn Huệ P.Bến Nghé Q.2', N'', 889000, 295900, 25000, 618100, N'CreditCard', N'Đã giao hàng', CAST(N'2021-12-20T20:33:12.7655872' AS DateTime2), CAST(N'2021-12-20T21:34:55.8812954' AS DateTime2), N'274611273238', CAST(N'2022-12-20T00:00:00.0000000' AS DateTime2), N'2916361', 2), "
                + "(N'Tăng Cẩm Phú', N'0909110203', N'camphu480@gmail.com', N'12 Nguyễn Huệ P.Bến Nghé Q.2', N'', 858000, 111900, 25000, 771100, N'CreditCard', N'Đã giao hàng', CAST(N'2021-12-20T20:34:01.4182859' AS DateTime2), CAST(N'2021-12-20T21:35:01.8605143' AS DateTime2), N'274611273238', CAST(N'2022-12-20T00:00:00.0000000' AS DateTime2), N'2916361', 2), "
                + "(N'Tăng Cẩm Phú', N'0909110203', N'camphu480@gmail.com', N'12 Nguyễn Huệ P.Bến Nghé Q.2', N'', 460000, 46000, 25000, 439000, N'CreditCard', N'Đã giao hàng', CAST(N'2021-12-20T20:34:46.1442920' AS DateTime2), CAST(N'2021-12-20T21:35:06.9645070' AS DateTime2), N'274611273238', CAST(N'2022-12-20T00:00:00.0000000' AS DateTime2), N'2916361', 2), "
                + "(N'Nguyễn Trân', N'0909020203', N'trannguyen@student.tdtu.edu.vn', N'12 Nguyễn Huệ P.Bến Nghé Q.3', N'', 1915000, 138000, 25000, 1802000, N'COD', N'Đã giao hàng', CAST(N'2021-12-20T20:36:58.2742353' AS DateTime2), CAST(N'2021-12-20T21:35:13.0328951' AS DateTime2), NULL, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, 3), "
                + "(N'Nguyễn Trân', N'0909020203', N'trannguyen@student.tdtu.edu.vn', N'12 Nguyễn Huệ P.Bến Nghé Q.3', N'', 858000, 108800, 25000, 774200, N'CreditCard', N'Đã giao hàng', CAST(N'2021-12-20T20:37:56.7255848' AS DateTime2), CAST(N'2021-12-20T21:35:19.9510165' AS DateTime2), N'274621133238', CAST(N'2023-12-20T00:00:00.0000000' AS DateTime2), N'2982360', 3), "
                + "(N'Nguyễn Trân', N'0909020203', N'trannguyen@student.tdtu.edu.vn', N'12 Nguyễn Huệ P.Bến Nghé Q.3', N'', 1517000, 0, 25000, 1542000, N'CreditCard', N'Đã giao hàng', CAST(N'2021-12-20T20:39:02.6164452' AS DateTime2), CAST(N'2021-12-20T21:35:32.2885826' AS DateTime2), N'274621133238', CAST(N'2023-12-20T00:00:00.0000000' AS DateTime2), N'2982360', 3), "
                + "(N'Nguyễn Trân', N'0909020203', N'trannguyen@student.tdtu.edu.vn', N'12 Nguyễn Huệ P.Bến Nghé Q.3', N'', 1287000, 0, 25000, 1312000, N'COD', N'Đã giao hàng', CAST(N'2021-12-20T20:39:54.6841605' AS DateTime2), CAST(N'2021-12-20T21:35:43.7213354' AS DateTime2), NULL, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, 3), "
                + "(N'Nguyễn Trân', N'0909020203', N'trannguyen@student.tdtu.edu.vn', N'12 Nguyễn Huệ P.Bến Nghé Q.3', N'', 1225000, 39800, 25000, 1210200, N'COD', N'Đã giao hàng', CAST(N'2021-12-20T20:41:19.4713283' AS DateTime2), CAST(N'2021-12-20T21:35:54.4887457' AS DateTime2), NULL, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, 3), "
                + "(N'Trần Hồng', N'0909010303', N'hongtran@student.tdtu.edu.vn', N'12 Nguyễn Huệ P.Bến Nghé Q.4', N'', 1853000, 46000, 25000, 1832000, N'CreditCard', N'Đã giao hàng', CAST(N'2021-12-20T20:43:23.1642856' AS DateTime2), CAST(N'2021-12-20T21:35:59.8377449' AS DateTime2), N'274629411438', CAST(N'2023-12-20T00:00:00.0000000' AS DateTime2), N'2986331', 4), "
                + "(N'Trần Hồng', N'0909010303', N'hongtran@student.tdtu.edu.vn', N'12 Nguyễn Huệ P.Bến Nghé Q.4', N'', 6453000, 0, 25000, 6478000, N'COD', N'Đã giao hàng', CAST(N'2021-12-20T20:45:58.9120044' AS DateTime2), CAST(N'2021-12-20T21:36:05.6583523' AS DateTime2), NULL, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, 4), "
                + "(N'Trần Hồng', N'0909010303', N'hongtran@student.tdtu.edu.vn', N'12 Nguyễn Huệ P.Bến Nghé Q.4', N'', 3277000, 0, 25000, 3302000, N'COD', N'Đã giao hàng', CAST(N'2021-12-20T20:47:56.6888207' AS DateTime2), CAST(N'2021-12-20T21:36:10.5454432' AS DateTime2), NULL, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, 4), "
                + "(N'Trần Hồng', N'0909010303', N'hongtran@student.tdtu.edu.vn', N'12 Nguyễn Huệ P.Bến Nghé Q.4', N'', 2344000, 0, 25000, 2369000, N'COD', N'Đã giao hàng', CAST(N'2021-12-20T20:48:47.1522309' AS DateTime2), CAST(N'2021-12-20T21:36:16.7835942' AS DateTime2), NULL, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, 4), "
                + "(N'Nhi Lý', N'0909610203', N'nhily@student.tdtu.edu.vn', N'12 Nguyễn Huệ P.Bến Nghé Q.5', N'', 4750000, 0, 25000, 4775000, N'COD', N'Đã giao hàng', CAST(N'2021-12-20T20:50:42.2813702' AS DateTime2), CAST(N'2021-12-20T21:36:22.0431493' AS DateTime2), NULL, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, 5), "
                + "(N'Nhi Lý', N'0909610203', N'nhily@student.tdtu.edu.vn', N'12 Nguyễn Huệ P.Bến Nghé Q.5', N'', 6466000, 0, 25000, 6491000, N'CreditCard', N'Đã giao hàng', CAST(N'2021-12-20T20:51:50.5486258' AS DateTime2), CAST(N'2021-12-20T21:36:28.1210215' AS DateTime2), N'115629473238', CAST(N'2023-12-20T00:00:00.0000000' AS DateTime2), N'2986364', 5), "
                + "(N'Nhi Lý', N'0909610203', N'nhily@student.tdtu.edu.vn', N'12 Nguyễn Huệ P.Bến Nghé Q.5', N'', 3525000, 46000, 25000, 3504000, N'CreditCard', N'Đã giao hàng', CAST(N'2021-12-20T20:53:31.3357753' AS DateTime2), CAST(N'2021-12-20T21:36:33.1546514' AS DateTime2), N'115629473238', CAST(N'2023-12-20T00:00:00.0000000' AS DateTime2), N'2986364', 5), "
                + "(N'Nhi Lý', N'0909610203', N'nhily@student.tdtu.edu.vn', N'12 Nguyễn Huệ P.Bến Nghé Q.5', N'', 3034000, 0, 25000, 3059000, N'COD', N'Đã giao hàng', CAST(N'2021-12-20T20:54:51.6343564' AS DateTime2), CAST(N'2021-12-20T21:36:38.3364780' AS DateTime2), NULL, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, 5), "
                + "(N'Hà Quỳnh', N'0989010203', N'quynhha@student.tdtu.edu.vn', N'12 Nguyễn Huệ P.Bến Nghé Q.6', N'', 1716000, 0, 25000, 1741000, N'COD', N'Đã giao hàng', CAST(N'2021-12-20T20:56:40.6870751' AS DateTime2), CAST(N'2021-12-20T21:36:42.9834503' AS DateTime2), NULL, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, 6), "
                + "(N'Hà Quỳnh', N'0989010203', N'quynhha@student.tdtu.edu.vn', N'12 Nguyễn Huệ P.Bến Nghé Q.6', N'', 2052000, 0, 25000, 2077000, N'COD', N'Đã giao hàng', CAST(N'2021-12-20T20:57:25.8184735' AS DateTime2), CAST(N'2021-12-20T21:36:48.5139430' AS DateTime2), NULL, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, 6), "
                + "(N'Hà Quỳnh', N'0989010203', N'quynhha@student.tdtu.edu.vn', N'12 Nguyễn Huệ P.Bến Nghé Q.6', N'', 2574000, 551500, 25000, 2047500, N'COD', N'Đã giao hàng', CAST(N'2021-12-20T20:58:33.8327600' AS DateTime2), CAST(N'2021-12-20T21:36:53.5854016' AS DateTime2), NULL, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, 6), "
                + "(N'Huy Huy', N'0909010203', N'huyhuy@student.tdtu.edu.vn', N'12 Nguyễn Huệ P.Bến Nghé Q.7', N'', 597000, 0, 25000, 622000, N'COD', N'Đã giao hàng', CAST(N'2021-12-20T21:04:46.2151579' AS DateTime2), CAST(N'2021-12-20T21:36:58.1246266' AS DateTime2), NULL, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, 7), "
                + "(N'Huy Huy', N'0909010203', N'huyhuy@student.tdtu.edu.vn', N'12 Nguyễn Huệ P.Bến Nghé Q.7', N'', 1685000, 532900, 25000, 1177100, N'COD', N'Đã giao hàng', CAST(N'2021-12-20T21:05:59.8222195' AS DateTime2), CAST(N'2021-12-20T21:37:02.7343361' AS DateTime2), NULL, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, 7), "
                + "(N'Huy Huy', N'0909010203', N'huyhuy@student.tdtu.edu.vn', N'12 Nguyễn Huệ P.Bến Nghé Q.7', N'', 460000, 46000, 25000, 439000, N'COD', N'Đã giao hàng', CAST(N'2021-12-20T21:06:23.7434743' AS DateTime2), CAST(N'2021-12-20T21:37:08.4855581' AS DateTime2), NULL, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, 7), "
                + "(N'Huy Huy', N'0909010203', N'huyhuy@student.tdtu.edu.vn', N'12 Nguyễn Huệ P.Bến Nghé Q.7', N'', 1088000, 226900, 25000, 886100, N'COD', N'Đã giao hàng', CAST(N'2021-12-20T21:07:21.2328590' AS DateTime2), CAST(N'2021-12-20T21:37:16.0334783' AS DateTime2), NULL, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, 7), "
                + "(N'Huy Huy', N'0909010203', N'huyhuy@student.tdtu.edu.vn', N'12 Nguyễn Huệ P.Bến Nghé Q.7', N'', 2786000, 19900, 25000, 2791100, N'COD', N'Đã giao hàng', CAST(N'2021-12-20T21:07:57.7386530' AS DateTime2), CAST(N'2021-12-20T21:37:21.0790680' AS DateTime2), NULL, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, 7), "
                + "(N'Thanh Thanh', N'0309010203', N'thanhthanh@student.tdtu.edu.vn', N'12 Nguyễn Huệ P.Bến Nghé Q.8', N'', 3737000, 0, 25000, 3762000, N'COD', N'Đã giao hàng', CAST(N'2021-12-20T21:09:46.2614255' AS DateTime2), CAST(N'2021-12-20T21:37:27.3564892' AS DateTime2), NULL, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, 8), "
                + "(N'Thanh Thanh', N'0309010203', N'thanhthanh@student.tdtu.edu.vn', N'12 Nguyễn Huệ P.Bến Nghé Q.8', N'', 3967000, 0, 25000, 3992000, N'CreditCard', N'Đã giao hàng', CAST(N'2021-12-20T21:10:49.7199932' AS DateTime2), CAST(N'2021-12-20T21:37:32.2912857' AS DateTime2), N'118629473238', CAST(N'2022-12-20T00:00:00.0000000' AS DateTime2), N'2886361', 8), "
                + "(N'Thanh Thanh', N'0309010203', N'thanhthanh@student.tdtu.edu.vn', N'12 Nguyễn Huệ P.Bến Nghé Q.8', N'', 2605000, 0, 25000, 2630000, N'CreditCard', N'Đã giao hàng', CAST(N'2021-12-20T21:12:41.3296721' AS DateTime2), CAST(N'2021-12-20T21:37:37.1405058' AS DateTime2), N'118629473238', CAST(N'2022-12-20T00:00:00.0000000' AS DateTime2), N'2886361', 8), "
                + "(N'Tùng Trần', N'0904010203', N'tungtran@student.tdtu.edu.vn', N'12 Nguyễn Huệ P.Bến Nghé Q.9', N'', 1884000, 326400, 25000, 1582600, N'COD', N'Đã giao hàng', CAST(N'2021-12-20T21:21:48.8969695' AS DateTime2), CAST(N'2021-12-20T21:37:41.5189630' AS DateTime2), NULL, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, 9), "
                + "(N'Tùng Trần', N'0904010203', N'tungtran@student.tdtu.edu.vn', N'12 Nguyễn Huệ P.Bến Nghé Q.9', N'', 1915000, 177800, 25000, 1762200, N'CreditCard', N'Đã giao hàng', CAST(N'2021-12-20T21:22:58.3523646' AS DateTime2), CAST(N'2021-12-20T21:37:46.9124800' AS DateTime2), N'271199473238', CAST(N'2022-12-20T00:00:00.0000000' AS DateTime2), N'2989361', 9), "
                + "(N'Trần Huy', N'0908010203', N'huytran@student.tdtu.edu.vn', N'12 Nguyễn Huệ P.Bến Nghé Q.10', N'', 1287000, 356900, 25000, 955100, N'CreditCard', N'Đã giao hàng', CAST(N'2021-12-20T21:24:13.2529645' AS DateTime2), CAST(N'2021-12-20T21:37:51.9861684' AS DateTime2), N'212029473238', CAST(N'2022-12-20T00:00:00.0000000' AS DateTime2), N'2196361', 10), "
                + "(N'Trần Huy', N'0908010203', N'huytran@student.tdtu.edu.vn', N'12 Nguyễn Huệ P.Bến Nghé Q.10', N'', 1088000, 157900, 25000, 955100, N'COD', N'Đã giao hàng', CAST(N'2021-12-20T21:24:45.8665997' AS DateTime2), CAST(N'2021-12-20T21:37:57.0775272' AS DateTime2), NULL, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, 10), "
                + "(N'Hứa Huy', N'0900010203', N'huyhua@student.tdtu.edu.vn', N'12 Nguyễn Huệ P.Bến Nghé Q.11', N'', 2313000, 563900, 25000, 1774100, N'COD', N'Đã giao hàng', CAST(N'2021-12-20T21:26:09.2239860' AS DateTime2), CAST(N'2021-12-20T21:38:01.2302066' AS DateTime2), NULL, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, 11), "
                + "(N'Hứa Huy', N'0900010203', N'huyhua@student.tdtu.edu.vn', N'12 Nguyễn Huệ P.Bến Nghé Q.11', N'', 4520000, 0, 25000, 4545000, N'CreditCard', N'Đã giao hàng', CAST(N'2021-12-20T21:27:59.5602956' AS DateTime2), CAST(N'2021-12-20T21:38:06.1481278' AS DateTime2), N'271219473238', CAST(N'2023-12-20T00:00:00.0000000' AS DateTime2), N'2982361', 11), "
                + "(N'Đặng Khôi', N'0990210203', N'khoidang@student.tdtu.edu.vn', N'12 Nguyễn Huệ P.Bến Nghé Q.12', N'', 1623000, 99500, 25000, 1548500, N'COD', N'Đã giao hàng', CAST(N'2021-12-20T21:30:20.9756838' AS DateTime2), CAST(N'2021-12-20T21:38:11.7343428' AS DateTime2), NULL, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, 12), "
                + "(N'Đặng Khôi', N'0990210203', N'khoidang@student.tdtu.edu.vn', N'12 Nguyễn Huệ P.Bến Nghé Q.12', N'', 2220000, 0, 25000, 2245000, N'CreditCard', N'Đã giao hàng', CAST(N'2021-12-20T21:31:03.6263310' AS DateTime2), CAST(N'2021-12-20T21:38:16.7973305' AS DateTime2), N'274612273238', CAST(N'2023-12-20T00:00:00.0000000' AS DateTime2), N'2186361', 12)"
            );

            migrationBuilder.Sql(
                "INSERT [dbo].[ReceiptDetail] ([ProductID], [ReceiptID], [Size], [Color], [Quantity], [TotalPrice])  VALUES (1, 1, N'M', N'Xanh dương', 2, 358200), "
                + "(2, 1, N'M', N'Xanh lá', 1, 184000), "
                + "(3, 1, N'M', N'Trắng', 1, 161000), "
                + "(20, 2, N'M', N'Trắng', 1, 207000), "
                + "(21, 2, N'M', N'Vàng', 1, 99500), "
                + "(22, 2, N'M', N'Xám', 3, 298500), "
                + "(39, 3, N'M', N'Trắng', 3, 597000), "
                + "(40, 3, N'M', N'Trắng', 2, 358200), "
                + "(41, 3, N'M', N'Caro xanh', 1, 184000), "
                + "(50, 4, N'M', N'Xanh biển', 1, 184000), "
                + "(51, 4, N'M', N'Caro cam', 3, 298500), "
                + "(63, 5, N'M', N'Đen', 5, 690000), "
                + "(64, 5, N'M', N'Đỏ', 3, 483000), "
                + "(65, 5, N'M', N'Vàng kem', 1, 139300), "
                + "(83, 6, N'M', N'Đen', 5, 895500), "
                + "(84, 6, N'M', N'Xanh jean', 2, 398000), "
                + "(1, 7, N'L', N'Trắng', 1, 179100), "
                + "(52, 7, N'M', N'Trắng', 3, 414000), "
                + "(39, 8, N'M', N'Trắng', 1, 199000), "
                + "(40, 8, N'L', N'Trắng', 1, 179100), "
                + "(41, 8, N'L', N'Caro xanh', 2, 368000), "
                + "(20, 9, N'L', N'Trắng', 2, 414000), "
                + "(42, 10, N'M', N'Caro xám', 3, 552000), "
                + "(43, 10, N'L', N'Caro đỏ', 5, 995000), "
                + "(44, 10, N'L', N'Caro đỏ', 1, 230000), "
                + "(4, 11, N'M', N'Vàng cam', 1, 184000), "
                + "(5, 11, N'M', N'Vàng', 1, 207000), "
                + "(6, 11, N'L', N'Đỏ', 2, 358200), "
                + "(23, 12, N'M', N'Trắng', 3, 690000), "
                + "(24, 12, N'M', N'Xanh rêu', 1, 230000), "
                + "(25, 12, N'M', N'Trắng', 3, 597000), "
                + "(53, 13, N'L', N'Đen', 1, 199000), "
                + "(54, 13, N'L', N'Xanh biển', 1, 199000), "
                + "(55, 13, N'L', N'Hoạ tiết 1', 1, 230000), "
                + "(66, 13, N'L', N'Đỏ', 1, 199000), "
                + "(67, 13, N'L', N'Vàng', 1, 230000), "
                + "(68, 13, N'L', N'Xanh rêu', 1, 230000), "
                + "(83, 14, N'M', N'Đen', 1, 179100), "
                + "(84, 14, N'M', N'Xanh jean', 1, 199000), "
                + "(85, 14, N'M', N'Xanh jean', 1, 179100), "
                + "(86, 14, N'M', N'Đen', 1, 199000), "
                + "(87, 14, N'L', N'Xanh jean', 1, 199000), "
                + "(88, 14, N'L', N'Đen', 1, 230000), "
                + "(45, 15, N'L', N'Trắng', 1, 199000), "
                + "(46, 15, N'L', N'Đen', 1, 199000), "
                + "(47, 15, N'L', N'Đen', 1, 199000), "
                + "(48, 15, N'L', N'Đen', 1, 199000), "
                + "(49, 15, N'L', N'Xanh biển', 1, 230000), "
                + "(50, 15, N'M', N'Xanh biển', 1, 184000), "
                + "(26, 15, N'L', N'Đen', 1, 199000), "
                + "(27, 15, N'L', N'Trắng', 1, 199000), "
                + "(28, 15, N'L', N'Đen', 1, 199000), "
                + "(7, 16, N'M', N'Xanh lá', 1, 230000), "
                + "(8, 16, N'M', N'Trắng', 3, 690000), "
                + "(9, 16, N'M', N'Trắng', 5, 1150000), "
                + "(10, 16, N'L', N'Đen', 5, 995000), "
                + "(11, 16, N'L', N'Xanh dương', 1, 230000), "
                + "(12, 16, N'L', N'Đen', 2, 398000), "
                + "(56, 16, N'L', N'Xanh biển', 4, 920000), "
                + "(57, 16, N'L', N'Trắng', 3, 690000), "
                + "(55, 16, N'L', N'Hoạ tiết 1', 5, 1150000), "
                + "(69, 17, N'L', N'Đen', 3, 690000), "
                + "(70, 17, N'L', N'Đen', 4, 796000), "
                + "(71, 17, N'L', N'Đỏ', 1, 199000), "
                + "(72, 17, N'L', N'Xanh rêu', 6, 1194000), "
                + "(73, 17, N'L', N'Vàng kem', 1, 199000), "
                + "(74, 17, N'L', N'Xám', 1, 199000), "
                + "(89, 18, N'L', N'Xám', 4, 920000), "
                + "(90, 18, N'L', N'Xám', 1, 199000), "
                + "(91, 18, N'L', N'Đen', 1, 199000), "
                + "(86, 18, N'L', N'Đen', 3, 597000), "
                + "(87, 18, N'L', N'Xanh jean', 1, 199000), "
                + "(88, 18, N'L', N'Đen', 1, 230000), "
                + "(13, 19, N'L', N'Đỏ', 1, 230000), "
                + "(14, 19, N'L', N'Xanh đen', 5, 995000), "
                + "(15, 19, N'L', N'Đen', 6, 1380000), "
                + "(16, 19, N'L', N'Xám', 1, 199000), "
                + "(17, 19, N'L', N'Xám', 5, 1150000), "
                + "(18, 19, N'L', N'Xanh đen', 1, 199000), "
                + "(19, 19, N'L', N'Trắng vàng', 3, 597000), "
                + "(32, 20, N'L', N'Trắng', 1, 230000), "
                + "(33, 20, N'L', N'Đen', 8, 1592000), "
                + "(34, 20, N'L', N'Xám', 5, 995000), "
                + "(35, 20, N'L', N'Xanh đen', 8, 1840000), "
                + "(36, 20, N'L', N'Trắng', 1, 199000), "
                + "(37, 20, N'L', N'Xanh', 1, 230000), "
                + "(38, 20, N'L', N'Đen', 6, 1380000), "
                + "(45, 21, N'L', N'Trắng', 1, 199000), "
                + "(46, 21, N'L', N'Đen', 1, 199000), "
                + "(47, 21, N'L', N'Trắng', 1, 199000), "
                + "(49, 21, N'L', N'Xanh biển', 9, 2070000), "
                + "(48, 21, N'L', N'Đen', 1, 199000), "
                + "(62, 21, N'L', N'Xanh biển', 1, 230000), "
                + "(50, 21, N'M', N'Xanh biển', 1, 184000), "
                + "(54, 21, N'L', N'Xanh biển', 1, 199000), "
                + "(75, 22, N'L', N'Nâu', 1, 199000), "
                + "(76, 22, N'L', N'Đen', 3, 597000), "
                + "(77, 22, N'L', N'Xám', 4, 920000), "
                + "(78, 22, N'L', N'Đỏ', 1, 199000), "
                + "(79, 22, N'L', N'Đen', 4, 920000), "
                + "(80, 22, N'L', N'Xanh rêu', 1, 199000), "
                + "(81, 23, N'L', N'Trắng', 2, 398000), "
                + "(82, 23, N'L', N'Đen', 3, 690000), "
                + "(95, 23, N'L', N'Xanh rêu', 1, 230000), "
                + "(96, 23, N'L', N'Xám', 1, 199000), "
                + "(97, 23, N'L', N'Nâu nhạt', 1, 199000), "
                + "(98, 24, N'L', N'Đen', 1, 199000), "
                + "(99, 24, N'L', N'Xám jean', 1, 230000), "
                + "(100, 24, N'L', N'Trắng', 6, 1194000), "
                + "(101, 24, N'L', N'Trắng', 1, 230000), "
                + "(102, 24, N'L', N'Đen', 1, 199000), "
                + "(20, 25, N'M', N'Trắng', 1, 207000), "
                + "(21, 25, N'L', N'Nâu nhạt', 3, 298500), "
                + "(50, 25, N'L', N'Xanh biển', 5, 920000), "
                + "(54, 25, N'L', N'Xanh biển', 2, 398000), "
                + "(58, 25, N'L', N'Xanh dương', 1, 199000), "
                + "(39, 26, N'M', N'Trắng', 1, 199000), "
                + "(39, 26, N'L', N'Trắng', 2, 398000), "
                + "(40, 27, N'M', N'Trắng', 1, 179100), "
                + "(41, 27, N'M', N'Caro xanh', 1, 184000), "
                + "(42, 27, N'M', N'Caro xám', 1, 184000), "
                + "(20, 27, N'M', N'Trắng', 1, 207000), "
                + "(21, 27, N'M', N'Vàng', 1, 99500), "
                + "(22, 27, N'L', N'Đỏ', 3, 298500), "
                + "(20, 28, N'M', N'Trắng', 2, 414000), "
                + "(39, 29, N'M', N'Trắng', 1, 199000), "
                + "(40, 29, N'L', N'Trắng', 1, 179100), "
                + "(41, 29, N'M', N'Caro đỏ', 1, 184000), "
                + "(63, 29, N'L', N'Đen', 1, 138000), "
                + "(64, 29, N'M', N'Đỏ', 1, 161000), "
                + "(83, 30, N'M', N'Đen', 1, 179100), "
                + "(84, 30, N'M', N'Xanh jean', 8, 1592000), "
                + "(84, 30, N'L', N'Xanh jean', 5, 995000), "
                + "(75, 31, N'L', N'Nâu', 2, 398000), "
                + "(79, 31, N'L', N'Đen', 1, 230000), "
                + "(82, 31, N'L', N'Đen', 3, 690000), "
                + "(81, 31, N'L', N'Trắng', 3, 597000), "
                + "(80, 31, N'L', N'Xanh rêu', 5, 995000), "
                + "(78, 31, N'L', N'Đỏ', 2, 398000), "
                + "(76, 31, N'L', N'Đen', 1, 199000), "
                + "(77, 31, N'L', N'Xám', 1, 230000), "
                + "(13, 32, N'L', N'Đỏ', 3, 690000), "
                + "(14, 32, N'L', N'Xanh đen', 1, 199000), "
                + "(15, 32, N'L', N'Đen', 2, 460000), "
                + "(16, 32, N'L', N'Xám', 3, 597000), "
                + "(17, 32, N'L', N'Xám', 1, 230000), "
                + "(18, 32, N'L', N'Xanh đen', 4, 796000), "
                + "(19, 32, N'L', N'Trắng vàng', 5, 995000), "
                + "(32, 33, N'L', N'Trắng', 5, 1150000), "
                + "(33, 33, N'L', N'Đen', 1, 199000), "
                + "(34, 33, N'L', N'Xám', 1, 199000), "
                + "(35, 33, N'L', N'Xanh đen', 1, 230000), "
                + "(36, 33, N'L', N'Trắng', 3, 597000), "
                + "(37, 33, N'L', N'Xanh', 1, 230000), "
                + "(39, 34, N'L', N'Trắng', 1, 199000), "
                + "(40, 34, N'L', N'Trắng', 1, 179100), "
                + "(41, 34, N'L', N'Caro xanh', 1, 184000), "
                + "(63, 34, N'M', N'Đỏ', 1, 138000), "
                + "(64, 34, N'M', N'Đỏ', 1, 161000), "
                + "(65, 34, N'M', N'Xám', 1, 139300), "
                + "(83, 34, N'L', N'Đen', 1, 179100), "
                + "(84, 34, N'L', N'Xanh jean', 1, 199000), "
                + "(85, 34, N'M', N'Xanh jean', 1, 179100), "
                + "(66, 35, N'L', N'Đỏ', 2, 398000), "
                + "(67, 35, N'L', N'Vàng', 1, 230000), "
                + "(86, 35, N'M', N'Đen', 1, 199000), "
                + "(1, 35, N'L', N'Xanh dương', 2, 358200), "
                + "(2, 35, N'L', N'Xanh lá', 3, 552000), "
                + "(1, 36, N'L', N'Xanh dương', 1, 179100), "
                + "(2, 36, N'L', N'Xanh lá', 1, 184000), "
                + "(3, 36, N'L', N'Trắng', 1, 161000), "
                + "(20, 36, N'L', N'Trắng', 1, 207000), "
                + "(21, 36, N'L', N'Nâu nhạt', 1, 99500), "
                + "(22, 36, N'M', N'Đỏ', 1, 99500), "
                + "(39, 37, N'M', N'Trắng', 1, 199000), "
                + "(40, 37, N'L', N'Trắng', 1, 179100), "
                + "(41, 37, N'M', N'Caro đỏ', 3, 552000), "
                + "(63, 38, N'M', N'Đỏ', 3, 414000), "
                + "(64, 38, N'M', N'Đỏ', 1, 161000), "
                + "(65, 38, N'M', N'Xám', 3, 417900), "
                + "(83, 38, N'M', N'Đen', 1, 179100), "
                + "(84, 38, N'M', N'Xanh jean', 2, 398000), "
                + "(85, 38, N'L', N'Xanh jean', 1, 179100), "
                + "(45, 39, N'L', N'Trắng', 1, 199000), "
                + "(46, 39, N'L', N'Đen', 1, 199000), "
                + "(47, 39, N'M', N'Đen', 1, 199000), "
                + "(48, 39, N'L', N'Đen', 3, 597000), "
                + "(36, 39, N'L', N'Trắng', 1, 199000), "
                + "(37, 39, N'L', N'Xanh', 1, 230000), "
                + "(35, 39, N'L', N'Xanh đen', 1, 230000), "
                + "(38, 39, N'L', N'Đen', 8, 1840000), "
                + "(13, 39, N'L', N'Đỏ', 1, 230000), "
                + "(19, 39, N'L', N'Trắng vàng', 1, 199000), "
                + "(16, 39, N'L', N'Xám', 1, 199000), "
                + "(18, 39, N'L', N'Xanh đen', 1, 199000), "
                + "(48, 40, N'L', N'Đen', 1, 199000), "
                + "(45, 40, N'L', N'Trắng', 1, 199000), "
                + "(22, 40, N'M', N'Xám', 1, 99500), "
                + "(25, 40, N'M', N'Trắng', 1, 199000), "
                + "(27, 40, N'L', N'Trắng', 1, 199000), "
                + "(30, 40, N'L', N'Đen', 1, 230000), "
                + "(26, 40, N'L', N'Đen', 1, 199000), "
                + "(28, 40, N'L', N'Đen', 1, 199000), "
                + "(26, 41, N'L', N'Đen', 5, 995000), "
                + "(27, 41, N'L', N'Trắng', 4, 796000), "
                + "(28, 41, N'L', N'Đen', 1, 199000), "
                + "(29, 41, N'L', N'Trắng', 1, 230000)"
            );
            
            migrationBuilder.InsertData(
                table: "Rating",
                columns: new[] { "ID", "IsDelete", "ProductID", "ReceiptID", "Star" },
                values: new object[,]
                {
                    { 44, false, 45, 15, 3 },
                    { 45, false, 46, 15, 4 },
                    { 89, false, 46, 21, 3 },
                    { 130, false, 64, 29, 4 },
                    { 25, false, 44, 10, 4 },
                    { 13, false, 64, 5, 3 },
                    { 88, false, 45, 21, 4 },
                    { 121, false, 42, 27, 4 },
                    { 24, false, 43, 10, 4 },
                    { 111, false, 102, 24, 3 },
                    { 14, false, 65, 5, 4 },
                    { 35, false, 66, 13, 4 },
                    { 98, false, 77, 22, 3 },
                    { 23, false, 42, 10, 3 },
                    { 48, false, 49, 15, 4 },
                    { 90, false, 47, 21, 4 },
                    { 95, false, 54, 21, 3 },
                    { 115, false, 54, 25, 3 },
                    { 64, false, 71, 17, 3 },
                    { 32, false, 53, 13, 3 },
                    { 34, false, 55, 13, 4 },
                    { 65, false, 72, 17, 4 },
                    { 99, false, 78, 22, 3 },
                    { 18, false, 52, 7, 3 },
                    { 61, false, 55, 16, 4 },
                    { 59, false, 56, 16, 4 },
                    { 63, false, 70, 17, 3 },
                    { 60, false, 57, 16, 3 },
                    { 66, false, 73, 17, 3 },
                    { 11, false, 51, 4, 4 },
                    { 116, false, 58, 25, 4 },
                    { 62, false, 69, 17, 3 },
                    { 67, false, 74, 17, 3 },
                    { 97, false, 76, 22, 3 },
                    { 96, false, 75, 22, 4 },
                    { 36, false, 67, 13, 3 },
                    { 129, false, 63, 29, 4 },
                    { 12, false, 63, 5, 4 },
                    { 47, false, 48, 15, 3 },
                    { 46, false, 47, 15, 3 },
                    { 92, false, 48, 21, 4 },
                    { 37, false, 68, 14, 3 },
                    { 93, false, 62, 21, 3 },
                    { 10, false, 50, 4, 3 },
                    { 49, false, 50, 15, 4 },
                    { 94, false, 50, 21, 3 },
                    { 114, false, 50, 25, 3 },
                    { 91, false, 49, 21, 3 },
                    { 33, false, 54, 13, 3 },
                    { 51, false, 27, 15, 3 },
                    { 128, false, 41, 29, 4 },
                    { 58, false, 12, 16, 4 },
                    { 42, false, 87, 14, 4 },
                    { 74, false, 13, 19, 3 },
                    { 75, false, 14, 19, 4 },
                    { 76, false, 15, 19, 3 },
                    { 77, false, 16, 19, 3 },
                    { 71, false, 86, 18, 4 },
                    { 78, false, 17, 19, 3 },
                    { 41, false, 86, 14, 4 },
                    { 72, false, 87, 18, 3 },
                    { 79, false, 18, 19, 3 },
                    { 4, false, 20, 2, 4 },
                    { 100, false, 79, 22, 3 },
                    { 112, false, 20, 25, 3 },
                    { 122, false, 20, 27, 4 },
                    { 125, false, 20, 28, 3 },
                    { 40, false, 85, 14, 3 },
                    { 5, false, 21, 2, 4 },
                    { 113, false, 21, 25, 4 },
                    { 123, false, 21, 27, 4 },
                    { 80, false, 19, 19, 3 },
                    { 57, false, 11, 16, 3 },
                    { 56, false, 10, 16, 3 },
                    { 43, false, 88, 14, 3 },
                    { 1, false, 1, 1, 4 },
                    { 17, false, 1, 7, 4 },
                    { 110, false, 101, 24, 3 },
                    { 109, false, 100, 24, 3 },
                    { 2, false, 2, 1, 3 },
                    { 108, false, 99, 24, 3 },
                    { 3, false, 3, 1, 3 },
                    { 107, false, 98, 24, 3 },
                    { 26, false, 4, 11, 3 },
                    { 106, false, 97, 23, 4 },
                    { 105, false, 96, 23, 4 },
                    { 27, false, 5, 11, 3 },
                    { 104, false, 95, 23, 4 },
                    { 28, false, 6, 11, 4 },
                    { 53, false, 7, 16, 4 },
                    { 70, false, 91, 18, 4 },
                    { 54, false, 8, 16, 3 },
                    { 69, false, 90, 18, 4 },
                    { 68, false, 89, 18, 3 },
                    { 55, false, 9, 16, 3 },
                    { 73, false, 88, 18, 3 },
                    { 6, false, 22, 2, 4 },
                    { 124, false, 22, 27, 4 },
                    { 22, false, 20, 9, 4 },
                    { 102, false, 81, 23, 3 },
                    { 118, false, 39, 26, 4 },
                    { 119, false, 40, 27, 3 },
                    { 82, false, 33, 20, 4 },
                    { 83, false, 34, 20, 4 },
                    { 103, false, 82, 23, 3 },
                    { 84, false, 35, 20, 3 },
                    { 20, false, 40, 8, 4 },
                    { 81, false, 32, 20, 4 },
                    { 85, false, 36, 20, 3 },
                    { 86, false, 37, 20, 4 },
                    { 101, false, 80, 22, 4 },
                    { 87, false, 38, 20, 3 },
                    { 7, false, 39, 3, 4 },
                    { 19, false, 39, 8, 4 },
                    { 126, false, 39, 29, 4 },
                    { 117, false, 39, 26, 3 },
                    { 8, false, 40, 3, 3 },
                    { 52, false, 28, 15, 4 },
                    { 127, false, 40, 29, 4 },
                    { 30, false, 24, 12, 3 },
                    { 16, false, 84, 6, 3 },
                    { 15, false, 83, 6, 3 },
                    { 29, false, 23, 12, 4 },
                    { 21, false, 41, 8, 3 },
                    { 120, false, 41, 27, 4 },
                    { 9, false, 41, 3, 3 },
                    { 39, false, 84, 14, 4 },
                    { 31, false, 25, 12, 3 },
                    { 131, false, 83, 30, 3 },
                    { 38, false, 83, 14, 3 },
                    { 50, false, 26, 15, 3 },
                    { 133, false, 84, 30, 4 },
                    { 132, false, 84, 30, 4 }
                });

            migrationBuilder.InsertData(
                table: "Warehouse",
                columns: new[] { "ID", "Color", "LastUpdate", "ProductID", "Quantity", "Size", "Sold" },
                values: new object[,]
                {
                    { 170, "Xanh rêu", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6630), 95, 100, "L", 1 },
                    { 148, "Xám", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6570), 77, 100, "L", 5 },
                    { 149, "Đỏ", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6580), 78, 100, "L", 3 },
                    { 151, "Xanh rêu", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6580), 80, 100, "L", 6 },
                    { 150, "Đen", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6580), 79, 100, "L", 5 },
                    { 176, "Trắng", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6650), 101, 100, "L", 1 },
                    { 138, "Vàng", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6540), 67, 100, "L", 2 },
                    { 172, "Nâu nhạt", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6640), 97, 100, "L", 1 },
                    { 175, "Trắng", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6650), 100, 100, "L", 6 },
                    { 137, "Đỏ", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6540), 66, 100, "L", 3 },
                    { 173, "Đen", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6640), 98, 100, "L", 1 },
                    { 174, "Xám jean", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6640), 99, 100, "L", 1 },
                    { 171, "Xám", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6640), 96, 100, "L", 1 },
                    { 169, "Xám", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6630), 94, 100, "L", 0 },
                    { 156, "Xanh jean", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6590), 84, 100, "M", 13 },
                    { 139, "Xanh rêu", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6550), 68, 100, "L", 1 },
                    { 158, "Xanh jean", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6600), 85, 100, "M", 2 },
                    { 159, "Xanh jean", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6600), 85, 100, "L", 1 },
                    { 144, "Vàng kem", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6560), 73, 100, "L", 1 },
                    { 155, "Đen", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6590), 83, 100, "L", 1 },
                    { 143, "Xanh rêu", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6560), 72, 100, "L", 6 },
                    { 145, "Xám", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6560), 74, 100, "L", 1 },
                    { 154, "Đen", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6590), 83, 100, "M", 8 },
                    { 142, "Đỏ", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6550), 71, 100, "L", 1 },
                    { 160, "Đen", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6600), 86, 100, "M", 2 },
                    { 161, "Đen", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6610), 86, 100, "L", 3 },
                    { 146, "Nâu", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6570), 75, 100, "L", 3 },
                    { 153, "Đen", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6590), 82, 100, "L", 6 },
                    { 162, "Xanh jean", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6610), 87, 100, "L", 2 },
                    { 147, "Đen", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6570), 76, 100, "L", 4 },
                    { 141, "Đen", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6550), 70, 100, "L", 4 },
                    { 152, "Trắng", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6580), 81, 100, "L", 5 },
                    { 163, "Đen", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6610), 88, 100, "L", 2 },
                    { 157, "Xanh jean", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6600), 84, 100, "L", 6 },
                    { 164, "Xám", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6620), 89, 100, "L", 4 },
                    { 140, "Đen", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6550), 69, 100, "L", 3 },
                    { 165, "Xám", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6620), 90, 100, "L", 1 },
                    { 166, "Đen", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6620), 91, 100, "L", 1 },
                    { 167, "Đen", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6620), 92, 100, "L", 0 },
                    { 168, "Xám", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6630), 93, 100, "L", 0 },
                    { 136, "Vàng kem", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6540), 65, 100, "L", 0 },
                    { 95, "Caro xám", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6430), 42, 100, "M", 4 },
                    { 134, "Xám", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6530), 65, 100, "L", 0 },
                    { 35, "Đen", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6150), 8, 100, "M", 0 },
                    { 36, "Đen", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6160), 8, 100, "L", 0 },
                    { 37, "Xanh nhạt", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6160), 8, 100, "M", 0 }
                });

            migrationBuilder.InsertData(
                table: "Warehouse",
                columns: new[] { "ID", "Color", "LastUpdate", "ProductID", "Quantity", "Size", "Sold" },
                values: new object[,]
                {
                    { 38, "Xanh nhạt", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6160), 8, 100, "L", 0 },
                    { 39, "Xanh đen", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6160), 9, 100, "M", 0 },
                    { 40, "Xanh đen", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6170), 9, 100, "L", 0 },
                    { 41, "Trắng", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6170), 9, 100, "M", 5 },
                    { 42, "Trắng", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6180), 9, 100, "L", 0 },
                    { 43, "Đen", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6180), 10, 100, "L", 5 },
                    { 44, "Xanh dương", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6180), 11, 100, "L", 1 },
                    { 45, "Đen", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6180), 12, 100, "L", 2 },
                    { 46, "Đỏ", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6190), 13, 100, "L", 5 },
                    { 47, "Xanh đen", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6190), 14, 100, "L", 6 },
                    { 48, "Đen", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6190), 15, 100, "L", 8 },
                    { 34, "Trắng", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6150), 8, 100, "L", 0 },
                    { 49, "Xám", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6190), 16, 100, "L", 5 },
                    { 51, "Xanh đen", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6200), 18, 100, "L", 6 },
                    { 52, "Trắng vàng", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6200), 19, 100, "L", 9 },
                    { 53, "Trắng", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6200), 20, 100, "M", 5 },
                    { 54, "Trắng", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6210), 20, 100, "L", 3 },
                    { 55, "Trắng", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6210), 20, 100, "XL", 0 },
                    { 56, "Vàng", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6210), 21, 100, "M", 2 },
                    { 57, "Vàng", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6210), 21, 100, "L", 0 },
                    { 58, "Nâu nhạt", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6220), 21, 100, "M", 0 },
                    { 59, "Nâu nhạt", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6220), 21, 100, "L", 4 },
                    { 60, "Xám", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6230), 22, 100, "M", 4 },
                    { 61, "Xám", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6230), 22, 100, "L", 0 },
                    { 62, "Đỏ", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6230), 22, 100, "M", 1 },
                    { 63, "Đỏ", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6230), 22, 100, "L", 3 },
                    { 64, "Vàng", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6240), 22, 100, "M", 0 },
                    { 50, "Xám", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6200), 17, 100, "L", 6 },
                    { 65, "Vàng", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6240), 22, 100, "L", 0 },
                    { 33, "Trắng", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6150), 8, 100, "M", 3 },
                    { 31, "Xanh mint", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6140), 7, 100, "M", 0 },
                    { 1, "Xanh dương", new DateTime(2021, 12, 21, 11, 31, 31, 615, DateTimeKind.Local).AddTicks(9340), 1, 100, "M", 2 },
                    { 2, "Xanh dương", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6010), 1, 100, "L", 3 },
                    { 3, "Xanh dương", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6060), 1, 100, "XL", 0 },
                    { 4, "Trắng", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6060), 1, 100, "M", 0 },
                    { 5, "Trắng", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6070), 1, 100, "L", 1 },
                    { 6, "Trắng", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6070), 1, 100, "XL", 0 },
                    { 7, "Xanh lá", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6070), 2, 100, "M", 1 },
                    { 8, "Xanh lá", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6080), 2, 100, "L", 4 },
                    { 9, "Đỏ", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6080), 2, 100, "M", 0 },
                    { 10, "Đỏ", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6090), 2, 100, "L", 0 },
                    { 11, "Trắng", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6090), 3, 100, "M", 1 },
                    { 12, "Trắng", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6090), 3, 100, "L", 1 },
                    { 13, "Đen", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6090), 3, 100, "M", 0 },
                    { 14, "Đen", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6100), 3, 100, "L", 0 },
                    { 32, "Xanh mint", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6150), 7, 100, "L", 0 },
                    { 15, "Vàng cam", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6100), 4, 100, "M", 1 },
                    { 17, "Xanh dương", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6100), 4, 100, "M", 0 },
                    { 18, "Xanh dương", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6110), 4, 100, "L", 0 },
                    { 19, "Đỏ", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6110), 5, 100, "M", 0 },
                    { 20, "Đỏ", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6110), 5, 100, "L", 0 },
                    { 21, "Vàng", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6120), 5, 100, "M", 1 },
                    { 22, "Vàng", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6120), 5, 100, "L", 0 },
                    { 23, "Đen", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6120), 6, 100, "M", 0 },
                    { 24, "Đen", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6120), 6, 100, "L", 0 },
                    { 25, "Đỏ", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6130), 6, 100, "M", 0 },
                    { 26, "Đỏ", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6130), 6, 100, "L", 2 },
                    { 27, "Vàng", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6130), 6, 100, "M", 0 },
                    { 28, "Vàng", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6140), 6, 100, "L", 0 },
                    { 29, "Xanh lá", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6140), 7, 100, "M", 1 },
                    { 30, "Xanh lá", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6140), 7, 100, "L", 0 },
                    { 16, "Vàng cam", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6100), 4, 100, "L", 0 },
                    { 135, "Vàng kem", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6540), 65, 100, "M", 1 },
                    { 66, "Trắng", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6240), 23, 100, "M", 3 },
                    { 68, "Đen", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6250), 23, 100, "M", 0 },
                    { 104, "Đen", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6450), 47, 100, "L", 1 },
                    { 105, "Đen", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6450), 48, 100, "L", 6 },
                    { 106, "Xanh biển", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6460), 49, 100, "L", 10 },
                    { 107, "Xanh biển", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6460), 50, 100, "M", 3 },
                    { 108, "Xanh biển", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6460), 50, 100, "L", 5 },
                    { 109, "Xanh biển", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6460), 50, 100, "XL", 0 },
                    { 110, "Caro cam", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6470), 51, 100, "M", 3 },
                    { 111, "Caro cam", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6470), 51, 100, "L", 0 },
                    { 112, "Caro xanh", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6470), 51, 100, "M", 0 },
                    { 113, "Caro xanh", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6480), 51, 100, "L", 0 },
                    { 114, "Trắng", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6480), 52, 100, "M", 3 },
                    { 115, "Trắng", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6480), 52, 100, "L", 0 },
                    { 116, "Trắng", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6480), 52, 100, "XL", 0 },
                    { 117, "Đen", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6490), 53, 100, "L", 1 },
                    { 103, "Đen", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6450), 47, 100, "M", 1 },
                    { 118, "Xanh biển", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6490), 54, 100, "L", 4 },
                    { 120, "Xanh biển", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6490), 56, 100, "L", 4 },
                    { 121, "Trắng", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6500), 57, 100, "L", 3 },
                    { 122, "Xanh dương", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6500), 58, 100, "L", 1 },
                    { 123, "Xanh biển", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6500), 59, 100, "L", 0 },
                    { 124, "Nâu nhạt", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6500), 60, 100, "L", 0 },
                    { 125, "Trắng", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6510), 61, 100, "L", 0 },
                    { 126, "Xanh biển", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6510), 62, 100, "L", 1 },
                    { 127, "Đỏ", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6510), 63, 100, "M", 4 },
                    { 128, "Đỏ", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6520), 63, 100, "L", 0 },
                    { 129, "Đen", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6520), 63, 100, "M", 5 },
                    { 130, "Đen", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6520), 63, 100, "L", 1 },
                    { 131, "Đỏ", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6530), 64, 100, "M", 6 },
                    { 132, "Đỏ", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6530), 64, 100, "L", 0 },
                    { 133, "Xám", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6530), 65, 100, "M", 4 },
                    { 119, "Hoạ tiết 1", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6490), 55, 100, "L", 6 },
                    { 67, "Trắng", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6240), 23, 100, "L", 0 },
                    { 102, "Trắng", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6450), 47, 100, "L", 1 },
                    { 100, "Đen", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6440), 46, 100, "L", 3 },
                    { 69, "Đen", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6250), 23, 100, "L", 0 },
                    { 70, "Xanh rêu", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6250), 24, 100, "M", 1 },
                    { 71, "Xanh rêu", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6250), 24, 100, "L", 0 },
                    { 72, "Trắng", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6260), 25, 100, "M", 4 },
                    { 73, "Trắng", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6260), 25, 100, "L", 0 },
                    { 74, "Đen", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6260), 26, 100, "L", 7 },
                    { 75, "Trắng", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6260), 27, 100, "L", 6 },
                    { 76, "Đen", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6270), 28, 100, "L", 3 },
                    { 77, "Trắng", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6270), 29, 100, "L", 1 },
                    { 78, "Đen", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6280), 30, 100, "L", 1 },
                    { 79, "Trắng", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6280), 31, 100, "L", 0 },
                    { 80, "Trắng", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6280), 32, 100, "L", 6 },
                    { 81, "Đen", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6280), 33, 100, "L", 9 },
                    { 82, "Xám", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6290), 34, 100, "L", 6 },
                    { 101, "Trắng", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6440), 47, 100, "M", 0 },
                    { 83, "Xanh đen", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6290), 35, 100, "L", 10 },
                    { 85, "Xanh", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6290), 37, 100, "L", 3 },
                    { 86, "Đen", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6300), 38, 100, "L", 14 },
                    { 87, "Trắng", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6300), 39, 100, "M", 7 },
                    { 88, "Trắng", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6300), 39, 100, "L", 3 },
                    { 89, "Trắng", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6300), 40, 100, "M", 3 },
                    { 90, "Trắng", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6300), 40, 100, "L", 4 },
                    { 91, "Caro xanh", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6410), 41, 100, "M", 2 },
                    { 92, "Caro xanh", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6420), 41, 100, "L", 3 },
                    { 93, "Caro đỏ", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6420), 41, 100, "M", 4 },
                    { 94, "Caro đỏ", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6420), 41, 100, "L", 0 },
                    { 96, "Caro xám", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6430), 42, 100, "L", 0 },
                    { 97, "Caro đỏ", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6430), 43, 100, "L", 5 },
                    { 98, "Caro đỏ", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6430), 44, 100, "L", 1 },
                    { 99, "Trắng", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6440), 45, 100, "L", 4 },
                    { 84, "Trắng", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6290), 36, 100, "L", 5 },
                    { 177, "Đen", new DateTime(2021, 12, 21, 11, 31, 31, 637, DateTimeKind.Local).AddTicks(6650), 102, 100, "L", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Image_Product_ProductId",
                table: "Image");

            migrationBuilder.DropForeignKey(
                name: "FK_Rating_Product_ProductID",
                table: "Rating");

            migrationBuilder.DropForeignKey(
                name: "FK_Rating_Receipt_ReceiptID",
                table: "Rating");

            migrationBuilder.DropForeignKey(
                name: "FK_Warehouse_Product_ProductID",
                table: "Warehouse");

            migrationBuilder.DeleteData(
                table: "Admin",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Admin",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Admin",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CartDetails",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CartDetails",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CartDetails",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CartDetails",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CartDetails",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CartDetails",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CartDetails",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CartDetails",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CartDetails",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CartDetails",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ID",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Promotion",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Promotion",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Promotion",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Promotion",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Promotion",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Promotion",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Promotion",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Promotion",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Promotion",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Promotion",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Promotion",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Promotion",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Promotion",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Promotion",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Promotion",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Promotion",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Promotion",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Promotion",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Promotion",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Promotion",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "ID",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Tag",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tag",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tag",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tag",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tag",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tag",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tag",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tag",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tag",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tag",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tag",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Tag",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Tag",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Tag",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Tag",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Tag",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "ID",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: 102);

            migrationBuilder.RenameColumn(
                name: "ProductID",
                table: "Warehouse",
                newName: "productID");

            migrationBuilder.RenameIndex(
                name: "IX_Warehouse_ProductID",
                table: "Warehouse",
                newName: "IX_Warehouse_productID");

            migrationBuilder.RenameColumn(
                name: "ReceiptID",
                table: "Rating",
                newName: "receiptID");

            migrationBuilder.RenameColumn(
                name: "ProductID",
                table: "Rating",
                newName: "productID");

            migrationBuilder.RenameIndex(
                name: "IX_Rating_ReceiptID",
                table: "Rating",
                newName: "IX_Rating_receiptID");

            migrationBuilder.RenameIndex(
                name: "IX_Rating_ProductID",
                table: "Rating",
                newName: "IX_Rating_productID");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Image",
                newName: "productID");

            migrationBuilder.RenameIndex(
                name: "IX_Image_ProductId",
                table: "Image",
                newName: "IX_Image_productID");

            migrationBuilder.AlterColumn<int>(
                name: "receiptID",
                table: "Rating",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "productID",
                table: "Rating",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Image_Product_productID",
                table: "Image",
                column: "productID",
                principalTable: "Product",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rating_Product_productID",
                table: "Rating",
                column: "productID",
                principalTable: "Product",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rating_Receipt_receiptID",
                table: "Rating",
                column: "receiptID",
                principalTable: "Receipt",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Warehouse_Product_productID",
                table: "Warehouse",
                column: "productID",
                principalTable: "Product",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
