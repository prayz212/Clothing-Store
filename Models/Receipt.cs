using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clothing_Store.Models
{
    [Table("Receipt")]
    public class Receipt
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Column(TypeName = "NVARCHAR(MAX)")]
        [StringLength(255)]
        public string Fullname { get; set; }

        [Required]
        [StringLength(10)]
        public string Phone { get; set; }

        [Required]
        [StringLength(255)]
        public string Email { get; set; }

        [Required]
        [Column(TypeName = "NVARCHAR(MAX)")]
        [StringLength(255)]
        public string Address { get; set; }

        [Column(TypeName = "NVARCHAR(MAX)")]
        [StringLength(255)]
        public string Notes { get; set; }

        [Required]
        public int TotalPrice { get; set; }

        [Required]
        public int TotalDiscount { get; set; } = 0;

        [Required]
        public int ShippingCost { get; set; } = 0;

        [Required]
        public int TotalPay { get; set; }

        [Column(TypeName = "NVARCHAR(MAX)")]
        [StringLength(255)]
        public string Method { get; set; } = "COD";

        [Column(TypeName = "NVARCHAR(MAX)")]
        [StringLength(255)]
        public string Status { get; set; } = "Đang xử lý";

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime OrderAt { get; set; } = DateTime.Now;

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DeliveryAt { get; set; }

        [StringLength(12)]
        public string CardNumber { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ValidDate { get; set; }

        [StringLength(7)]
        public string SecretNumber { get; set; }

        [Required]
        public int accountID { get; set; }
        public Account account { get; set; }
    }
}
