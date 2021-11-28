using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clothing_Store.Models
{
    [Table("Promotion")]
    public class Promotion
    {
        [Key]
        public int ID { get; set; }

        [Column(TypeName = "NVARCHAR(MAX)")]
        [StringLength(100)]
        public string Name { get; set; }

        [Column(TypeName = "NVARCHAR(MAX)")]
        [StringLength(255)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập phần trăm giảm giá")]
        [Range(1, 100, ErrorMessage = "Phần trăm giảm giá phải nằm trong khoảng từ 1 đến 100")]
        public int Discount { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime From { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime To { get; set; }

        public int ProductID { get; set; }

        public Product product { get; set; }

        public bool Visible { get; set; } = true;

        public bool IsDelete { get; set; } = false;
    }
}
