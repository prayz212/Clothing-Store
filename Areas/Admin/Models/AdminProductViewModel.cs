using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Clothing_Store.Models;

namespace Clothing_Store.Areas.Admin.Models
{
    public class AdminProductViewModel
    {
        public List<AdminProductModel> products { get; set; }
    }

    public class AdminProductModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ProductType { get; set; }
        public int Price { get; set; }
        public int Discount { get; set; }
        public int Ratings { get; set; }
        public string Visible { get; set; }
    }

    public class AdminProductDetailViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ProductType { get; set; }
        public int Price { get; set; }
        public string InPromotion { get; set; }
        public int Discount { get; set; }
        public int TotalSold { get; set; }
        public int Ratings { get; set; }
        public string Visible { get; set; }
        public string Description { get; set; }

        public List<Image> images { get; set; }
        public List<Warehouse> warehouses { get; set; }
    }

    public class AdminCreateProductModel
    {
        [Required(ErrorMessage = "Yêu cầu nhập tên sản phẩm")]
        [MinLength(6, ErrorMessage = "Tên sản phẩm phải có tối thiểu 6 ký tự")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Yêu cầu chọn loại sản phẩm")]
        public string ProductType { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập giá sản phẩm")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Yêu cầu chọn tình trạng hiển thị")]
        public string Visible { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập mô tả sản phẩm")]
        [MinLength(50, ErrorMessage = "Mô tả sản phẩm phải có tối thiểu 50 ký tự")]
        public string Description { get; set; }

        public string image1 { get; set; }
        public string image2 { get; set; }
        public string image3 { get; set; }
        public string image4 { get; set; }
    }

    public class AdminCreateProductViewModel
    {
        public AdminCreateProductModel model { get; set; }
        public List<string> types { get; set; }
        public List<Tag> tags { get; set; }
    }
    
    public class AdminStockInViewModel
    {
        public int productID { get; set; }
        public List<Warehouse> warehouses { get; set; }
        public ValidateStockInForm validate { get; set; }
    }

    public class ValidateStockInForm
    {
        [Required(ErrorMessage = "Yêu cầu nhập size cho sản phẩm")]
        public string Size { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập màu sắc cho sản phẩm")]
        public string Color { get; set; }


        [Required(ErrorMessage = "Yêu cầu nhập số lượng cho sản phẩm")]
        public int Quantity { get; set; }
    }
}
