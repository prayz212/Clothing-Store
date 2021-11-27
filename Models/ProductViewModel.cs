using System;
using System.Collections.Generic;

namespace Clothing_Store.Models
{
    public class ProductViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int ratings { get; set; }
        public Image image { get; set; }
    }
}
