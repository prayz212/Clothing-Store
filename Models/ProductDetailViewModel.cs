using System;
using System.Collections.Generic;

namespace Clothing_Store.Models
{
    public class ProductDetailViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public int Ratings { get; set; }
        public int Sold { get; set; }
        public int Discount { get; set; }
        public ICollection<string> Colors { get; set; }
        public ICollection<string> Sizes { get; set; }
        public ICollection<Image> Images { get; set; }
    }
}
