using System.Collections.Generic;
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
}
