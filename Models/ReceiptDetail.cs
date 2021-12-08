using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clothing_Store.Models
{
    [Table("ReceipDetail")]
    public class ReceiptDetail
    {
        [Required]
        [StringLength(10)]
        public string Size { get; set; }

        [Required]
        [Column(TypeName = "NVARCHAR(MAX)")]
        [StringLength(50)]
        public string Color { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public int TotalPrice { get; set; }

        public int ProductID { get; set; }
        public int ReceiptID { get; set; }

        public Product product { get; set; }
        public Receipt receipt { get; set; }
    }
}
