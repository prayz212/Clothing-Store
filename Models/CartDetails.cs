using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clothing_Store.Models
{
    [Table("CartDetails")]
    public class CartDetails
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(10)]
        public string Size { get; set; }

        [Required]
        [Column(TypeName = "NVARCHAR(MAX)")]
        [StringLength(50)]
        public string Color { get; set; }

        [Required]
        public int Quantity { get; set; }

        public bool IsDelete { get; set; } = false;
        public bool IsSelected { get; set; } = false;

        public int accountID { get; set; }
        public int productID { get; set; }
        public Account account { get; set; }
        public Product product { get; set; }
    }
}
