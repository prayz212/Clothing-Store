using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Clothing_Store.Models;

namespace Clothing_Store.Areas.Admin.Models
{
    public class AdminProductViewModel : BaseModel
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

    public class AdminProductDetailViewModel : BaseModel
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

    public class AdminStockInViewModel : BaseModel
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
