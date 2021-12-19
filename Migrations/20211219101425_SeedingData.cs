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
                table: "Product",
                columns: new[] { "ID", "Description", "IsDelete", "Name", "Price", "ProductType", "Visible" },
                values: new object[,]
                {
                    { 1, "Bạn có đang tìm kiếm cho mình một một chiếc áo dài tay ấm áp. Coolmate hiểu được điều đó và đã nghiên cứu để gửi đến bạn một chiếc áo Sweatshirt với thiết kế vừa vặn, vô cùng thoải mái với chất liệu đặc biệt mềm mại. Và đó chính là áo nam Casual Sweatshirt - hoàn hảo cho những ngày thoải mái ở nhà, nhưng đủ tự tin để dạo phố cùng bạn bè.", false, "Áo Thun Tay Dài D001", 230000, "Áo thun tay dài", true },
                    { 76, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Dài QD014", 199000, "Quần dài", true },
                    { 75, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Dài QD013", 230000, "Quần dài", true },
                    { 74, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Dài QD012", 230000, "Quần dài", true },
                    { 73, "Lắng nghe khách hàng của mình và hiểu được mỗi chàng trai đều cần có trong tủ đồ mình 1 chiếc quần đặc biệt thoải mái trong mọi vận động. Và Coolmate đặc biệt cho ra mắt sản phẩm Quần phiên bản mới với chất liệu vải 100% Polyester PTT đặc biệt CO GIÃN TUYỆT VỜI đem đến sự thoải mái tối đa.", false, "Quần Dài QD011", 230000, "Quần dài", true },
                    { 72, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Dài QD010", 199000, "Quần dài", true },
                    { 71, "Lắng nghe khách hàng của mình và hiểu được mỗi chàng trai đều cần có trong tủ đồ mình 1 chiếc quần đặc biệt thoải mái trong mọi vận động. Và Coolmate đặc biệt cho ra mắt sản phẩm Quần phiên bản mới với chất liệu vải 100% Polyester PTT đặc biệt CO GIÃN TUYỆT VỜI đem đến sự thoải mái tối đa.", false, "Quần Dài QD009", 230000, "Quần dài", true },
                    { 70, "Lắng nghe khách hàng của mình và hiểu được mỗi chàng trai đều cần có trong tủ đồ mình 1 chiếc quần đặc biệt thoải mái trong mọi vận động. Và Coolmate đặc biệt cho ra mắt sản phẩm Quần phiên bản mới với chất liệu vải 100% Polyester PTT đặc biệt CO GIÃN TUYỆT VỜI đem đến sự thoải mái tối đa.", false, "Quần Dài QD008", 199000, "Quần dài", true },
                    { 69, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Dài QD007", 230000, "Quần dài", true },
                    { 68, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Dài QD006", 230000, "Quần dài", true },
                    { 67, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Dài QD005", 230000, "Quần dài", true },
                    { 77, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Dài QD015", 199000, "Quần dài", true },
                    { 66, "Lắng nghe khách hàng của mình và hiểu được mỗi chàng trai đều cần có trong tủ đồ mình 1 chiếc quần đặc biệt thoải mái trong mọi vận động. Và Coolmate đặc biệt cho ra mắt sản phẩm Quần phiên bản mới với chất liệu vải 100% Polyester PTT đặc biệt CO GIÃN TUYỆT VỜI đem đến sự thoải mái tối đa.", false, "Quần Dài QD004", 230000, "Quần dài", true },
                    { 64, "Lắng nghe khách hàng của mình và hiểu được mỗi chàng trai đều cần có trong tủ đồ mình 1 chiếc quần đặc biệt thoải mái trong mọi vận động. Và Coolmate đặc biệt cho ra mắt sản phẩm Quần phiên bản mới với chất liệu vải 100% Polyester PTT đặc biệt CO GIÃN TUYỆT VỜI đem đến sự thoải mái tối đa.", false, "Quần Dài QD002", 199000, "Quần dài", true },
                    { 63, "Lắng nghe khách hàng của mình và hiểu được mỗi chàng trai đều cần có trong tủ đồ mình 1 chiếc quần đặc biệt thoải mái trong mọi vận động. Và Coolmate đặc biệt cho ra mắt sản phẩm Quần phiên bản mới với chất liệu vải 100% Polyester PTT đặc biệt CO GIÃN TUYỆT VỜI đem đến sự thoải mái tối đa.", false, "Quần Dài QD001", 199000, "Quần dài", true },
                    { 62, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu bamboo (vải tre) Ex-Soft này, sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo bamboo này có gì đặc biệt nhé!", false, "Áo Sơ Mi N013", 230000, "Áo sơ mi tay ngắn", true },
                    { 61, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu bamboo (vải tre) Ex-Soft này, sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo bamboo này có gì đặc biệt nhé!", false, "Áo Sơ Mi N012", 230000, "Áo sơ mi tay ngắn", true },
                    { 60, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu modal (gỗ sồi), sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo sơ mi Modal này có gì đặc biệt nhé!", false, "Áo Sơ Mi N011", 230000, "Áo sơ mi tay ngắn", true },
                    { 58, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu modal (gỗ sồi), sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo sơ mi Modal này có gì đặc biệt nhé!", false, "Áo Sơ Mi N009", 230000, "Áo sơ mi tay ngắn", true },
                    { 57, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu modal (gỗ sồi), sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo sơ mi Modal này có gì đặc biệt nhé!", false, "Áo Sơ Mi N008", 230000, "Áo sơ mi tay ngắn", true },
                    { 56, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu modal (gỗ sồi), sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo sơ mi Modal này có gì đặc biệt nhé!", false, "Áo Sơ Mi N007", 199000, "Áo sơ mi tay ngắn", true },
                    { 55, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu bamboo (vải tre) Ex-Soft này, sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo bamboo này có gì đặc biệt nhé!", false, "Áo Sơ Mi N006", 199000, "Áo sơ mi tay ngắn", true },
                    { 54, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu bamboo (vải tre) Ex-Soft này, sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo bamboo này có gì đặc biệt nhé!", false, "Áo Sơ Mi N005", 230000, "Áo sơ mi tay ngắn", true },
                    { 65, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Dài QD003", 230000, "Quần dài", true },
                    { 53, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu bamboo (vải tre) Ex-Soft này, sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo bamboo này có gì đặc biệt nhé!", false, "Áo Sơ Mi N004", 199000, "Áo sơ mi tay ngắn", true },
                    { 78, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Dài QD016", 230000, "Quần dài", true },
                    { 80, "Lắng nghe khách hàng của mình và hiểu được mỗi chàng trai đều cần có trong tủ đồ mình 1 chiếc quần đặc biệt thoải mái trong mọi vận động. Và Coolmate đặc biệt cho ra mắt sản phẩm Quần phiên bản mới với chất liệu vải 100% Polyester PTT đặc biệt CO GIÃN TUYỆT VỜI đem đến sự thoải mái tối đa.", false, "Quần Dài QD018", 230000, "Quần dài", true },
                    { 102, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Ngắn QN020", 199000, "Quần ngắn", true },
                    { 101, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Ngắn QN019", 230000, "Quần ngắn", true },
                    { 100, "Lắng nghe khách hàng của mình và hiểu được mỗi chàng trai đều cần có trong tủ đồ mình 1 chiếc quần đặc biệt thoải mái trong mọi vận động. Và Coolmate đặc biệt cho ra mắt sản phẩm Quần phiên bản mới với chất liệu vải 100% Polyester PTT đặc biệt CO GIÃN TUYỆT VỜI đem đến sự thoải mái tối đa.", false, "Quần Ngắn QN018", 230000, "Quần ngắn", true },
                    { 99, "Lắng nghe khách hàng của mình và hiểu được mỗi chàng trai đều cần có trong tủ đồ mình 1 chiếc quần đặc biệt thoải mái trong mọi vận động. Và Coolmate đặc biệt cho ra mắt sản phẩm Quần phiên bản mới với chất liệu vải 100% Polyester PTT đặc biệt CO GIÃN TUYỆT VỜI đem đến sự thoải mái tối đa.", false, "Quần Ngắn QN017", 230000, "Quần ngắn", true },
                    { 98, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Ngắn QN016", 230000, "Quần ngắn", true },
                    { 97, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Ngắn QN015", 230000, "Quần ngắn", true },
                    { 96, "Lắng nghe khách hàng của mình và hiểu được mỗi chàng trai đều cần có trong tủ đồ mình 1 chiếc quần đặc biệt thoải mái trong mọi vận động. Và Coolmate đặc biệt cho ra mắt sản phẩm Quần phiên bản mới với chất liệu vải 100% Polyester PTT đặc biệt CO GIÃN TUYỆT VỜI đem đến sự thoải mái tối đa.", false, "Quần Ngắn QN014", 230000, "Quần ngắn", true },
                    { 95, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Ngắn QN013", 199000, "Quần ngắn", true },
                    { 94, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Ngắn QN012", 230000, "Quần ngắn", true },
                    { 93, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Ngắn QN011", 230000, "Quần ngắn", true },
                    { 79, "Lắng nghe khách hàng của mình và hiểu được mỗi chàng trai đều cần có trong tủ đồ mình 1 chiếc quần đặc biệt thoải mái trong mọi vận động. Và Coolmate đặc biệt cho ra mắt sản phẩm Quần phiên bản mới với chất liệu vải 100% Polyester PTT đặc biệt CO GIÃN TUYỆT VỜI đem đến sự thoải mái tối đa.", false, "Quần Dài QD017", 230000, "Quần dài", true },
                    { 92, "Lắng nghe khách hàng của mình và hiểu được mỗi chàng trai đều cần có trong tủ đồ mình 1 chiếc quần đặc biệt thoải mái trong mọi vận động. Và Coolmate đặc biệt cho ra mắt sản phẩm Quần phiên bản mới với chất liệu vải 100% Polyester PTT đặc biệt CO GIÃN TUYỆT VỜI đem đến sự thoải mái tối đa.", false, "Quần Ngắn QN010", 230000, "Quần ngắn", true },
                    { 90, "Lắng nghe khách hàng của mình và hiểu được mỗi chàng trai đều cần có trong tủ đồ mình 1 chiếc quần đặc biệt thoải mái trong mọi vận động. Và Coolmate đặc biệt cho ra mắt sản phẩm Quần phiên bản mới với chất liệu vải 100% Polyester PTT đặc biệt CO GIÃN TUYỆT VỜI đem đến sự thoải mái tối đa.", false, "Quần Ngắn QN008", 199000, "Quần ngắn", true },
                    { 89, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Ngắn QN007", 199000, "Quần ngắn", true },
                    { 88, "Lắng nghe khách hàng của mình và hiểu được mỗi chàng trai đều cần có trong tủ đồ mình 1 chiếc quần đặc biệt thoải mái trong mọi vận động. Và Coolmate đặc biệt cho ra mắt sản phẩm Quần phiên bản mới với chất liệu vải 100% Polyester PTT đặc biệt CO GIÃN TUYỆT VỜI đem đến sự thoải mái tối đa.", false, "Quần Ngắn QN006", 230000, "Quần ngắn", true },
                    { 87, "Lắng nghe khách hàng của mình và hiểu được mỗi chàng trai đều cần có trong tủ đồ mình 1 chiếc quần đặc biệt thoải mái trong mọi vận động. Và Coolmate đặc biệt cho ra mắt sản phẩm Quần phiên bản mới với chất liệu vải 100% Polyester PTT đặc biệt CO GIÃN TUYỆT VỜI đem đến sự thoải mái tối đa.", false, "Quần Ngắn QN005", 230000, "Quần ngắn", true },
                    { 86, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Ngắn QN004", 230000, "Quần ngắn", true },
                    { 85, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Ngắn QN003", 199000, "Quần ngắn", true },
                    { 84, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Ngắn QN002", 230000, "Quần ngắn", true },
                    { 83, "Lắng nghe khách hàng của mình và hiểu được mỗi chàng trai đều cần có trong tủ đồ mình 1 chiếc quần đặc biệt thoải mái trong mọi vận động. Và Coolmate đặc biệt cho ra mắt sản phẩm Quần phiên bản mới với chất liệu vải 100% Polyester PTT đặc biệt CO GIÃN TUYỆT VỜI đem đến sự thoải mái tối đa.", false, "Quần Ngắn QN001", 199000, "Quần ngắn", true },
                    { 82, "Lắng nghe khách hàng của mình và hiểu được mỗi chàng trai đều cần có trong tủ đồ mình 1 chiếc quần đặc biệt thoải mái trong mọi vận động. Và Coolmate đặc biệt cho ra mắt sản phẩm Quần phiên bản mới với chất liệu vải 100% Polyester PTT đặc biệt CO GIÃN TUYỆT VỜI đem đến sự thoải mái tối đa.", false, "Quần Dài QD020", 230000, "Quần dài", true },
                    { 81, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Dài QD019", 199000, "Quần dài", true },
                    { 91, "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.", false, "Quần Ngắn QN009", 199000, "Quần ngắn", true },
                    { 52, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu bamboo (vải tre) Ex-Soft này, sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo bamboo này có gì đặc biệt nhé!", false, "Áo Sơ Mi N003", 230000, "Áo sơ mi tay ngắn", true },
                    { 59, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu modal (gỗ sồi), sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo sơ mi Modal này có gì đặc biệt nhé!", false, "Áo Sơ Mi N010", 230000, "Áo sơ mi tay ngắn", true },
                    { 50, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu modal (gỗ sồi), sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo sơ mi Modal này có gì đặc biệt nhé!", false, "Áo Sơ Mi N001", 230000, "Áo sơ mi tay ngắn", true },
                    { 23, "T-Shirt Cotton Compact Premium là sản phẩm áo thun hoàn toàn mới với nhiều sự cải tiến đã được nghiên cứu kỹ lưỡng và phát triển với chất liệu Cotton Compact cao cấp. Một chiếc áo nên có trong tủ đồ với sự đa dụng dùng được trong mọi hoàn cảnh: đi làm, đi chơi, cafe hay cả những buổi gặp mặt lịch sự thì T-Shirt Coolmate chắc chắn sẽ làm bạn trên cả sự hài lòng. Đơn giản nhưng cực nam tính, đơn điệu mà vẫn thời thượng", false, "Áo Thun Tay Ngắn N004", 199000, "Áo thun tay ngắn", true },
                    { 22, "T-Shirt Cotton Compact Premium là sản phẩm áo thun hoàn toàn mới với nhiều sự cải tiến đã được nghiên cứu kỹ lưỡng và phát triển với chất liệu Cotton Compact cao cấp. Một chiếc áo nên có trong tủ đồ với sự đa dụng dùng được trong mọi hoàn cảnh: đi làm, đi chơi, cafe hay cả những buổi gặp mặt lịch sự thì T-Shirt Coolmate chắc chắn sẽ làm bạn trên cả sự hài lòng. Đơn giản nhưng cực nam tính, đơn điệu mà vẫn thời thượng", false, "Áo Thun Tay Ngắn N003", 199000, "Áo thun tay ngắn", true },
                    { 21, "Vẫn là những chiếc áo với chật liệu Cotton 100% USA đã làm siêu lòng bao nhiêu khách hàng với những ưu điểm đặc biệt. Coolmate hiểu rằng, bạn không chỉ mong muốn có những chiếc áo thun trơn mà thêm những chiếc áo mang nhiều màu sắc, thiết kế mới mẻ mà vẫn tinh tế và đa dụng. Vì vậy, T-Shirt Pocket Tee ra đời với điểm nhấn là một chiếc túi nhỏ thiết kế trước ngực cùng sự tinh chỉnh thêm một số chi tiết nhỏ khác chắc chắn sẽ làm bạn hài lòng.", false, "Áo Thun Tay Ngắn N002", 230000, "Áo thun tay ngắn", true },
                    { 20, "T-Shirt Cotton Compact Premium là sản phẩm áo thun hoàn toàn mới với nhiều sự cải tiến đã được nghiên cứu kỹ lưỡng và phát triển với chất liệu Cotton Compact cao cấp. Một chiếc áo nên có trong tủ đồ với sự đa dụng dùng được trong mọi hoàn cảnh: đi làm, đi chơi, cafe hay cả những buổi gặp mặt lịch sự thì T-Shirt Coolmate chắc chắn sẽ làm bạn trên cả sự hài lòng. Đơn giản nhưng cực nam tính, đơn điệu mà vẫn thời thượng", false, "Áo Thun Tay Ngắn N001", 199000, "Áo thun tay ngắn", true },
                    { 51, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu bamboo (vải tre) Ex-Soft này, sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo bamboo này có gì đặc biệt nhé!", false, "Áo Sơ Mi N002", 199000, "Áo sơ mi tay ngắn", true },
                    { 18, "Bạn có đang tìm kiếm cho mình một một chiếc áo dài tay ấm áp. Coolmate hiểu được điều đó và đã nghiên cứu để gửi đến bạn một chiếc áo Sweatshirt với thiết kế vừa vặn, vô cùng thoải mái với chất liệu đặc biệt mềm mại. Và đó chính là áo nam Casual Sweatshirt - hoàn hảo cho những ngày thoải mái ở nhà, nhưng đủ tự tin để dạo phố cùng bạn bè.", false, "Áo Thun Tay Dài D018", 199000, "Áo thun tay dài", true },
                    { 17, "Bạn có đang tìm kiếm cho mình một một chiếc áo dài tay ấm áp. Coolmate hiểu được điều đó và đã nghiên cứu để gửi đến bạn một chiếc áo Sweatshirt với thiết kế vừa vặn, vô cùng thoải mái với chất liệu đặc biệt mềm mại. Và đó chính là áo nam Casual Sweatshirt - hoàn hảo cho những ngày thoải mái ở nhà, nhưng đủ tự tin để dạo phố cùng bạn bè.", false, "Áo Thun Tay Dài D017", 199000, "Áo thun tay dài", true },
                    { 16, "Bạn có đang tìm kiếm cho mình một một chiếc áo dài tay ấm áp. Coolmate hiểu được điều đó và đã nghiên cứu để gửi đến bạn một chiếc áo Sweatshirt với thiết kế vừa vặn, vô cùng thoải mái với chất liệu đặc biệt mềm mại. Và đó chính là áo nam Casual Sweatshirt - hoàn hảo cho những ngày thoải mái ở nhà, nhưng đủ tự tin để dạo phố cùng bạn bè.", false, "Áo Thun Tay Dài D016", 199000, "Áo thun tay dài", true },
                    { 15, "Rất nhiều thời gian và công sức để nghiên cứu và phát triển một sản phẩm, thay vì những vải lót bông bình thường dễ bị xù hoặc rụng bông nhỏ trong quá trình giặt và sử dụng, Coolmate lựa chọn chất liệu là 90% Cotton giúp chiếc áo của bạn vẫn thoát mồ hôi mà không hề gây bí, khó chịu; kết hợp với 10% Polyester giúp áo không nhăn và luôn bền dù có giặt, sấy bằng máy.", false, "Áo Thun Tay Dài D015", 230000, "Áo thun tay dài", true },
                    { 14, "Rất nhiều thời gian và công sức để nghiên cứu và phát triển một sản phẩm, thay vì những vải lót bông bình thường dễ bị xù hoặc rụng bông nhỏ trong quá trình giặt và sử dụng, Coolmate lựa chọn chất liệu là 90% Cotton giúp chiếc áo của bạn vẫn thoát mồ hôi mà không hề gây bí, khó chịu; kết hợp với 10% Polyester giúp áo không nhăn và luôn bền dù có giặt, sấy bằng máy.", false, "Áo Thun Tay Dài D014", 230000, "Áo thun tay dài", true },
                    { 24, "T-Shirt Cotton Compact Premium là sản phẩm áo thun hoàn toàn mới với nhiều sự cải tiến đã được nghiên cứu kỹ lưỡng và phát triển với chất liệu Cotton Compact cao cấp. Một chiếc áo nên có trong tủ đồ với sự đa dụng dùng được trong mọi hoàn cảnh: đi làm, đi chơi, cafe hay cả những buổi gặp mặt lịch sự thì T-Shirt Coolmate chắc chắn sẽ làm bạn trên cả sự hài lòng. Đơn giản nhưng cực nam tính, đơn điệu mà vẫn thời thượng", false, "Áo Thun Tay Ngắn N005", 199000, "Áo thun tay ngắn", true },
                    { 13, "Bạn có đang tìm kiếm cho mình một một chiếc áo dài tay ấm áp. Coolmate hiểu được điều đó và đã nghiên cứu để gửi đến bạn một chiếc áo Sweatshirt với thiết kế vừa vặn, vô cùng thoải mái với chất liệu đặc biệt mềm mại. Và đó chính là áo nam Casual Sweatshirt - hoàn hảo cho những ngày thoải mái ở nhà, nhưng đủ tự tin để dạo phố cùng bạn bè.", false, "Áo Thun Tay Dài D013", 230000, "Áo thun tay dài", true },
                    { 11, "Rất nhiều thời gian và công sức để nghiên cứu và phát triển một sản phẩm, thay vì những vải lót bông bình thường dễ bị xù hoặc rụng bông nhỏ trong quá trình giặt và sử dụng, Coolmate lựa chọn chất liệu là 90% Cotton giúp chiếc áo của bạn vẫn thoát mồ hôi mà không hề gây bí, khó chịu; kết hợp với 10% Polyester giúp áo không nhăn và luôn bền dù có giặt, sấy bằng máy.", false, "Áo Thun Tay Dài D011", 230000, "Áo thun tay dài", true },
                    { 10, "Rất nhiều thời gian và công sức để nghiên cứu và phát triển một sản phẩm, thay vì những vải lót bông bình thường dễ bị xù hoặc rụng bông nhỏ trong quá trình giặt và sử dụng, Coolmate lựa chọn chất liệu là 90% Cotton giúp chiếc áo của bạn vẫn thoát mồ hôi mà không hề gây bí, khó chịu; kết hợp với 10% Polyester giúp áo không nhăn và luôn bền dù có giặt, sấy bằng máy.", false, "Áo Thun Tay Dài D010", 230000, "Áo thun tay dài", true },
                    { 9, "Bạn có đang tìm kiếm cho mình một một chiếc áo dài tay ấm áp. Coolmate hiểu được điều đó và đã nghiên cứu để gửi đến bạn một chiếc áo Sweatshirt với thiết kế vừa vặn, vô cùng thoải mái với chất liệu đặc biệt mềm mại. Và đó chính là áo nam Casual Sweatshirt - hoàn hảo cho những ngày thoải mái ở nhà, nhưng đủ tự tin để dạo phố cùng bạn bè.", false, "Áo Thun Tay Dài D009", 199000, "Áo thun tay dài", true },
                    { 8, "Bạn có đang tìm kiếm cho mình một một chiếc áo dài tay ấm áp. Coolmate hiểu được điều đó và đã nghiên cứu để gửi đến bạn một chiếc áo Sweatshirt với thiết kế vừa vặn, vô cùng thoải mái với chất liệu đặc biệt mềm mại. Và đó chính là áo nam Casual Sweatshirt - hoàn hảo cho những ngày thoải mái ở nhà, nhưng đủ tự tin để dạo phố cùng bạn bè.", false, "Áo Thun Tay Dài D008", 199000, "Áo thun tay dài", true },
                    { 7, "Rất nhiều thời gian và công sức để nghiên cứu và phát triển một sản phẩm, thay vì những vải lót bông bình thường dễ bị xù hoặc rụng bông nhỏ trong quá trình giặt và sử dụng, Coolmate lựa chọn chất liệu là 90% Cotton giúp chiếc áo của bạn vẫn thoát mồ hôi mà không hề gây bí, khó chịu; kết hợp với 10% Polyester giúp áo không nhăn và luôn bền dù có giặt, sấy bằng máy.", false, "Áo Thun Tay Dài D007", 230000, "Áo thun tay dài", true },
                    { 6, "Rất nhiều thời gian và công sức để nghiên cứu và phát triển một sản phẩm, thay vì những vải lót bông bình thường dễ bị xù hoặc rụng bông nhỏ trong quá trình giặt và sử dụng, Coolmate lựa chọn chất liệu là 90% Cotton giúp chiếc áo của bạn vẫn thoát mồ hôi mà không hề gây bí, khó chịu; kết hợp với 10% Polyester giúp áo không nhăn và luôn bền dù có giặt, sấy bằng máy.", false, "Áo Thun Tay Dài D006", 199000, "Áo thun tay dài", true },
                    { 5, "Rất nhiều thời gian và công sức để nghiên cứu và phát triển một sản phẩm, thay vì những vải lót bông bình thường dễ bị xù hoặc rụng bông nhỏ trong quá trình giặt và sử dụng, Coolmate lựa chọn chất liệu là 90% Cotton giúp chiếc áo của bạn vẫn thoát mồ hôi mà không hề gây bí, khó chịu; kết hợp với 10% Polyester giúp áo không nhăn và luôn bền dù có giặt, sấy bằng máy.", false, "Áo Thun Tay Dài D005", 199000, "Áo thun tay dài", true },
                    { 4, "Bạn có đang tìm kiếm cho mình một một chiếc áo dài tay ấm áp. Coolmate hiểu được điều đó và đã nghiên cứu để gửi đến bạn một chiếc áo Sweatshirt với thiết kế vừa vặn, vô cùng thoải mái với chất liệu đặc biệt mềm mại. Và đó chính là áo nam Casual Sweatshirt - hoàn hảo cho những ngày thoải mái ở nhà, nhưng đủ tự tin để dạo phố cùng bạn bè.", false, "Áo Thun Tay Dài D004", 199000, "Áo thun tay dài", true },
                    { 3, "Rất nhiều thời gian và công sức để nghiên cứu và phát triển một sản phẩm, thay vì những vải lót bông bình thường dễ bị xù hoặc rụng bông nhỏ trong quá trình giặt và sử dụng, Coolmate lựa chọn chất liệu là 90% Cotton giúp chiếc áo của bạn vẫn thoát mồ hôi mà không hề gây bí, khó chịu; kết hợp với 10% Polyester giúp áo không nhăn và luôn bền dù có giặt, sấy bằng máy.", false, "Áo Thun Tay Dài D003", 230000, "Áo thun tay dài", true },
                    { 2, "Bạn có đang tìm kiếm cho mình một một chiếc áo dài tay ấm áp. Coolmate hiểu được điều đó và đã nghiên cứu để gửi đến bạn một chiếc áo Sweatshirt với thiết kế vừa vặn, vô cùng thoải mái với chất liệu đặc biệt mềm mại. Và đó chính là áo nam Casual Sweatshirt - hoàn hảo cho những ngày thoải mái ở nhà, nhưng đủ tự tin để dạo phố cùng bạn bè.", false, "Áo Thun Tay Dài D002", 230000, "Áo thun tay dài", true },
                    { 12, "Rất nhiều thời gian và công sức để nghiên cứu và phát triển một sản phẩm, thay vì những vải lót bông bình thường dễ bị xù hoặc rụng bông nhỏ trong quá trình giặt và sử dụng, Coolmate lựa chọn chất liệu là 90% Cotton giúp chiếc áo của bạn vẫn thoát mồ hôi mà không hề gây bí, khó chịu; kết hợp với 10% Polyester giúp áo không nhăn và luôn bền dù có giặt, sấy bằng máy.", false, "Áo Thun Tay Dài D012", 199000, "Áo thun tay dài", true },
                    { 25, "Vẫn là những chiếc áo với chật liệu Cotton 100% USA đã làm siêu lòng bao nhiêu khách hàng với những ưu điểm đặc biệt. Coolmate hiểu rằng, bạn không chỉ mong muốn có những chiếc áo thun trơn mà thêm những chiếc áo mang nhiều màu sắc, thiết kế mới mẻ mà vẫn tinh tế và đa dụng. Vì vậy, T-Shirt Pocket Tee ra đời với điểm nhấn là một chiếc túi nhỏ thiết kế trước ngực cùng sự tinh chỉnh thêm một số chi tiết nhỏ khác chắc chắn sẽ làm bạn hài lòng.", false, "Áo Thun Tay Ngắn N006", 199000, "Áo thun tay ngắn", true },
                    { 19, "Bạn có đang tìm kiếm cho mình một một chiếc áo dài tay ấm áp. Coolmate hiểu được điều đó và đã nghiên cứu để gửi đến bạn một chiếc áo Sweatshirt với thiết kế vừa vặn, vô cùng thoải mái với chất liệu đặc biệt mềm mại. Và đó chính là áo nam Casual Sweatshirt - hoàn hảo cho những ngày thoải mái ở nhà, nhưng đủ tự tin để dạo phố cùng bạn bè.", false, "Áo Thun Tay Dài D019", 230000, "Áo thun tay dài", true },
                    { 27, "Vẫn là những chiếc áo với chật liệu Cotton 100% USA đã làm siêu lòng bao nhiêu khách hàng với những ưu điểm đặc biệt. Coolmate hiểu rằng, bạn không chỉ mong muốn có những chiếc áo thun trơn mà thêm những chiếc áo mang nhiều màu sắc, thiết kế mới mẻ mà vẫn tinh tế và đa dụng. Vì vậy, T-Shirt Pocket Tee ra đời với điểm nhấn là một chiếc túi nhỏ thiết kế trước ngực cùng sự tinh chỉnh thêm một số chi tiết nhỏ khác chắc chắn sẽ làm bạn hài lòng.", false, "Áo Thun Tay Ngắn N008", 199000, "Áo thun tay ngắn", true },
                    { 49, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu modal (gỗ sồi), sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo sơ mi Modal này có gì đặc biệt nhé!", false, "Áo Sơ Mi D011", 199000, "Áo sơ mi tay dài", true },
                    { 48, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu bamboo (vải tre) Ex-Soft này, sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo bamboo này có gì đặc biệt nhé!", false, "Áo Sơ Mi D010", 199000, "Áo sơ mi tay dài", true },
                    { 47, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu bamboo (vải tre) Ex-Soft này, sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo bamboo này có gì đặc biệt nhé!", false, "Áo Sơ Mi D009", 199000, "Áo sơ mi tay dài", true },
                    { 46, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu modal (gỗ sồi), sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo sơ mi Modal này có gì đặc biệt nhé!", false, "Áo Sơ Mi D008", 199000, "Áo sơ mi tay dài", true },
                    { 26, "Vẫn là những chiếc áo với chật liệu Cotton 100% USA đã làm siêu lòng bao nhiêu khách hàng với những ưu điểm đặc biệt. Coolmate hiểu rằng, bạn không chỉ mong muốn có những chiếc áo thun trơn mà thêm những chiếc áo mang nhiều màu sắc, thiết kế mới mẻ mà vẫn tinh tế và đa dụng. Vì vậy, T-Shirt Pocket Tee ra đời với điểm nhấn là một chiếc túi nhỏ thiết kế trước ngực cùng sự tinh chỉnh thêm một số chi tiết nhỏ khác chắc chắn sẽ làm bạn hài lòng.", false, "Áo Thun Tay Ngắn N007", 230000, "Áo thun tay ngắn", true },
                    { 44, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu bamboo (vải tre) Ex-Soft này, sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo bamboo này có gì đặc biệt nhé!", false, "Áo Sơ Mi D006", 230000, "Áo sơ mi tay dài", true },
                    { 43, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu bamboo (vải tre) Ex-Soft này, sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo bamboo này có gì đặc biệt nhé!", false, "Áo Sơ Mi D005", 199000, "Áo sơ mi tay dài", true },
                    { 42, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu bamboo (vải tre) Ex-Soft này, sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo bamboo này có gì đặc biệt nhé!", false, "Áo Sơ Mi D004", 230000, "Áo sơ mi tay dài", true },
                    { 41, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu modal (gỗ sồi), sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo sơ mi Modal này có gì đặc biệt nhé!", false, "Áo Sơ Mi D003", 230000, "Áo sơ mi tay dài", true },
                    { 40, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu bamboo (vải tre) Ex-Soft này, sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo bamboo này có gì đặc biệt nhé!", false, "Áo Sơ Mi D002", 230000, "Áo sơ mi tay dài", true },
                    { 39, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu modal (gỗ sồi), sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo sơ mi Modal này có gì đặc biệt nhé!", false, "Áo Sơ Mi D001", 199000, "Áo sơ mi tay dài", true },
                    { 45, "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu modal (gỗ sồi), sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo sơ mi Modal này có gì đặc biệt nhé!", false, "Áo Sơ Mi D007", 199000, "Áo sơ mi tay dài", true },
                    { 37, "Vẫn là những chiếc áo với chật liệu Cotton 100% USA đã làm siêu lòng bao nhiêu khách hàng với những ưu điểm đặc biệt. Coolmate hiểu rằng, bạn không chỉ mong muốn có những chiếc áo thun trơn mà thêm những chiếc áo mang nhiều màu sắc, thiết kế mới mẻ mà vẫn tinh tế và đa dụng. Vì vậy, T-Shirt Pocket Tee ra đời với điểm nhấn là một chiếc túi nhỏ thiết kế trước ngực cùng sự tinh chỉnh thêm một số chi tiết nhỏ khác chắc chắn sẽ làm bạn hài lòng.", false, "Áo Thun Tay Ngắn N018", 230000, "Áo thun tay ngắn", true },
                    { 38, "Vẫn là những chiếc áo với chật liệu Cotton 100% USA đã làm siêu lòng bao nhiêu khách hàng với những ưu điểm đặc biệt. Coolmate hiểu rằng, bạn không chỉ mong muốn có những chiếc áo thun trơn mà thêm những chiếc áo mang nhiều màu sắc, thiết kế mới mẻ mà vẫn tinh tế và đa dụng. Vì vậy, T-Shirt Pocket Tee ra đời với điểm nhấn là một chiếc túi nhỏ thiết kế trước ngực cùng sự tinh chỉnh thêm một số chi tiết nhỏ khác chắc chắn sẽ làm bạn hài lòng.", false, "Áo Thun Tay Ngắn N019", 199000, "Áo thun tay ngắn", true },
                    { 28, "T-Shirt Cotton Compact Premium là sản phẩm áo thun hoàn toàn mới với nhiều sự cải tiến đã được nghiên cứu kỹ lưỡng và phát triển với chất liệu Cotton Compact cao cấp. Một chiếc áo nên có trong tủ đồ với sự đa dụng dùng được trong mọi hoàn cảnh: đi làm, đi chơi, cafe hay cả những buổi gặp mặt lịch sự thì T-Shirt Coolmate chắc chắn sẽ làm bạn trên cả sự hài lòng. Đơn giản nhưng cực nam tính, đơn điệu mà vẫn thời thượng", false, "Áo Thun Tay Ngắn N009", 199000, "Áo thun tay ngắn", true },
                    { 29, "Vẫn là những chiếc áo với chật liệu Cotton 100% USA đã làm siêu lòng bao nhiêu khách hàng với những ưu điểm đặc biệt. Coolmate hiểu rằng, bạn không chỉ mong muốn có những chiếc áo thun trơn mà thêm những chiếc áo mang nhiều màu sắc, thiết kế mới mẻ mà vẫn tinh tế và đa dụng. Vì vậy, T-Shirt Pocket Tee ra đời với điểm nhấn là một chiếc túi nhỏ thiết kế trước ngực cùng sự tinh chỉnh thêm một số chi tiết nhỏ khác chắc chắn sẽ làm bạn hài lòng.", false, "Áo Thun Tay Ngắn N010", 199000, "Áo thun tay ngắn", true },
                    { 31, "Vẫn là những chiếc áo với chật liệu Cotton 100% USA đã làm siêu lòng bao nhiêu khách hàng với những ưu điểm đặc biệt. Coolmate hiểu rằng, bạn không chỉ mong muốn có những chiếc áo thun trơn mà thêm những chiếc áo mang nhiều màu sắc, thiết kế mới mẻ mà vẫn tinh tế và đa dụng. Vì vậy, T-Shirt Pocket Tee ra đời với điểm nhấn là một chiếc túi nhỏ thiết kế trước ngực cùng sự tinh chỉnh thêm một số chi tiết nhỏ khác chắc chắn sẽ làm bạn hài lòng.", false, "Áo Thun Tay Ngắn N012", 199000, "Áo thun tay ngắn", true },
                    { 32, "Vẫn là những chiếc áo với chật liệu Cotton 100% USA đã làm siêu lòng bao nhiêu khách hàng với những ưu điểm đặc biệt. Coolmate hiểu rằng, bạn không chỉ mong muốn có những chiếc áo thun trơn mà thêm những chiếc áo mang nhiều màu sắc, thiết kế mới mẻ mà vẫn tinh tế và đa dụng. Vì vậy, T-Shirt Pocket Tee ra đời với điểm nhấn là một chiếc túi nhỏ thiết kế trước ngực cùng sự tinh chỉnh thêm một số chi tiết nhỏ khác chắc chắn sẽ làm bạn hài lòng.", false, "Áo Thun Tay Ngắn N013", 230000, "Áo thun tay ngắn", true },
                    { 30, "Vẫn là những chiếc áo với chật liệu Cotton 100% USA đã làm siêu lòng bao nhiêu khách hàng với những ưu điểm đặc biệt. Coolmate hiểu rằng, bạn không chỉ mong muốn có những chiếc áo thun trơn mà thêm những chiếc áo mang nhiều màu sắc, thiết kế mới mẻ mà vẫn tinh tế và đa dụng. Vì vậy, T-Shirt Pocket Tee ra đời với điểm nhấn là một chiếc túi nhỏ thiết kế trước ngực cùng sự tinh chỉnh thêm một số chi tiết nhỏ khác chắc chắn sẽ làm bạn hài lòng.", false, "Áo Thun Tay Ngắn N011", 230000, "Áo thun tay ngắn", true },
                    { 33, "T-Shirt Cotton Compact Premium là sản phẩm áo thun hoàn toàn mới với nhiều sự cải tiến đã được nghiên cứu kỹ lưỡng và phát triển với chất liệu Cotton Compact cao cấp. Một chiếc áo nên có trong tủ đồ với sự đa dụng dùng được trong mọi hoàn cảnh: đi làm, đi chơi, cafe hay cả những buổi gặp mặt lịch sự thì T-Shirt Coolmate chắc chắn sẽ làm bạn trên cả sự hài lòng. Đơn giản nhưng cực nam tính, đơn điệu mà vẫn thời thượng", false, "Áo Thun Tay Ngắn N014", 199000, "Áo thun tay ngắn", true },
                    { 34, "Vẫn là những chiếc áo với chật liệu Cotton 100% USA đã làm siêu lòng bao nhiêu khách hàng với những ưu điểm đặc biệt. Coolmate hiểu rằng, bạn không chỉ mong muốn có những chiếc áo thun trơn mà thêm những chiếc áo mang nhiều màu sắc, thiết kế mới mẻ mà vẫn tinh tế và đa dụng. Vì vậy, T-Shirt Pocket Tee ra đời với điểm nhấn là một chiếc túi nhỏ thiết kế trước ngực cùng sự tinh chỉnh thêm một số chi tiết nhỏ khác chắc chắn sẽ làm bạn hài lòng.", false, "Áo Thun Tay Ngắn N015", 230000, "Áo thun tay ngắn", true },
                    { 35, "T-Shirt Cotton Compact Premium là sản phẩm áo thun hoàn toàn mới với nhiều sự cải tiến đã được nghiên cứu kỹ lưỡng và phát triển với chất liệu Cotton Compact cao cấp. Một chiếc áo nên có trong tủ đồ với sự đa dụng dùng được trong mọi hoàn cảnh: đi làm, đi chơi, cafe hay cả những buổi gặp mặt lịch sự thì T-Shirt Coolmate chắc chắn sẽ làm bạn trên cả sự hài lòng. Đơn giản nhưng cực nam tính, đơn điệu mà vẫn thời thượng", false, "Áo Thun Tay Ngắn N016", 230000, "Áo thun tay ngắn", true },
                    { 36, "Vẫn là những chiếc áo với chật liệu Cotton 100% USA đã làm siêu lòng bao nhiêu khách hàng với những ưu điểm đặc biệt. Coolmate hiểu rằng, bạn không chỉ mong muốn có những chiếc áo thun trơn mà thêm những chiếc áo mang nhiều màu sắc, thiết kế mới mẻ mà vẫn tinh tế và đa dụng. Vì vậy, T-Shirt Pocket Tee ra đời với điểm nhấn là một chiếc túi nhỏ thiết kế trước ngực cùng sự tinh chỉnh thêm một số chi tiết nhỏ khác chắc chắn sẽ làm bạn hài lòng.", false, "Áo Thun Tay Ngắn N017", 199000, "Áo thun tay ngắn", true }
                });

            migrationBuilder.InsertData(
                table: "Tag",
                columns: new[] { "ID", "IsDelete", "Name" },
                values: new object[,]
                {
                    { 9, false, "Ao So Mi Tay Ngan" },
                    { 13, false, "Thoi Trang Teen" },
                    { 12, false, "Thoi Trang Nang Dong" },
                    { 11, false, "Thoi Trang Tre" },
                    { 10, false, "Ao So Mi Tay Dai" },
                    { 14, false, "Thoi Trang Cong So" },
                    { 8, false, "Ao So Mi Cong So" },
                    { 3, false, "San Pham Duoc Ua Thich" },
                    { 6, false, "Ao Thun Cotton" },
                    { 5, false, "Ao Thun Hien Dai" },
                    { 4, false, "Ao Thun Thoi Trang" },
                    { 2, false, "San Pham Ban Chay" },
                    { 1, false, "San Pham Moi" },
                    { 15, false, "Quan Di Choi" },
                    { 7, false, "Ao So Mi Cotton" },
                    { 16, false, "Quan Cong So" }
                });

            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "ID", "IsDelete", "Name", "ProductId", "URL" },
                values: new object[,]
                {
                    { 1, false, "Ảnh minh hoạ D001", 1, "1_1_D001.jpg" },
                    { 94, false, "Ảnh minh hoạ N011", 60, "60_1_N011.jpg" },
                    { 95, false, "Ảnh minh hoạ N012", 61, "61_1_N012.jpg" },
                    { 96, false, "Ảnh minh hoạ N013", 62, "62_1_N013.jpg" },
                    { 97, false, "Ảnh minh hoạ QD001", 63, "63_1_QD001.jpg" },
                    { 98, false, "Ảnh minh hoạ QD001", 63, "63_2_QD001.jpg" },
                    { 99, false, "Ảnh minh hoạ QD001", 63, "63_3_QD001.jpg" },
                    { 100, false, "Ảnh minh hoạ QD002", 64, "64_1_QD002.jpg" },
                    { 101, false, "Ảnh minh hoạ QD002", 64, "64_2_QD002.jpg" },
                    { 102, false, "Ảnh minh hoạ QD002", 64, "64_3_QD002.jpg" },
                    { 103, false, "Ảnh minh hoạ QD003", 65, "65_1_QD003.jpg" },
                    { 104, false, "Ảnh minh hoạ QD003", 65, "65_2_QD003.jpg" },
                    { 105, false, "Ảnh minh hoạ QD004", 66, "66_1_QD004.jpg" },
                    { 106, false, "Ảnh minh hoạ QD005", 67, "67_1_QD005.jpg" },
                    { 107, false, "Ảnh minh hoạ QD006", 68, "68_1_QD006.jpg" },
                    { 108, false, "Ảnh minh hoạ QD007", 69, "69_1_QD007.jpg" },
                    { 93, false, "Ảnh minh hoạ N010", 59, "59_1_N010.jpg" },
                    { 109, false, "Ảnh minh hoạ QD008", 70, "70_1_QD008.jpg" },
                    { 92, false, "Ảnh minh hoạ N009", 58, "58_1_N009.jpg" },
                    { 90, false, "Ảnh minh hoạ N007", 56, "56_1_N007.jpg" },
                    { 75, false, "Ảnh minh hoạ D011", 49, "49_1_D011.jpg" },
                    { 76, false, "Ảnh minh hoạ N001", 50, "50_1_N001.jpg" },
                    { 77, false, "Ảnh minh hoạ N001", 50, "50_2_N001.jpg" },
                    { 78, false, "Ảnh minh hoạ N001", 50, "50_3_N001.jpg" },
                    { 79, false, "Ảnh minh hoạ N001", 50, "50_4_N001.jpg" },
                    { 80, false, "Ảnh minh hoạ N002", 51, "51_1_N002.jpg" },
                    { 81, false, "Ảnh minh hoạ N002", 51, "51_2_N002.jpg" },
                    { 82, false, "Ảnh minh hoạ N002", 51, "51_3_N002.jpg" },
                    { 83, false, "Ảnh minh hoạ N002", 51, "51_4_N002.jpg" },
                    { 84, false, "Ảnh minh hoạ N003", 52, "52_1_N003.jpg" },
                    { 85, false, "Ảnh minh hoạ N003", 52, "52_2_N003.jpg" },
                    { 86, false, "Ảnh minh hoạ N003", 52, "52_3_N003.jpg" },
                    { 87, false, "Ảnh minh hoạ N004", 53, "53_1_N004.jpg" },
                    { 88, false, "Ảnh minh hoạ N005", 54, "54_1_N005.jpg" },
                    { 89, false, "Ảnh minh hoạ N006", 55, "55_1_N006.jpg" },
                    { 91, false, "Ảnh minh hoạ N008", 57, "57_1_N008.jpg" },
                    { 110, false, "Ảnh minh hoạ QD009", 71, "71_1_QD009.jpg" },
                    { 111, false, "Ảnh minh hoạ QD010", 72, "72_1_QD010.jpg" },
                    { 112, false, "Ảnh minh hoạ QD011", 73, "73_1_QD011.jpg" },
                    { 133, false, "Ảnh minh hoạ QN004", 86, "86_2_QN004.jpg" },
                    { 134, false, "Ảnh minh hoạ QN005", 87, "87_1_QN005.jpg" },
                    { 135, false, "Ảnh minh hoạ QN006", 88, "88_1_QN006.jpg" },
                    { 136, false, "Ảnh minh hoạ QN007", 89, "89_1_QN007.jpg" },
                    { 137, false, "Ảnh minh hoạ QN008", 90, "90_1_QN008.jpg" },
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
                    { 132, false, "Ảnh minh hoạ QN004", 86, "86_1_QN004.jpg" },
                    { 131, false, "Ảnh minh hoạ QN003", 85, "85_3_QN003.jpg" },
                    { 130, false, "Ảnh minh hoạ QN003", 85, "85_2_QN003.jpg" },
                    { 129, false, "Ảnh minh hoạ QN003", 85, "85_1_QN003.jpg" },
                    { 113, false, "Ảnh minh hoạ QD012", 74, "74_1_QD012.jpg" },
                    { 114, false, "Ảnh minh hoạ QD013", 75, "75_1_QD013.jpg" },
                    { 115, false, "Ảnh minh hoạ QD014", 76, "76_1_QD014.jpg" },
                    { 116, false, "Ảnh minh hoạ QD015", 77, "77_1_QD015.jpg" },
                    { 117, false, "Ảnh minh hoạ QD016", 78, "78_1_QD016.jpg" },
                    { 118, false, "Ảnh minh hoạ QD017", 79, "79_1_QD017.jpg" },
                    { 119, false, "Ảnh minh hoạ QD018", 80, "80_1_QD018.jpg" },
                    { 74, false, "Ảnh minh hoạ D010", 48, "48_1_D010.jpg" },
                    { 120, false, "Ảnh minh hoạ QD019", 81, "81_1_QD019.jpg" },
                    { 122, false, "Ảnh minh hoạ QN001", 83, "83_1_QN001.jpg" },
                    { 123, false, "Ảnh minh hoạ QN001", 83, "83_2_QN001.jpg" },
                    { 124, false, "Ảnh minh hoạ QN001", 83, "83_3_QN001.jpg" },
                    { 125, false, "Ảnh minh hoạ QN001", 83, "83_4_QN001.jpg" },
                    { 126, false, "Ảnh minh hoạ QN002", 84, "84_1_QN002.jpg" },
                    { 127, false, "Ảnh minh hoạ QN002", 84, "84_2_QN002.jpg" },
                    { 128, false, "Ảnh minh hoạ QN002", 84, "84_3_QN002.jpg" },
                    { 121, false, "Ảnh minh hoạ QD020", 82, "82_1_QD020.jpg" },
                    { 73, false, "Ảnh minh hoạ D009", 47, "47_1_D009.jpg" },
                    { 72, false, "Ảnh minh hoạ D008", 46, "46_1_D008.jpg" },
                    { 71, false, "Ảnh minh hoạ D007", 45, "45_1_D007.jpg" },
                    { 20, false, "Ảnh minh hoạ D008", 8, "8_2_D008.jpg" },
                    { 21, false, "Ảnh minh hoạ D008", 8, "8_3_D008.jpg" },
                    { 22, false, "Ảnh minh hoạ D009", 9, "9_1_D009.jpg" },
                    { 23, false, "Ảnh minh hoạ D009", 9, "9_2_D009.jpg" },
                    { 24, false, "Ảnh minh hoạ D010", 10, "10_1_D010.jpg" },
                    { 25, false, "Ảnh minh hoạ D011", 11, "11_1_D011.jpg" },
                    { 19, false, "Ảnh minh hoạ D008", 8, "8_1_D008.jpg" },
                    { 26, false, "Ảnh minh hoạ D012", 12, "12_1_D012.jpg" },
                    { 28, false, "Ảnh minh hoạ D014", 14, "14_1_D014.jpg" },
                    { 29, false, "Ảnh minh hoạ D015", 15, "15_1_D015.jpg" },
                    { 30, false, "Ảnh minh hoạ D016", 16, "16_1_D016.jpg" },
                    { 31, false, "Ảnh minh hoạ D017", 17, "17_1_D017.jpg" },
                    { 148, false, "Ảnh minh hoạ QN019", 101, "101_1_QN019.jpg" },
                    { 33, false, "Ảnh minh hoạ D019", 19, "19_1_D019.jpg" },
                    { 27, false, "Ảnh minh hoạ D013", 13, "13_1_D013.jpg" },
                    { 34, false, "Ảnh minh hoạ N001", 20, "20_1_N001.jpg" },
                    { 18, false, "Ảnh minh hoạ D007", 7, "7_2_D007.jpg" },
                    { 16, false, "Ảnh minh hoạ D006", 6, "6_3_D006.jpg" },
                    { 2, false, "Ảnh minh hoạ D001", 1, "1_2_D001.jpg" },
                    { 3, false, "Ảnh minh hoạ D001", 1, "1_3_D001.jpg" },
                    { 4, false, "Ảnh minh hoạ D001", 1, "1_4_D001.jpg" },
                    { 5, false, "Ảnh minh hoạ D002", 2, "2_1_D002.jpg" },
                    { 6, false, "Ảnh minh hoạ D002", 2, "2_2_D002.jpg" },
                    { 7, false, "Ảnh minh hoạ D003", 3, "3_1_D003.jpg" },
                    { 17, false, "Ảnh minh hoạ D007", 7, "7_1_D007.jpg" },
                    { 8, false, "Ảnh minh hoạ D003", 3, "3_2_D003.jpg" },
                    { 10, false, "Ảnh minh hoạ D004", 4, "4_2_D004.jpg" },
                    { 11, false, "Ảnh minh hoạ D005", 5, "5_1_D005.jpg" },
                    { 12, false, "Ảnh minh hoạ D005", 5, "5_2_D005.jpg" },
                    { 13, false, "Ảnh minh hoạ D005", 5, "5_3_D005.jpg" },
                    { 14, false, "Ảnh minh hoạ D006", 6, "6_1_D006.jpg" },
                    { 15, false, "Ảnh minh hoạ D006", 6, "6_2_D006.jpg" },
                    { 9, false, "Ảnh minh hoạ D004", 4, "4_1_D004.jpg" },
                    { 35, false, "Ảnh minh hoạ N001", 20, "20_2_N001.jpg" },
                    { 32, false, "Ảnh minh hoạ D018", 18, "18_1_D018.jpg" },
                    { 37, false, "Ảnh minh hoạ N002", 21, "21_1_N002.jpg" },
                    { 57, false, "Ảnh minh hoạ N018", 37, "37_1_N018.jpg" },
                    { 36, false, "Ảnh minh hoạ N001", 20, "20_3_N001.jpg" },
                    { 59, false, "Ảnh minh hoạ D001", 39, "39_1_D001.jpg" },
                    { 60, false, "Ảnh minh hoạ D001", 39, "39_2_D001.jpg" },
                    { 61, false, "Ảnh minh hoạ D002", 40, "40_1_D002.jpg" },
                    { 62, false, "Ảnh minh hoạ D002", 40, "40_2_D002.jpg" },
                    { 56, false, "Ảnh minh hoạ N017", 36, "36_1_N017.jpg" },
                    { 63, false, "Ảnh minh hoạ D002", 40, "40_3_D002.jpg" },
                    { 65, false, "Ảnh minh hoạ D003", 41, "41_1_D003.jpg" },
                    { 66, false, "Ảnh minh hoạ D003", 41, "41_2_D003.jpg" },
                    { 67, false, "Ảnh minh hoạ D004", 42, "42_1_D004.jpg" },
                    { 68, false, "Ảnh minh hoạ D004", 42, "42_2_D004.jpg" },
                    { 69, false, "Ảnh minh hoạ D005", 43, "43_1_D005.jpg" },
                    { 70, false, "Ảnh minh hoạ D006", 44, "44_1_D006.jpg" },
                    { 64, false, "Ảnh minh hoạ D002", 40, "40_4_D002.jpg" },
                    { 55, false, "Ảnh minh hoạ N016", 35, "35_1_N016.jpg" },
                    { 58, false, "Ảnh minh hoạ N019", 38, "38_1_N019.jpg" },
                    { 53, false, "Ảnh minh hoạ N014", 33, "33_1_N014.jpg" },
                    { 38, false, "Ảnh minh hoạ N002", 21, "21_2_N002.jpg" },
                    { 39, false, "Ảnh minh hoạ N003", 22, "22_1_N003.jpg" },
                    { 41, false, "Ảnh minh hoạ N003", 22, "22_2_N003.jpg" },
                    { 54, false, "Ảnh minh hoạ N015", 34, "34_1_N015.jpg" },
                    { 43, false, "Ảnh minh hoạ N004", 23, "23_1_N004.jpg" },
                    { 44, false, "Ảnh minh hoạ N005", 24, "24_1_N005.jpg" },
                    { 45, false, "Ảnh minh hoạ N006", 25, "25_1_N006.jpg" },
                    { 42, false, "Ảnh minh hoạ N003", 22, "22_3_N003.jpg" },
                    { 47, false, "Ảnh minh hoạ N008", 27, "27_1_N008.jpg" },
                    { 48, false, "Ảnh minh hoạ N009", 28, "28_1_N009.jpg" },
                    { 49, false, "Ảnh minh hoạ N010", 29, "29_1_N010.jpg" },
                    { 50, false, "Ảnh minh hoạ N011", 30, "30_1_N011.jpg" },
                    { 51, false, "Ảnh minh hoạ N012", 31, "31_1_N012.jpg" },
                    { 52, false, "Ảnh minh hoạ N013", 32, "32_1_N013.jpg" },
                    { 46, false, "Ảnh minh hoạ N007", 26, "26_1_N007.jpg" },
                    { 149, false, "Ảnh minh hoạ QN020", 102, "102_1_QN020.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Warehouse",
                columns: new[] { "ID", "Color", "LastUpdate", "ProductID", "Quantity", "Size", "Sold" },
                values: new object[,]
                {
                    { 6, "Trắng", new DateTime(2021, 12, 19, 17, 14, 24, 721, DateTimeKind.Local).AddTicks(5960), 1, 100, "XL", 0 },
                    { 5, "Xanh", new DateTime(2021, 12, 19, 17, 14, 24, 721, DateTimeKind.Local).AddTicks(5960), 1, 100, "XL", 0 },
                    { 4, "Trắng", new DateTime(2021, 12, 19, 17, 14, 24, 721, DateTimeKind.Local).AddTicks(5960), 1, 100, "L", 0 },
                    { 3, "Xanh", new DateTime(2021, 12, 19, 17, 14, 24, 721, DateTimeKind.Local).AddTicks(5950), 1, 100, "L", 0 },
                    { 2, "Trắng", new DateTime(2021, 12, 19, 17, 14, 24, 721, DateTimeKind.Local).AddTicks(5910), 1, 100, "M", 0 },
                    { 1, "Xanh", new DateTime(2021, 12, 19, 17, 14, 24, 706, DateTimeKind.Local).AddTicks(7230), 1, 100, "M", 0 }
                });

            migrationBuilder.Sql(
                "INSERT INTO Product ([Name], [Description], [Price], [Visible], [IsDelete], [ProductType]) VALUES (N'Áo so mi 1', N'đây là mô tả á', 149000, 1, 0, N'Áo thun tay dài') INSERT [dbo].[Product] ([Name], [Description], [Price], [Visible], [IsDelete], [ProductType]) VALUES (N'Áo so mi 2', N'đây là mô tả á', 159000, 1, 0, N'Áo thun tay dài')"
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
