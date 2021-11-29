using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clothing_Store.Models
{
    [Table("ProductTag")]
    public class ProductTag
    {
        public int ProductID { get; set; }
        public int TagID { get; set; }

        public Product product { get; set; }
        public Tag tag { get; set; }
    }
}
