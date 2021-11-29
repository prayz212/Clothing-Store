using System;
using System.Collections.Generic;

namespace Clothing_Store.Models
{
    public class ProductDetailViewModel
    {
        public Product detail { get; set; }
        public ICollection<ProductViewModel> ralativeProducts { get; set; }
    }
}
