using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clothing_Store.Models
{
    [Table("CartDetails")]
    public class CartDetails
    {
        public int accountID { get; set; }
        public int productID { get; set; }

        [Range(1, Int32.MaxValue, ErrorMessage = "Số lượng bắt đầu từ 0 đến 2.147.483.647")]
        public int Quantity { get; set; }
        public Account account { get; set; }
        public Product product { get; set; }
        public bool Visible { get; set; } = true;
        public bool IsDelete { get; set; } = false;
        public bool IsSelected { get; set; } = false;
    }
}
