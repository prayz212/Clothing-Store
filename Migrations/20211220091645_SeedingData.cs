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
                name: "productID",
                table: "Image",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Image_productID",
                table: "Image",
                newName: "IX_Image_ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Image_Product_ProductId",
                table: "Image",
                column: "ProductId",
                principalTable: "Product",
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
                    { 68, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Dài QD006", 230000, "Quần dài", true },
                    { 69, "Lắng nghe khách hàng của mình và hiểu được mỗi chàng trai đều cần có trong tủ đồ mình 1 chiếc quần đặc biệt thoải mái trong mọi vận động. Và Coolmate đặc biệt cho ra mắt sản phẩm Quần phiên bản mới với chất liệu vải 100% Polyester PTT đặc biệt CO GIÃN TUYỆT VỜI đem đến sự thoải mái tối đa.", false, "Quần Dài QD007", 230000, "Quần dài", true },
                    { 70, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Dài QD008", 199000, "Quần dài", true },
                    { 71, "Lắng nghe khách hàng của mình và hiểu được mỗi chàng trai đều cần có trong tủ đồ mình 1 chiếc quần đặc biệt thoải mái trong mọi vận động. Và Coolmate đặc biệt cho ra mắt sản phẩm Quần phiên bản mới với chất liệu vải 100% Polyester PTT đặc biệt CO GIÃN TUYỆT VỜI đem đến sự thoải mái tối đa.", false, "Quần Dài QD009", 199000, "Quần dài", true },
                    { 75, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Dài QD013", 199000, "Quần dài", true },
                    { 73, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Dài QD011", 199000, "Quần dài", true },
                    { 74, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Dài QD012", 199000, "Quần dài", true },
                    { 76, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Dài QD014", 199000, "Quần dài", true },
                    { 67, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Dài QD005", 230000, "Quần dài", true },
                    { 72, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Dài QD010", 199000, "Quần dài", true },
                    { 66, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Dài QD004", 199000, "Quần dài", true },
                    { 59, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu modal (gỗ sồi), sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo sơ mi Modal này có gì đặc biệt nhé!", false, "Áo Sơ Mi N010", 199000, "Áo sơ mi tay ngắn", true },
                    { 64, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Dài QD002", 230000, "Quần dài", true },
                    { 63, "Lắng nghe khách hàng của mình và hiểu được mỗi chàng trai đều cần có trong tủ đồ mình 1 chiếc quần đặc biệt thoải mái trong mọi vận động. Và Coolmate đặc biệt cho ra mắt sản phẩm Quần phiên bản mới với chất liệu vải 100% Polyester PTT đặc biệt CO GIÃN TUYỆT VỜI đem đến sự thoải mái tối đa.", false, "Quần Dài QD001", 230000, "Quần dài", true },
                    { 62, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu modal (gỗ sồi), sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo sơ mi Modal này có gì đặc biệt nhé!", false, "Áo Sơ Mi N013", 230000, "Áo sơ mi tay ngắn", true },
                    { 61, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu modal (gỗ sồi), sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo sơ mi Modal này có gì đặc biệt nhé!", false, "Áo Sơ Mi N012", 230000, "Áo sơ mi tay ngắn", true },
                    { 60, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu bamboo (vải tre) Ex-Soft này, sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo bamboo này có gì đặc biệt nhé!", false, "Áo Sơ Mi N011", 199000, "Áo sơ mi tay ngắn", true },
                    { 77, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Dài QD015", 230000, "Quần dài", true },
                    { 58, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu modal (gỗ sồi), sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo sơ mi Modal này có gì đặc biệt nhé!", false, "Áo Sơ Mi N009", 199000, "Áo sơ mi tay ngắn", true },
                    { 57, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu modal (gỗ sồi), sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo sơ mi Modal này có gì đặc biệt nhé!", false, "Áo Sơ Mi N008", 230000, "Áo sơ mi tay ngắn", true },
                    { 56, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu modal (gỗ sồi), sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo sơ mi Modal này có gì đặc biệt nhé!", false, "Áo Sơ Mi N007", 230000, "Áo sơ mi tay ngắn", true },
                    { 55, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu modal (gỗ sồi), sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo sơ mi Modal này có gì đặc biệt nhé!", false, "Áo Sơ Mi N006", 230000, "Áo sơ mi tay ngắn", true },
                    { 65, "Lắng nghe khách hàng của mình và hiểu được mỗi chàng trai đều cần có trong tủ đồ mình 1 chiếc quần đặc biệt thoải mái trong mọi vận động. Và Coolmate đặc biệt cho ra mắt sản phẩm Quần phiên bản mới với chất liệu vải 100% Polyester PTT đặc biệt CO GIÃN TUYỆT VỜI đem đến sự thoải mái tối đa.", false, "Quần Dài QD003", 199000, "Quần dài", true },
                    { 78, "Lắng nghe khách hàng của mình và hiểu được mỗi chàng trai đều cần có trong tủ đồ mình 1 chiếc quần đặc biệt thoải mái trong mọi vận động. Và Coolmate đặc biệt cho ra mắt sản phẩm Quần phiên bản mới với chất liệu vải 100% Polyester PTT đặc biệt CO GIÃN TUYỆT VỜI đem đến sự thoải mái tối đa.", false, "Quần Dài QD016", 199000, "Quần dài", true },
                    { 85, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Ngắn QN003", 199000, "Quần ngắn", true },
                    { 80, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Dài QD018", 199000, "Quần dài", true },
                    { 102, "Lắng nghe khách hàng của mình và hiểu được mỗi chàng trai đều cần có trong tủ đồ mình 1 chiếc quần đặc biệt thoải mái trong mọi vận động. Và Coolmate đặc biệt cho ra mắt sản phẩm Quần phiên bản mới với chất liệu vải 100% Polyester PTT đặc biệt CO GIÃN TUYỆT VỜI đem đến sự thoải mái tối đa.", false, "Quần Ngắn QN020", 199000, "Quần ngắn", true },
                    { 101, "Lắng nghe khách hàng của mình và hiểu được mỗi chàng trai đều cần có trong tủ đồ mình 1 chiếc quần đặc biệt thoải mái trong mọi vận động. Và Coolmate đặc biệt cho ra mắt sản phẩm Quần phiên bản mới với chất liệu vải 100% Polyester PTT đặc biệt CO GIÃN TUYỆT VỜI đem đến sự thoải mái tối đa.", false, "Quần Ngắn QN019", 230000, "Quần ngắn", true },
                    { 100, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Ngắn QN018", 199000, "Quần ngắn", true },
                    { 99, "Lắng nghe khách hàng của mình và hiểu được mỗi chàng trai đều cần có trong tủ đồ mình 1 chiếc quần đặc biệt thoải mái trong mọi vận động. Và Coolmate đặc biệt cho ra mắt sản phẩm Quần phiên bản mới với chất liệu vải 100% Polyester PTT đặc biệt CO GIÃN TUYỆT VỜI đem đến sự thoải mái tối đa.", false, "Quần Ngắn QN017", 230000, "Quần ngắn", true },
                    { 98, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Ngắn QN016", 199000, "Quần ngắn", true },
                    { 97, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Ngắn QN015", 199000, "Quần ngắn", true },
                    { 96, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Ngắn QN014", 199000, "Quần ngắn", true },
                    { 95, "Lắng nghe khách hàng của mình và hiểu được mỗi chàng trai đều cần có trong tủ đồ mình 1 chiếc quần đặc biệt thoải mái trong mọi vận động. Và Coolmate đặc biệt cho ra mắt sản phẩm Quần phiên bản mới với chất liệu vải 100% Polyester PTT đặc biệt CO GIÃN TUYỆT VỜI đem đến sự thoải mái tối đa.", false, "Quần Ngắn QN013", 230000, "Quần ngắn", true },
                    { 94, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Ngắn QN012", 230000, "Quần ngắn", true },
                    { 93, "Lắng nghe khách hàng của mình và hiểu được mỗi chàng trai đều cần có trong tủ đồ mình 1 chiếc quần đặc biệt thoải mái trong mọi vận động. Và Coolmate đặc biệt cho ra mắt sản phẩm Quần phiên bản mới với chất liệu vải 100% Polyester PTT đặc biệt CO GIÃN TUYỆT VỜI đem đến sự thoải mái tối đa.", false, "Quần Ngắn QN011", 230000, "Quần ngắn", true },
                    { 79, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Dài QD017", 230000, "Quần dài", true },
                    { 92, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Ngắn QN010", 199000, "Quần ngắn", true },
                    { 90, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Ngắn QN008", 199000, "Quần ngắn", true },
                    { 89, "Lắng nghe khách hàng của mình và hiểu được mỗi chàng trai đều cần có trong tủ đồ mình 1 chiếc quần đặc biệt thoải mái trong mọi vận động. Và Coolmate đặc biệt cho ra mắt sản phẩm Quần phiên bản mới với chất liệu vải 100% Polyester PTT đặc biệt CO GIÃN TUYỆT VỜI đem đến sự thoải mái tối đa.", false, "Quần Ngắn QN007", 230000, "Quần ngắn", true },
                    { 88, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Ngắn QN006", 230000, "Quần ngắn", true },
                    { 87, "Lắng nghe khách hàng của mình và hiểu được mỗi chàng trai đều cần có trong tủ đồ mình 1 chiếc quần đặc biệt thoải mái trong mọi vận động. Và Coolmate đặc biệt cho ra mắt sản phẩm Quần phiên bản mới với chất liệu vải 100% Polyester PTT đặc biệt CO GIÃN TUYỆT VỜI đem đến sự thoải mái tối đa.", false, "Quần Ngắn QN005", 199000, "Quần ngắn", true },
                    { 86, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Ngắn QN004", 199000, "Quần ngắn", true },
                    { 54, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu bamboo (vải tre) Ex-Soft này, sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo bamboo này có gì đặc biệt nhé!", false, "Áo Sơ Mi N005", 199000, "Áo sơ mi tay ngắn", true },
                    { 84, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Ngắn QN002", 199000, "Quần ngắn", true },
                    { 83, "Lắng nghe khách hàng của mình và hiểu được mỗi chàng trai đều cần có trong tủ đồ mình 1 chiếc quần đặc biệt thoải mái trong mọi vận động. Và Coolmate đặc biệt cho ra mắt sản phẩm Quần phiên bản mới với chất liệu vải 100% Polyester PTT đặc biệt CO GIÃN TUYỆT VỜI đem đến sự thoải mái tối đa.", false, "Quần Ngắn QN001", 199000, "Quần ngắn", true },
                    { 82, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Dài QD020", 230000, "Quần dài", true },
                    { 81, "Lắng nghe khách hàng của mình và hiểu được mỗi chàng trai đều cần có trong tủ đồ mình 1 chiếc quần đặc biệt thoải mái trong mọi vận động. Và Coolmate đặc biệt cho ra mắt sản phẩm Quần phiên bản mới với chất liệu vải 100% Polyester PTT đặc biệt CO GIÃN TUYỆT VỜI đem đến sự thoải mái tối đa.", false, "Quần Dài QD019", 199000, "Quần dài", true },
                    { 91, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Ngắn QN009", 199000, "Quần ngắn", true },
                    { 53, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu bamboo (vải tre) Ex-Soft này, sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo bamboo này có gì đặc biệt nhé!", false, "Áo Sơ Mi N004", 199000, "Áo sơ mi tay ngắn", true },
                    { 52, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu modal (gỗ sồi), sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo sơ mi Modal này có gì đặc biệt nhé!", false, "Áo Sơ Mi N003", 230000, "Áo sơ mi tay ngắn", true },
                    { 18, "Rất nhiều thời gian và công sức để nghiên cứu và phát triển một sản phẩm, thay vì những vải lót bông bình thường dễ bị xù hoặc rụng bông nhỏ trong quá trình giặt và sử dụng, Coolmate lựa chọn chất liệu là 90% Cotton giúp chiếc áo của bạn vẫn thoát mồ hôi mà không hề gây bí, khó chịu; kết hợp với 10% Polyester giúp áo không nhăn và luôn bền dù có giặt, sấy bằng máy.", false, "Áo Thun D018", 199000, "Áo thun tay dài", true },
                    { 22, "", false, "Áo Thun N003", 199000, "Áo thun tay ngắn ", true },
                    { 21, "", false, "Áo Thun N002", 199000, "Áo thun tay ngắn ", true },
                    { 20, "", false, "Áo Thun N001", 230000, "Áo thun tay ngắn ", true },
                    { 19, "Bạn có đang tìm kiếm cho mình một một chiếc áo dài tay ấm áp. Coolmate hiểu được điều đó và đã nghiên cứu để gửi đến bạn một chiếc áo Sweatshirt với thiết kế vừa vặn, vô cùng thoải mái với chất liệu đặc biệt mềm mại. Và đó chính là áo nam Casual Sweatshirt - hoàn hảo cho những ngày thoải mái ở nhà, nhưng đủ tự tin để dạo phố cùng bạn bè.", false, "Áo Thun D019", 199000, "Áo thun tay dài", true },
                    { 51, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu modal (gỗ sồi), sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo sơ mi Modal này có gì đặc biệt nhé!", false, "Áo Sơ Mi N002", 199000, "Áo sơ mi tay ngắn", true },
                    { 17, "Bạn có đang tìm kiếm cho mình một một chiếc áo dài tay ấm áp. Coolmate hiểu được điều đó và đã nghiên cứu để gửi đến bạn một chiếc áo Sweatshirt với thiết kế vừa vặn, vô cùng thoải mái với chất liệu đặc biệt mềm mại. Và đó chính là áo nam Casual Sweatshirt - hoàn hảo cho những ngày thoải mái ở nhà, nhưng đủ tự tin để dạo phố cùng bạn bè.", false, "Áo Thun D017", 230000, "Áo thun tay dài", true },
                    { 16, "Rất nhiều thời gian và công sức để nghiên cứu và phát triển một sản phẩm, thay vì những vải lót bông bình thường dễ bị xù hoặc rụng bông nhỏ trong quá trình giặt và sử dụng, Coolmate lựa chọn chất liệu là 90% Cotton giúp chiếc áo của bạn vẫn thoát mồ hôi mà không hề gây bí, khó chịu; kết hợp với 10% Polyester giúp áo không nhăn và luôn bền dù có giặt, sấy bằng máy.", false, "Áo Thun D016", 199000, "Áo thun tay dài", true },
                    { 15, "Bạn có đang tìm kiếm cho mình một một chiếc áo dài tay ấm áp. Coolmate hiểu được điều đó và đã nghiên cứu để gửi đến bạn một chiếc áo Sweatshirt với thiết kế vừa vặn, vô cùng thoải mái với chất liệu đặc biệt mềm mại. Và đó chính là áo nam Casual Sweatshirt - hoàn hảo cho những ngày thoải mái ở nhà, nhưng đủ tự tin để dạo phố cùng bạn bè.", false, "Áo Thun D015", 230000, "Áo thun tay dài", true },
                    { 14, "Bạn có đang tìm kiếm cho mình một một chiếc áo dài tay ấm áp. Coolmate hiểu được điều đó và đã nghiên cứu để gửi đến bạn một chiếc áo Sweatshirt với thiết kế vừa vặn, vô cùng thoải mái với chất liệu đặc biệt mềm mại. Và đó chính là áo nam Casual Sweatshirt - hoàn hảo cho những ngày thoải mái ở nhà, nhưng đủ tự tin để dạo phố cùng bạn bè.", false, "Áo Thun D014", 199000, "Áo thun tay dài", true },
                    { 13, "Bạn có đang tìm kiếm cho mình một một chiếc áo dài tay ấm áp. Coolmate hiểu được điều đó và đã nghiên cứu để gửi đến bạn một chiếc áo Sweatshirt với thiết kế vừa vặn, vô cùng thoải mái với chất liệu đặc biệt mềm mại. Và đó chính là áo nam Casual Sweatshirt - hoàn hảo cho những ngày thoải mái ở nhà, nhưng đủ tự tin để dạo phố cùng bạn bè.", false, "Áo Thun D013", 230000, "Áo thun tay dài", true },
                    { 24, "", false, "Áo Thun N005", 230000, "Áo thun tay ngắn ", true },
                    { 12, "Rất nhiều thời gian và công sức để nghiên cứu và phát triển một sản phẩm, thay vì những vải lót bông bình thường dễ bị xù hoặc rụng bông nhỏ trong quá trình giặt và sử dụng, Coolmate lựa chọn chất liệu là 90% Cotton giúp chiếc áo của bạn vẫn thoát mồ hôi mà không hề gây bí, khó chịu; kết hợp với 10% Polyester giúp áo không nhăn và luôn bền dù có giặt, sấy bằng máy.", false, "Áo Thun D012", 199000, "Áo thun tay dài", true },
                    { 10, "Rất nhiều thời gian và công sức để nghiên cứu và phát triển một sản phẩm, thay vì những vải lót bông bình thường dễ bị xù hoặc rụng bông nhỏ trong quá trình giặt và sử dụng, Coolmate lựa chọn chất liệu là 90% Cotton giúp chiếc áo của bạn vẫn thoát mồ hôi mà không hề gây bí, khó chịu; kết hợp với 10% Polyester giúp áo không nhăn và luôn bền dù có giặt, sấy bằng máy.", false, "Áo Thun D010", 199000, "Áo thun tay dài", true },
                    { 9, "Rất nhiều thời gian và công sức để nghiên cứu và phát triển một sản phẩm, thay vì những vải lót bông bình thường dễ bị xù hoặc rụng bông nhỏ trong quá trình giặt và sử dụng, Coolmate lựa chọn chất liệu là 90% Cotton giúp chiếc áo của bạn vẫn thoát mồ hôi mà không hề gây bí, khó chịu; kết hợp với 10% Polyester giúp áo không nhăn và luôn bền dù có giặt, sấy bằng máy.", false, "Áo Thun D009", 230000, "Áo thun tay dài", true },
                    { 8, "Rất nhiều thời gian và công sức để nghiên cứu và phát triển một sản phẩm, thay vì những vải lót bông bình thường dễ bị xù hoặc rụng bông nhỏ trong quá trình giặt và sử dụng, Coolmate lựa chọn chất liệu là 90% Cotton giúp chiếc áo của bạn vẫn thoát mồ hôi mà không hề gây bí, khó chịu; kết hợp với 10% Polyester giúp áo không nhăn và luôn bền dù có giặt, sấy bằng máy.", false, "Áo Thun D008", 230000, "Áo thun tay dài", true },
                    { 7, "Bạn có đang tìm kiếm cho mình một một chiếc áo dài tay ấm áp. Coolmate hiểu được điều đó và đã nghiên cứu để gửi đến bạn một chiếc áo Sweatshirt với thiết kế vừa vặn, vô cùng thoải mái với chất liệu đặc biệt mềm mại. Và đó chính là áo nam Casual Sweatshirt - hoàn hảo cho những ngày thoải mái ở nhà, nhưng đủ tự tin để dạo phố cùng bạn bè.", false, "Áo Thun D007", 230000, "Áo thun tay dài", true },
                    { 6, "Rất nhiều thời gian và công sức để nghiên cứu và phát triển một sản phẩm, thay vì những vải lót bông bình thường dễ bị xù hoặc rụng bông nhỏ trong quá trình giặt và sử dụng, Coolmate lựa chọn chất liệu là 90% Cotton giúp chiếc áo của bạn vẫn thoát mồ hôi mà không hề gây bí, khó chịu; kết hợp với 10% Polyester giúp áo không nhăn và luôn bền dù có giặt, sấy bằng máy.", false, "Áo Thun D006", 199000, "Áo thun tay dài", true },
                    { 5, "Bạn có đang tìm kiếm cho mình một một chiếc áo dài tay ấm áp. Coolmate hiểu được điều đó và đã nghiên cứu để gửi đến bạn một chiếc áo Sweatshirt với thiết kế vừa vặn, vô cùng thoải mái với chất liệu đặc biệt mềm mại. Và đó chính là áo nam Casual Sweatshirt - hoàn hảo cho những ngày thoải mái ở nhà, nhưng đủ tự tin để dạo phố cùng bạn bè.", false, "Áo Thun D005", 230000, "Áo thun tay dài", true },
                    { 4, "Rất nhiều thời gian và công sức để nghiên cứu và phát triển một sản phẩm, thay vì những vải lót bông bình thường dễ bị xù hoặc rụng bông nhỏ trong quá trình giặt và sử dụng, Coolmate lựa chọn chất liệu là 90% Cotton giúp chiếc áo của bạn vẫn thoát mồ hôi mà không hề gây bí, khó chịu; kết hợp với 10% Polyester giúp áo không nhăn và luôn bền dù có giặt, sấy bằng máy.", false, "Áo Thun D004", 230000, "Áo thun tay dài", true },
                    { 3, "Rất nhiều thời gian và công sức để nghiên cứu và phát triển một sản phẩm, thay vì những vải lót bông bình thường dễ bị xù hoặc rụng bông nhỏ trong quá trình giặt và sử dụng, Coolmate lựa chọn chất liệu là 90% Cotton giúp chiếc áo của bạn vẫn thoát mồ hôi mà không hề gây bí, khó chịu; kết hợp với 10% Polyester giúp áo không nhăn và luôn bền dù có giặt, sấy bằng máy.", false, "Áo Thun D003", 230000, "Áo thun tay dài", true },
                    { 2, "Bạn có đang tìm kiếm cho mình một một chiếc áo dài tay ấm áp. Coolmate hiểu được điều đó và đã nghiên cứu để gửi đến bạn một chiếc áo Sweatshirt với thiết kế vừa vặn, vô cùng thoải mái với chất liệu đặc biệt mềm mại. Và đó chính là áo nam Casual Sweatshirt - hoàn hảo cho những ngày thoải mái ở nhà, nhưng đủ tự tin để dạo phố cùng bạn bè.", false, "Áo Thun D002", 230000, "Áo thun tay dài", true },
                    { 1, "Bạn có đang tìm kiếm cho mình một một chiếc áo dài tay ấm áp. Coolmate hiểu được điều đó và đã nghiên cứu để gửi đến bạn một chiếc áo Sweatshirt với thiết kế vừa vặn, vô cùng thoải mái với chất liệu đặc biệt mềm mại. Và đó chính là áo nam Casual Sweatshirt - hoàn hảo cho những ngày thoải mái ở nhà, nhưng đủ tự tin để dạo phố cùng bạn bè.", false, "Áo Thun D001", 199000, "Áo thun tay dài", true },
                    { 11, "Rất nhiều thời gian và công sức để nghiên cứu và phát triển một sản phẩm, thay vì những vải lót bông bình thường dễ bị xù hoặc rụng bông nhỏ trong quá trình giặt và sử dụng, Coolmate lựa chọn chất liệu là 90% Cotton giúp chiếc áo của bạn vẫn thoát mồ hôi mà không hề gây bí, khó chịu; kết hợp với 10% Polyester giúp áo không nhăn và luôn bền dù có giặt, sấy bằng máy.", false, "Áo Thun D011", 230000, "Áo thun tay dài", true },
                    { 25, "", false, "Áo Thun N006", 199000, "Áo thun tay ngắn ", true },
                    { 23, "", false, "Áo Thun N004", 230000, "Áo thun tay ngắn ", true },
                    { 27, "", false, "Áo Thun N008", 199000, "Áo thun tay ngắn ", true },
                    { 50, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu modal (gỗ sồi), sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo sơ mi Modal này có gì đặc biệt nhé!", false, "Áo Sơ Mi N001", 230000, "Áo sơ mi tay ngắn", true },
                    { 49, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu bamboo (vải tre) Ex-Soft này, sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo bamboo này có gì đặc biệt nhé!", false, "Áo Sơ Mi D011", 230000, "Áo sơ mi tay dài", true },
                    { 48, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu modal (gỗ sồi), sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo sơ mi Modal này có gì đặc biệt nhé!", false, "Áo Sơ Mi D010", 199000, "Áo sơ mi tay dài", true },
                    { 47, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu modal (gỗ sồi), sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo sơ mi Modal này có gì đặc biệt nhé!", false, "Áo Sơ Mi D009", 199000, "Áo sơ mi tay dài", true },
                    { 46, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu bamboo (vải tre) Ex-Soft này, sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo bamboo này có gì đặc biệt nhé!", false, "Áo Sơ Mi D008", 199000, "Áo sơ mi tay dài", true },
                    { 45, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu modal (gỗ sồi), sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo sơ mi Modal này có gì đặc biệt nhé!", false, "Áo Sơ Mi D007", 199000, "Áo sơ mi tay dài", true },
                    { 44, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu bamboo (vải tre) Ex-Soft này, sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo bamboo này có gì đặc biệt nhé!", false, "Áo Sơ Mi D006", 230000, "Áo sơ mi tay dài", true },
                    { 43, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu bamboo (vải tre) Ex-Soft này, sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo bamboo này có gì đặc biệt nhé!", false, "Áo Sơ Mi D005", 199000, "Áo sơ mi tay dài", true },
                    { 42, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu bamboo (vải tre) Ex-Soft này, sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo bamboo này có gì đặc biệt nhé!", false, "Áo Sơ Mi D004", 230000, "Áo sơ mi tay dài", true },
                    { 26, "", false, "Áo Thun N007", 199000, "Áo thun tay ngắn ", true },
                    { 40, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu bamboo (vải tre) Ex-Soft này, sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo bamboo này có gì đặc biệt nhé!", false, "Áo Sơ Mi D002", 199000, "Áo sơ mi tay dài", true },
                    { 39, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu modal (gỗ sồi), sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo sơ mi Modal này có gì đặc biệt nhé!", false, "Áo Sơ Mi D001", 199000, "Áo sơ mi tay dài", true },
                    { 41, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu modal (gỗ sồi), sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo sơ mi Modal này có gì đặc biệt nhé!", false, "Áo Sơ Mi D003", 230000, "Áo sơ mi tay dài", true },
                    { 37, "", false, "Áo Thun N018", 230000, "Áo thun tay ngắn ", true },
                    { 28, "", false, "Áo Thun N009", 199000, "Áo thun tay ngắn ", true },
                    { 38, "", false, "Áo Thun N019", 230000, "Áo thun tay ngắn ", true },
                    { 30, "", false, "Áo Thun N011", 230000, "Áo thun tay ngắn ", true },
                    { 31, "", false, "Áo Thun N012", 199000, "Áo thun tay ngắn ", true },
                    { 29, "", false, "Áo Thun N010", 230000, "Áo thun tay ngắn ", true },
                    { 33, "", false, "Áo Thun N014", 199000, "Áo thun tay ngắn ", true },
                    { 34, "", false, "Áo Thun N015", 199000, "Áo thun tay ngắn ", true },
                    { 35, "", false, "Áo Thun N016", 230000, "Áo thun tay ngắn ", true },
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
                    { 2, "Xanh mint", false, true, 1, "L", 1, 7 },
                    { 6, "Vàng", false, true, 1, "L", 2, 5 },
                    { 10, "Xanh jean", false, true, 1, "M", 2, 85 },
                    { 7, "Xám", false, false, 4, "L", 2, 74 },
                    { 8, "Đen", false, true, 2, "L", 2, 88 },
                    { 5, "Trắng", false, true, 1, "L", 1, 52 },
                    { 9, "Đen", false, true, 2, "M", 2, 83 },
                    { 3, "Đen", false, false, 3, "L", 1, 26 },
                    { 4, "Trắng", false, true, 2, "M", 1, 25 },
                    { 1, "Đỏ", false, true, 2, "M", 1, 5 }
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "ID", "AccountID", "Address", "CardNumber", "Fullname", "Phone", "SecretNumber", "ValidDate" },
                values: new object[,]
                {
                    { 11, 11, "12 Nguyễn Huệ P.Bến Nghé Q.11", "271219473238", "Hứa Huy", "0900010203", "2982361", new DateTime(2023, 12, 20, 16, 16, 44, 397, DateTimeKind.Local).AddTicks(8220) },
                    { 2, 2, "12 Nguyễn Huệ P.Bến Nghé Q.2", "274611273238", "Tăng Cẩm Phú", "0909110203", "2916361", new DateTime(2022, 12, 20, 16, 16, 44, 397, DateTimeKind.Local).AddTicks(8130) },
                    { 3, 3, "12 Nguyễn Huệ P.Bến Nghé Q.3", "274621133238", "Nguyễn Trân", "0909020203", "2982360", new DateTime(2023, 12, 20, 16, 16, 44, 397, DateTimeKind.Local).AddTicks(8190) },
                    { 4, 4, "12 Nguyễn Huệ P.Bến Nghé Q.4", "274629411438", "Trần Hồng", "0909010303", "2986331", new DateTime(2023, 12, 20, 16, 16, 44, 397, DateTimeKind.Local).AddTicks(8190) },
                    { 12, 12, "12 Nguyễn Huệ P.Bến Nghé Q.12", "274612273238", "Đặng Khôi", "0990210203", "2186361", new DateTime(2023, 12, 20, 16, 16, 44, 397, DateTimeKind.Local).AddTicks(8220) },
                    { 6, 6, "12 Nguyễn Huệ P.Bến Nghé Q.6", "116629473238", "Hà Quỳnh", "0989010203", "2986661", new DateTime(2022, 12, 20, 16, 16, 44, 397, DateTimeKind.Local).AddTicks(8200) },
                    { 7, 7, "12 Nguyễn Huệ P.Bến Nghé Q.7", "211729473238", "Huy Huy", "0909010203", "2986371", new DateTime(2022, 12, 20, 16, 16, 44, 397, DateTimeKind.Local).AddTicks(8200) },
                    { 5, 5, "12 Nguyễn Huệ P.Bến Nghé Q.5", "115629473238", "Nhi Lý", "0909610203", "2986364", new DateTime(2023, 12, 20, 16, 16, 44, 397, DateTimeKind.Local).AddTicks(8200) },
                    { 1, 1, "12 Nguyễn Huệ P.Bến Nghé Q.1", "271119473238", "Diệc Lữ Chí Vĩ", "0909010003", "2986361", new DateTime(2023, 12, 20, 16, 16, 44, 397, DateTimeKind.Local).AddTicks(6460) },
                    { 10, 10, "12 Nguyễn Huệ P.Bến Nghé Q.10", "212029473238", "Trần Huy", "0908010203", "2196361", new DateTime(2022, 12, 20, 16, 16, 44, 397, DateTimeKind.Local).AddTicks(8220) },
                    { 8, 8, "12 Nguyễn Huệ P.Bến Nghé Q.8", "118629473238", "Thanh Thanh", "0309010203", "2886361", new DateTime(2022, 12, 20, 16, 16, 44, 397, DateTimeKind.Local).AddTicks(8210) },
                    { 9, 9, "12 Nguyễn Huệ P.Bến Nghé Q.9", "271199473238", "Tùng Trần", "0904010203", "2989361", new DateTime(2022, 12, 20, 16, 16, 44, 397, DateTimeKind.Local).AddTicks(8210) }
                });

            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "ID", "IsDelete", "Name", "ProductId", "URL" },
                values: new object[,]
                {
                    { 72, false, "Ảnh minh hoạ D008", 46, "46_1_D008.jpg" },
                    { 73, false, "Ảnh minh hoạ D009", 47, "47_1_D009.jpg" },
                    { 74, false, "Ảnh minh hoạ D010", 48, "48_1_D010.jpg" },
                    { 75, false, "Ảnh minh hoạ D011", 49, "49_1_D011.jpg" },
                    { 76, false, "Ảnh minh hoạ N001", 50, "50_1_N001.jpg" },
                    { 77, false, "Ảnh minh hoạ N001", 50, "50_2_N001.jpg" },
                    { 78, false, "Ảnh minh hoạ N001", 50, "50_3_N001.jpg" },
                    { 92, false, "Ảnh minh hoạ N009", 58, "58_1_N009.jpg" },
                    { 79, false, "Ảnh minh hoạ N001", 50, "50_4_N001.jpg" },
                    { 80, false, "Ảnh minh hoạ N002", 51, "51_1_N002.jpg" },
                    { 81, false, "Ảnh minh hoạ N002", 51, "51_2_N002.jpg" },
                    { 82, false, "Ảnh minh hoạ N002", 51, "51_3_N002.jpg" },
                    { 83, false, "Ảnh minh hoạ N002", 51, "51_4_N002.jpg" },
                    { 91, false, "Ảnh minh hoạ N008", 57, "57_1_N008.jpg" },
                    { 84, false, "Ảnh minh hoạ N003", 52, "52_1_N003.jpg" },
                    { 85, false, "Ảnh minh hoạ N003", 52, "52_2_N003.jpg" },
                    { 86, false, "Ảnh minh hoạ N003", 52, "52_3_N003.jpg" },
                    { 87, false, "Ảnh minh hoạ N004", 53, "53_1_N004.jpg" },
                    { 90, false, "Ảnh minh hoạ N007", 56, "56_1_N007.jpg" },
                    { 89, false, "Ảnh minh hoạ N006", 55, "55_1_N006.jpg" },
                    { 88, false, "Ảnh minh hoạ N005", 54, "54_1_N005.jpg" },
                    { 63, false, "Ảnh minh hoạ D002", 40, "40_3_D002.jpg" },
                    { 70, false, "Ảnh minh hoạ D006", 44, "44_1_D006.jpg" },
                    { 45, false, "Ảnh minh hoạ N006", 25, "25_1_N006.jpg" },
                    { 46, false, "Ảnh minh hoạ N007", 26, "26_1_N007.jpg" },
                    { 47, false, "Ảnh minh hoạ N008", 27, "27_1_N008.jpg" },
                    { 48, false, "Ảnh minh hoạ N009", 28, "28_1_N009.jpg" },
                    { 49, false, "Ảnh minh hoạ N010", 29, "29_1_N010.jpg" },
                    { 50, false, "Ảnh minh hoạ N011", 30, "30_1_N011.jpg" },
                    { 51, false, "Ảnh minh hoạ N012", 31, "31_1_N012.jpg" },
                    { 52, false, "Ảnh minh hoạ N013", 32, "32_1_N013.jpg" },
                    { 53, false, "Ảnh minh hoạ N014", 33, "33_1_N014.jpg" },
                    { 54, false, "Ảnh minh hoạ N015", 34, "34_1_N015.jpg" },
                    { 55, false, "Ảnh minh hoạ N016", 35, "35_1_N016.jpg" },
                    { 56, false, "Ảnh minh hoạ N017", 36, "36_1_N017.jpg" },
                    { 57, false, "Ảnh minh hoạ N018", 37, "37_1_N018.jpg" },
                    { 58, false, "Ảnh minh hoạ N019", 38, "38_1_N019.jpg" },
                    { 59, false, "Ảnh minh hoạ D001", 39, "39_1_D001.jpg" },
                    { 60, false, "Ảnh minh hoạ D001", 39, "39_2_D001.jpg" },
                    { 61, false, "Ảnh minh hoạ D002", 40, "40_1_D002.jpg" },
                    { 62, false, "Ảnh minh hoạ D002", 40, "40_2_D002.jpg" },
                    { 93, false, "Ảnh minh hoạ N010", 59, "59_1_N010.jpg" },
                    { 64, false, "Ảnh minh hoạ D002", 40, "40_4_D002.jpg" },
                    { 65, false, "Ảnh minh hoạ D003", 41, "41_1_D003.jpg" },
                    { 149, false, "Ảnh minh hoạ QN020", 102, "102_1_QN020.jpg" },
                    { 67, false, "Ảnh minh hoạ D004", 42, "42_1_D004.jpg" },
                    { 68, false, "Ảnh minh hoạ D004", 42, "42_2_D004.jpg" },
                    { 69, false, "Ảnh minh hoạ D005", 43, "43_1_D005.jpg" },
                    { 71, false, "Ảnh minh hoạ D007", 45, "45_1_D007.jpg" },
                    { 94, false, "Ảnh minh hoạ N011", 60, "60_1_N011.jpg" },
                    { 104, false, "Ảnh minh hoạ QD003", 65, "65_2_QD003.jpg" },
                    { 96, false, "Ảnh minh hoạ N013", 62, "62_1_N013.jpg" },
                    { 125, false, "Ảnh minh hoạ QN001", 83, "83_4_QN001.jpg" },
                    { 126, false, "Ảnh minh hoạ QN002", 84, "84_1_QN002.jpg" },
                    { 127, false, "Ảnh minh hoạ QN002", 84, "84_2_QN002.jpg" },
                    { 128, false, "Ảnh minh hoạ QN002", 84, "84_3_QN002.jpg" },
                    { 129, false, "Ảnh minh hoạ QN003", 85, "85_1_QN003.jpg" },
                    { 130, false, "Ảnh minh hoạ QN003", 85, "85_2_QN003.jpg" },
                    { 131, false, "Ảnh minh hoạ QN003", 85, "85_3_QN003.jpg" },
                    { 132, false, "Ảnh minh hoạ QN004", 86, "86_1_QN004.jpg" },
                    { 133, false, "Ảnh minh hoạ QN004", 86, "86_2_QN004.jpg" },
                    { 134, false, "Ảnh minh hoạ QN005", 87, "87_1_QN005.jpg" },
                    { 135, false, "Ảnh minh hoạ QN006", 88, "88_1_QN006.jpg" },
                    { 124, false, "Ảnh minh hoạ QN001", 83, "83_3_QN001.jpg" },
                    { 136, false, "Ảnh minh hoạ QN007", 89, "89_1_QN007.jpg" },
                    { 138, false, "Ảnh minh hoạ QN009", 91, "91_1_QN009.jpg" },
                    { 139, false, "Ảnh minh hoạ QN010", 92, "92_1_QN010.jpg" },
                    { 140, false, "Ảnh minh hoạ QN011", 93, "93_1_QN011.jpg" },
                    { 141, false, "Ảnh minh hoạ QN012", 94, "94_1_QN012.jpg" },
                    { 142, false, "Ảnh minh hoạ QN013", 95, "95_1_QN013.jpg" },
                    { 143, false, "Ảnh minh hoạ QN014", 96, "96_1_QN014.jpg" },
                    { 144, false, "Ảnh minh hoạ QN015", 97, "97_1_QN015.jpg" },
                    { 145, false, "Ảnh minh hoạ QN016", 98, "98_1_QN016.jpg" },
                    { 146, false, "Ảnh minh hoạ QN017", 99, "99_1_QN017.jpg" },
                    { 147, false, "Ảnh minh hoạ QN018", 100, "100_1_QN018.jpg" },
                    { 148, false, "Ảnh minh hoạ QN019", 101, "101_1_QN019.jpg" },
                    { 137, false, "Ảnh minh hoạ QN008", 90, "90_1_QN008.jpg" },
                    { 95, false, "Ảnh minh hoạ N012", 61, "61_1_N012.jpg" },
                    { 123, false, "Ảnh minh hoạ QN001", 83, "83_2_QN001.jpg" },
                    { 121, false, "Ảnh minh hoạ QD020", 82, "82_1_QD020.jpg" },
                    { 97, false, "Ảnh minh hoạ QD001", 63, "63_1_QD001.jpg" },
                    { 98, false, "Ảnh minh hoạ QD001", 63, "63_2_QD001.jpg" },
                    { 99, false, "Ảnh minh hoạ QD001", 63, "63_3_QD001.jpg" },
                    { 100, false, "Ảnh minh hoạ QD002", 64, "64_1_QD002.jpg" },
                    { 101, false, "Ảnh minh hoạ QD002", 64, "64_2_QD002.jpg" },
                    { 102, false, "Ảnh minh hoạ QD002", 64, "64_3_QD002.jpg" },
                    { 103, false, "Ảnh minh hoạ QD003", 65, "65_1_QD003.jpg" },
                    { 44, false, "Ảnh minh hoạ N005", 24, "24_1_N005.jpg" },
                    { 105, false, "Ảnh minh hoạ QD004", 66, "66_1_QD004.jpg" },
                    { 106, false, "Ảnh minh hoạ QD005", 67, "67_1_QD005.jpg" },
                    { 107, false, "Ảnh minh hoạ QD006", 68, "68_1_QD006.jpg" },
                    { 122, false, "Ảnh minh hoạ QN001", 83, "83_1_QN001.jpg" },
                    { 108, false, "Ảnh minh hoạ QD007", 69, "69_1_QD007.jpg" },
                    { 110, false, "Ảnh minh hoạ QD009", 71, "71_1_QD009.jpg" },
                    { 111, false, "Ảnh minh hoạ QD010", 72, "72_1_QD010.jpg" },
                    { 112, false, "Ảnh minh hoạ QD011", 73, "73_1_QD011.jpg" },
                    { 113, false, "Ảnh minh hoạ QD012", 74, "74_1_QD012.jpg" },
                    { 114, false, "Ảnh minh hoạ QD013", 75, "75_1_QD013.jpg" },
                    { 115, false, "Ảnh minh hoạ QD014", 76, "76_1_QD014.jpg" },
                    { 116, false, "Ảnh minh hoạ QD015", 77, "77_1_QD015.jpg" },
                    { 117, false, "Ảnh minh hoạ QD016", 78, "78_1_QD016.jpg" },
                    { 118, false, "Ảnh minh hoạ QD017", 79, "79_1_QD017.jpg" },
                    { 119, false, "Ảnh minh hoạ QD018", 80, "80_1_QD018.jpg" },
                    { 120, false, "Ảnh minh hoạ QD019", 81, "81_1_QD019.jpg" },
                    { 109, false, "Ảnh minh hoạ QD008", 70, "70_1_QD008.jpg" },
                    { 43, false, "Ảnh minh hoạ N004", 23, "23_1_N004.jpg" },
                    { 66, false, "Ảnh minh hoạ D003", 41, "41_2_D003.jpg" },
                    { 17, false, "Ảnh minh hoạ D007", 7, "7_1_D007.jpg" },
                    { 37, false, "Ảnh minh hoạ N002", 21, "21_1_N002.jpg" },
                    { 6, false, "Ảnh minh hoạ D002", 2, "2_2_D002.jpg" },
                    { 36, false, "Ảnh minh hoạ N001", 20, "20_3_N001.jpg" },
                    { 16, false, "Ảnh minh hoạ D006", 6, "6_3_D006.jpg" },
                    { 13, false, "Ảnh minh hoạ D005", 5, "5_3_D005.jpg" },
                    { 34, false, "Ảnh minh hoạ N001", 20, "20_1_N001.jpg" },
                    { 15, false, "Ảnh minh hoạ D006", 6, "6_2_D006.jpg" },
                    { 33, false, "Ảnh minh hoạ D019", 19, "19_1_D019.jpg" },
                    { 22, false, "Ảnh minh hoạ D009", 9, "9_1_D009.jpg" },
                    { 32, false, "Ảnh minh hoạ D018", 18, "18_1_D018.jpg" },
                    { 7, false, "Ảnh minh hoạ D003", 3, "3_1_D003.jpg" },
                    { 8, false, "Ảnh minh hoạ D003", 3, "3_2_D003.jpg" },
                    { 38, false, "Ảnh minh hoạ N002", 21, "21_2_N002.jpg" },
                    { 14, false, "Ảnh minh hoạ D006", 6, "6_1_D006.jpg" },
                    { 23, false, "Ảnh minh hoạ D009", 9, "9_2_D009.jpg" },
                    { 30, false, "Ảnh minh hoạ D016", 16, "16_1_D016.jpg" },
                    { 18, false, "Ảnh minh hoạ D007", 7, "7_2_D007.jpg" },
                    { 29, false, "Ảnh minh hoạ D015", 15, "15_1_D015.jpg" },
                    { 9, false, "Ảnh minh hoạ D004", 4, "4_1_D004.jpg" },
                    { 10, false, "Ảnh minh hoạ D004", 4, "4_2_D004.jpg" },
                    { 28, false, "Ảnh minh hoạ D014", 14, "14_1_D014.jpg" },
                    { 27, false, "Ảnh minh hoạ D013", 13, "13_1_D013.jpg" },
                    { 26, false, "Ảnh minh hoạ D012", 12, "12_1_D012.jpg" },
                    { 11, false, "Ảnh minh hoạ D005", 5, "5_1_D005.jpg" },
                    { 24, false, "Ảnh minh hoạ D010", 10, "10_1_D010.jpg" },
                    { 12, false, "Ảnh minh hoạ D005", 5, "5_2_D005.jpg" },
                    { 31, false, "Ảnh minh hoạ D017", 17, "17_1_D017.jpg" },
                    { 5, false, "Ảnh minh hoạ D002", 2, "2_1_D002.jpg" },
                    { 35, false, "Ảnh minh hoạ N001", 20, "20_2_N001.jpg" },
                    { 25, false, "Ảnh minh hoạ D011", 11, "11_1_D011.jpg" },
                    { 42, false, "Ảnh minh hoạ N003", 22, "22_3_N003.jpg" },
                    { 39, false, "Ảnh minh hoạ N003", 22, "22_1_N003.jpg" },
                    { 19, false, "Ảnh minh hoạ D008", 8, "8_1_D008.jpg" },
                    { 20, false, "Ảnh minh hoạ D008", 8, "8_2_D008.jpg" },
                    { 4, false, "Ảnh minh hoạ D001", 1, "1_4_D001.jpg" },
                    { 3, false, "Ảnh minh hoạ D001", 1, "1_3_D001.jpg" },
                    { 21, false, "Ảnh minh hoạ D008", 8, "8_3_D008.jpg" },
                    { 2, false, "Ảnh minh hoạ D001", 1, "1_2_D001.jpg" },
                    { 1, false, "Ảnh minh hoạ D001", 1, "1_1_D001.jpg" },
                    { 41, false, "Ảnh minh hoạ N003", 22, "22_2_N003.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Promotion",
                columns: new[] { "ID", "Description", "Discount", "From", "IsDelete", "Name", "ProductID", "To", "Visible" },
                values: new object[,]
                {
                    { 4, "Giảm giá cực sốc từ 10% đến 50% nhân dịp cuối năm", 20, new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(9300), false, "Sale cuối năm", 4, new DateTime(2022, 1, 29, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(9300), true },
                    { 14, "Giảm giá cực sốc từ 10% đến 50% nhân dịp cuối năm", 50, new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(9350), false, "Sale cuối năm", 51, new DateTime(2022, 1, 29, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(9360), true },
                    { 19, "Giảm giá cực sốc từ 10% đến 50% nhân dịp cuối năm", 10, new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(9380), false, "Sale cuối năm", 83, new DateTime(2022, 1, 29, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(9380), true },
                    { 3, "Giảm giá cực sốc từ 10% đến 50% nhân dịp cuối năm", 30, new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(9300), false, "Sale cuối năm", 3, new DateTime(2022, 1, 29, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(9300), true },
                    { 1, "Giảm giá cực sốc từ 10% đến 50% nhân dịp cuối năm", 10, new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(6690), false, "Sale cuối năm", 1, new DateTime(2022, 1, 29, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(7250), true },
                    { 16, "Giảm giá cực sốc từ 10% đến 50% nhân dịp cuối năm", 40, new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(9360), false, "Sale cuối năm", 63, new DateTime(2022, 1, 29, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(9360), true },
                    { 18, "Giảm giá cực sốc từ 10% đến 50% nhân dịp cuối năm", 30, new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(9370), false, "Sale cuối năm", 65, new DateTime(2022, 1, 29, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(9370), true },
                    { 13, "Giảm giá cực sốc từ 10% đến 50% nhân dịp cuối năm", 20, new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(9340), false, "Sale cuối năm", 50, new DateTime(2022, 1, 29, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(9350), true },
                    { 15, "Giảm giá cực sốc từ 10% đến 50% nhân dịp cuối năm", 40, new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(9360), false, "Sale cuối năm", 52, new DateTime(2022, 1, 29, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(9360), true },
                    { 12, "Giảm giá cực sốc từ 10% đến 50% nhân dịp cuối năm", 20, new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(9340), false, "Sale cuối năm", 42, new DateTime(2022, 1, 29, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(9340), true },
                    { 8, "Giảm giá cực sốc từ 10% đến 50% nhân dịp cuối năm", 50, new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(9320), false, "Sale cuối năm", 21, new DateTime(2022, 1, 29, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(9320), true },
                    { 17, "Giảm giá cực sốc từ 10% đến 50% nhân dịp cuối năm", 30, new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(9370), false, "Sale cuối năm", 64, new DateTime(2022, 1, 29, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(9370), true },
                    { 5, "Giảm giá cực sốc từ 10% đến 50% nhân dịp cuối năm", 10, new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(9310), false, "Sale cuối năm", 5, new DateTime(2022, 1, 29, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(9310), true },
                    { 9, "Giảm giá cực sốc từ 10% đến 50% nhân dịp cuối năm", 50, new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(9330), false, "Sale cuối năm", 22, new DateTime(2022, 1, 29, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(9330), true },
                    { 11, "Giảm giá cực sốc từ 10% đến 50% nhân dịp cuối năm", 20, new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(9340), false, "Sale cuối năm", 41, new DateTime(2022, 1, 29, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(9340), true },
                    { 20, "Giảm giá cực sốc từ 10% đến 50% nhân dịp cuối năm", 10, new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(9380), false, "Sale cuối năm", 85, new DateTime(2022, 1, 29, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(9380), true },
                    { 10, "Giảm giá cực sốc từ 10% đến 50% nhân dịp cuối năm", 10, new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(9330), false, "Sale cuối năm", 40, new DateTime(2022, 1, 29, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(9330), true },
                    { 7, "Giảm giá cực sốc từ 10% đến 50% nhân dịp cuối năm", 10, new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(9320), false, "Sale cuối năm", 20, new DateTime(2022, 1, 29, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(9320), true },
                    { 6, "Giảm giá cực sốc từ 10% đến 50% nhân dịp cuối năm", 10, new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(9310), false, "Sale cuối năm", 6, new DateTime(2022, 1, 29, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(9310), true },
                    { 2, "Giảm giá cực sốc từ 10% đến 50% nhân dịp cuối năm", 20, new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(9210), false, "Sale cuối năm", 2, new DateTime(2022, 1, 29, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(9230), true }
                });

            migrationBuilder.InsertData(
                table: "Warehouse",
                columns: new[] { "ID", "Color", "LastUpdate", "ProductID", "Quantity", "Size", "Sold" },
                values: new object[,]
                {
                    { 133, "Xám", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2050), 65, 100, "M", 0 },
                    { 19, "Đỏ", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1620), 5, 100, "M", 0 },
                    { 140, "Đen", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2070), 69, 100, "L", 0 },
                    { 147, "Đen", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2090), 76, 100, "L", 0 },
                    { 23, "Đen", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1640), 6, 100, "M", 0 },
                    { 132, "Đỏ", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2050), 64, 100, "L", 0 },
                    { 139, "Xanh rêu", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2070), 68, 100, "L", 0 },
                    { 131, "Đỏ", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2050), 64, 100, "M", 0 },
                    { 137, "Đỏ", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2060), 66, 100, "L", 0 },
                    { 25, "Đỏ", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1640), 6, 100, "M", 0 },
                    { 24, "Đen", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1640), 6, 100, "L", 0 },
                    { 148, "Xám", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2090), 77, 100, "L", 0 },
                    { 146, "Nâu", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2090), 75, 100, "L", 0 },
                    { 28, "Vàng", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1650), 6, 100, "L", 0 },
                    { 141, "Đen", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2070), 70, 100, "L", 0 },
                    { 27, "Vàng", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1650), 6, 100, "M", 0 },
                    { 26, "Đỏ", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1640), 6, 100, "L", 0 },
                    { 145, "Xám", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2090), 74, 100, "L", 0 },
                    { 142, "Đỏ", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2080), 71, 100, "L", 0 },
                    { 21, "Vàng", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1630), 5, 100, "M", 0 },
                    { 136, "Vàng kem", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2060), 65, 100, "L", 0 },
                    { 135, "Vàng kem", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2060), 65, 100, "M", 0 },
                    { 22, "Vàng", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1630), 5, 100, "L", 0 },
                    { 143, "Xanh rêu", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2080), 72, 100, "L", 0 },
                    { 144, "Vàng kem", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2080), 73, 100, "L", 0 },
                    { 134, "Xám", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2050), 65, 100, "L", 0 },
                    { 20, "Đỏ", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1620), 5, 100, "L", 0 },
                    { 138, "Vàng", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2060), 67, 100, "L", 0 },
                    { 154, "Đen", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2110), 83, 100, "M", 0 },
                    { 150, "Đen", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2100), 79, 100, "L", 0 },
                    { 164, "Xám", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2140), 89, 100, "L", 0 },
                    { 165, "Xám", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2140), 90, 100, "L", 0 },
                    { 6, "Trắng", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1590), 1, 100, "XL", 0 },
                    { 166, "Đen", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2140), 91, 100, "L", 0 },
                    { 5, "Trắng", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1580), 1, 100, "L", 0 },
                    { 167, "Đen", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2150), 92, 100, "L", 0 },
                    { 4, "Trắng", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1580), 1, 100, "M", 0 },
                    { 168, "Xám", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2150), 93, 100, "L", 0 },
                    { 3, "Xanh dương", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1570), 1, 100, "XL", 0 },
                    { 169, "Xám", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2150), 94, 100, "L", 0 },
                    { 2, "Xanh dương", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1520), 1, 100, "L", 0 },
                    { 170, "Xanh rêu", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2160), 95, 100, "L", 0 },
                    { 1, "Xanh dương", new DateTime(2021, 12, 20, 16, 16, 44, 381, DateTimeKind.Local).AddTicks(4070), 1, 100, "M", 0 },
                    { 171, "Xám", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2160), 96, 100, "L", 0 },
                    { 172, "Nâu nhạt", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2160), 97, 100, "L", 0 },
                    { 173, "Đen", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2160), 98, 100, "L", 0 },
                    { 174, "Xám jean", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2170), 99, 100, "L", 0 },
                    { 175, "Trắng", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2170), 100, 100, "L", 0 },
                    { 176, "Trắng", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2170), 101, 100, "L", 0 },
                    { 163, "Đen", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2140), 88, 100, "L", 0 },
                    { 7, "Xanh lá", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1590), 2, 100, "M", 0 },
                    { 162, "Xanh jean", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2130), 87, 100, "L", 0 },
                    { 8, "Xanh lá", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1590), 2, 100, "L", 0 },
                    { 151, "Xanh rêu", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2100), 80, 100, "L", 0 },
                    { 18, "Xanh dương", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1620), 4, 100, "L", 0 },
                    { 152, "Trắng", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2110), 81, 100, "L", 0 },
                    { 17, "Xanh dương", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1620), 4, 100, "M", 0 },
                    { 153, "Đen", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2110), 82, 100, "L", 0 },
                    { 16, "Vàng cam", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1610), 4, 100, "L", 0 },
                    { 15, "Vàng cam", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1610), 4, 100, "M", 0 },
                    { 155, "Đen", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2110), 83, 100, "L", 0 },
                    { 14, "Đen", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1610), 3, 100, "L", 0 },
                    { 149, "Đỏ", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2100), 78, 100, "L", 0 },
                    { 13, "Đen", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1610), 3, 100, "M", 0 },
                    { 156, "Xanh jean", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2120), 84, 100, "M", 0 },
                    { 157, "Xanh jean", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2120), 84, 100, "L", 0 },
                    { 11, "Trắng", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1600), 3, 100, "M", 0 },
                    { 158, "Xanh jean", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2120), 85, 100, "M", 0 },
                    { 159, "Xanh jean", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2120), 85, 100, "L", 0 },
                    { 10, "Đỏ", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1600), 2, 100, "L", 0 },
                    { 9, "Đỏ", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1590), 2, 100, "M", 0 },
                    { 160, "Đen", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2130), 86, 100, "M", 0 },
                    { 161, "Đen", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2130), 86, 100, "L", 0 },
                    { 12, "Trắng", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1600), 3, 100, "L", 0 },
                    { 65, "Vàng", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1860), 22, 100, "L", 0 },
                    { 123, "Xanh biển", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2020), 59, 100, "L", 0 },
                    { 130, "Đen", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2040), 63, 100, "L", 0 },
                    { 55, "Trắng", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1830), 20, 100, "XL", 0 },
                    { 84, "Trắng", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1920), 36, 100, "L", 0 },
                    { 54, "Trắng", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1830), 20, 100, "L", 0 },
                    { 85, "Xanh", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1920), 37, 100, "L", 0 },
                    { 53, "Trắng", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1720), 20, 100, "M", 0 },
                    { 86, "Đen", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1920), 38, 100, "L", 0 },
                    { 87, "Trắng", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1920), 39, 100, "M", 0 },
                    { 88, "Trắng", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1930), 39, 100, "L", 0 },
                    { 52, "Trắng vàng", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1720), 19, 100, "L", 0 },
                    { 89, "Trắng", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1930), 40, 100, "M", 0 },
                    { 90, "Trắng", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1930), 40, 100, "L", 0 },
                    { 51, "Xanh đen", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1710), 18, 100, "L", 0 },
                    { 91, "Caro xanh", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1930), 41, 100, "M", 0 },
                    { 92, "Caro xanh", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1940), 41, 100, "L", 0 },
                    { 93, "Caro đỏ", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1940), 41, 100, "M", 0 },
                    { 94, "Caro đỏ", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1940), 41, 100, "L", 0 },
                    { 50, "Xám", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1710), 17, 100, "L", 0 },
                    { 95, "Caro xám", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1950), 42, 100, "M", 0 },
                    { 96, "Caro xám", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1950), 42, 100, "L", 0 },
                    { 49, "Xám", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1710), 16, 100, "L", 0 },
                    { 97, "Caro đỏ", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1950), 43, 100, "L", 0 },
                    { 83, "Xanh đen", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1910), 35, 100, "L", 0 },
                    { 82, "Xám", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1910), 34, 100, "L", 0 },
                    { 81, "Đen", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1910), 33, 100, "L", 0 },
                    { 80, "Trắng", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1910), 32, 100, "L", 0 },
                    { 63, "Đỏ", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1860), 22, 100, "L", 0 },
                    { 66, "Trắng", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1860), 23, 100, "M", 0 },
                    { 67, "Trắng", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1870), 23, 100, "L", 0 },
                    { 68, "Đen", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1870), 23, 100, "M", 0 },
                    { 69, "Đen", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1870), 23, 100, "L", 0 },
                    { 62, "Đỏ", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1850), 22, 100, "M", 0 },
                    { 70, "Xanh rêu", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1880), 24, 100, "M", 0 },
                    { 71, "Xanh rêu", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1880), 24, 100, "L", 0 },
                    { 61, "Xám", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1850), 22, 100, "L", 0 },
                    { 60, "Xám", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1850), 22, 100, "M", 0 },
                    { 98, "Caro đỏ", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1960), 44, 100, "L", 0 },
                    { 72, "Trắng", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1880), 25, 100, "M", 0 },
                    { 74, "Đen", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1890), 26, 100, "L", 0 },
                    { 75, "Trắng", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1890), 27, 100, "L", 0 },
                    { 76, "Đen", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1890), 28, 100, "L", 0 },
                    { 59, "Nâu nhạt", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1850), 21, 100, "L", 0 },
                    { 77, "Trắng", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1900), 29, 100, "L", 0 },
                    { 58, "Nâu nhạt", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1840), 21, 100, "M", 0 },
                    { 78, "Đen", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1900), 30, 100, "L", 0 },
                    { 57, "Vàng", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1840), 21, 100, "L", 0 },
                    { 79, "Trắng", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1900), 31, 100, "L", 0 },
                    { 56, "Vàng", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1830), 21, 100, "M", 0 },
                    { 73, "Trắng", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1880), 25, 100, "L", 0 },
                    { 29, "Xanh lá", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1650), 7, 100, "M", 0 },
                    { 48, "Đen", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1710), 15, 100, "L", 0 },
                    { 100, "Đen", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1960), 46, 100, "L", 0 },
                    { 38, "Xanh nhạt", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1680), 8, 100, "L", 0 },
                    { 118, "Xanh biển", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2010), 54, 100, "L", 0 },
                    { 37, "Xanh nhạt", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1670), 8, 100, "M", 0 },
                    { 119, "Hoạ tiết 1", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2010), 55, 100, "L", 0 },
                    { 36, "Đen", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1670), 8, 100, "L", 0 },
                    { 120, "Xanh biển", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2020), 56, 100, "L", 0 },
                    { 35, "Đen", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1670), 8, 100, "M", 0 },
                    { 121, "Trắng", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2020), 57, 100, "L", 0 },
                    { 34, "Trắng", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1660), 8, 100, "L", 0 },
                    { 122, "Xanh dương", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2020), 58, 100, "L", 0 },
                    { 33, "Trắng", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1660), 8, 100, "M", 0 },
                    { 64, "Vàng", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1860), 22, 100, "M", 0 },
                    { 124, "Nâu nhạt", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2030), 60, 100, "L", 0 }
                });

            migrationBuilder.InsertData(
                table: "Warehouse",
                columns: new[] { "ID", "Color", "LastUpdate", "ProductID", "Quantity", "Size", "Sold" },
                values: new object[,]
                {
                    { 125, "Trắng", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2030), 61, 100, "L", 0 },
                    { 126, "Xanh biển", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2030), 62, 100, "L", 0 },
                    { 32, "Xanh mint", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1660), 7, 100, "L", 0 },
                    { 31, "Xanh mint", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1660), 7, 100, "M", 0 },
                    { 30, "Xanh lá", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1650), 7, 100, "L", 0 },
                    { 127, "Đỏ", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2040), 63, 100, "M", 0 },
                    { 128, "Đỏ", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2040), 63, 100, "L", 0 },
                    { 129, "Đen", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2040), 63, 100, "M", 0 },
                    { 117, "Đen", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2010), 53, 100, "L", 0 },
                    { 116, "Trắng", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2010), 52, 100, "XL", 0 },
                    { 115, "Trắng", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2000), 52, 100, "L", 0 },
                    { 114, "Trắng", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2000), 52, 100, "M", 0 },
                    { 47, "Xanh đen", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1700), 14, 100, "L", 0 },
                    { 101, "Trắng", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1960), 47, 100, "M", 0 },
                    { 102, "Trắng", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1970), 47, 100, "L", 0 },
                    { 103, "Đen", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1970), 47, 100, "M", 0 },
                    { 104, "Đen", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1970), 47, 100, "L", 0 },
                    { 105, "Đen", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1970), 48, 100, "L", 0 },
                    { 46, "Đỏ", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1700), 13, 100, "L", 0 },
                    { 106, "Xanh biển", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1980), 49, 100, "L", 0 },
                    { 45, "Đen", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1700), 12, 100, "L", 0 },
                    { 44, "Xanh dương", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1700), 11, 100, "L", 0 },
                    { 99, "Trắng", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1960), 45, 100, "L", 0 },
                    { 107, "Xanh biển", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1980), 50, 100, "M", 0 },
                    { 109, "Xanh biển", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1990), 50, 100, "XL", 0 },
                    { 43, "Đen", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1690), 10, 100, "L", 0 },
                    { 42, "Trắng", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1690), 9, 100, "L", 0 },
                    { 110, "Caro cam", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1990), 51, 100, "M", 0 },
                    { 111, "Caro cam", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1990), 51, 100, "L", 0 },
                    { 112, "Caro xanh", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2000), 51, 100, "M", 0 },
                    { 113, "Caro xanh", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2000), 51, 100, "L", 0 },
                    { 41, "Trắng", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1690), 9, 100, "M", 0 },
                    { 40, "Xanh đen", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1690), 9, 100, "L", 0 },
                    { 39, "Xanh đen", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1680), 9, 100, "M", 0 },
                    { 108, "Xanh biển", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(1980), 50, 100, "L", 0 },
                    { 177, "Đen", new DateTime(2021, 12, 20, 16, 16, 44, 396, DateTimeKind.Local).AddTicks(2170), 102, 100, "L", 0 }
                });

            migrationBuilder.Sql(
                "INSERT [dbo].[ProductTag] ([ProductID], [TagID]) VALUES (1, 1), (2, 1), (20, 1), (21, 1), (22, 1), (40, 1), (50, 1), (51, 1), (52, 1), (63, 1), (64, 1), (1, 2), (5, 2), (20, 2), (22, 2), (50, 2), (52, 2), (63, 2), (64, 2), (83, 2), (84, 2), (3, 3), (1, 4), (2, 4), (4, 4), (5, 4), (6, 4), (7, 4), (8, 4), (10, 4), (11, 4), (13, 4), (14, 4), (15, 4), (16, 4), (18, 4), (19, 4), (20, 4), (27, 4), (30, 4), (31, 4), (34, 4), (36, 4), (37, 4), (1, 5), (2, 5), (4, 5), (5, 5), (6, 5), (7, 5), (8, 5), (9, 5), (10, 5), (11, 5), (12, 5), (13, 5), (14, 5), (15, 5), (16, 5), (17, 5), (18, 5), (19, 5), (20, 5), (21, 5), (22, 5), (24, 5), (26, 5), (28, 5), (32, 5), (33, 5), (35, 5), (38, 5), (3, 6), (7, 6), (8, 6), (9, 6), (12, 6), (14, 6), (15, 6), (16, 6), (17, 6), (18, 6), (21, 6), (22, 6), (23, 6), (29, 6), (39, 7), (41, 7), (43, 7), (44, 7), (46, 7), (48, 7), (50, 7), (51, 7), (52, 7), (53, 7), (54, 7), (55, 7), (56, 7), (58, 7)"
                + "INSERT [dbo].[ProductTag] ([ProductID], [TagID]) VALUES (59, 7), (61, 7), (62, 7), (40, 8), (45, 8), (47, 8), (49, 8), (50, 9), (51, 9), (52, 9), (56, 9), (57, 9), (60, 9), (39, 10), (40, 10), (41, 10), (42, 10), (45, 10), (73, 11), (75, 11), (77, 11), (78, 11), (91, 11), (92, 11), (93, 11), (94, 11), (95, 11), (96, 11), (97, 11), (99, 11), (100, 11), (101, 11), (102, 11), (17, 12), (67, 12), (68, 12), (69, 12), (71, 12), (75, 12), (78, 12), (81, 12), (82, 12), (83, 12), (84, 12), (85, 12), (86, 12), (87, 12), (88, 12), (89, 12), (90, 12), (91, 12), (92, 12), (93, 12), (94, 12), (96, 12), (98, 12), (99, 12), (101, 12), (102, 12), (67, 13), (68, 13), (69, 13), (71, 13), (72, 13), (73, 13), (74, 13), (75, 13), (77, 13), (79, 13), (81, 13), (82, 13), (83, 13), (84, 13), (85, 13), (86, 13), (87, 13), (88, 13), (89, 13), (90, 13), (91, 13), (92, 13), (93, 13), (94, 13), (95, 13), (96, 13), (97, 13), (98, 13), (99, 13), (100, 13), (101, 13), (63, 15), (64, 15), (65, 15), (66, 15), (68, 15), (71, 15), (76, 15), (77, 15), (78, 15), (80, 15)"
                + "INSERT [dbo].[ProductTag] ([ProductID], [TagID]) VALUES (81, 15), (83, 15), (84, 15), (85, 15), (86, 15), (87, 15), (88, 15), (89, 15), (95, 15), (96, 15), (97, 15), (98, 15), (100, 15), (101, 15), (102, 15), (64, 16), (65, 16), (67, 16), (69, 16), (70, 16), (72, 16), (73, 16), (74, 16), (75, 16), (79, 16), (82, 16)"
            );            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Image_Product_ProductId",
                table: "Image");

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
                name: "ProductId",
                table: "Image",
                newName: "productID");

            migrationBuilder.RenameIndex(
                name: "IX_Image_ProductId",
                table: "Image",
                newName: "IX_Image_productID");

            migrationBuilder.AddForeignKey(
                name: "FK_Image_Product_productID",
                table: "Image",
                column: "productID",
                principalTable: "Product",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

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
