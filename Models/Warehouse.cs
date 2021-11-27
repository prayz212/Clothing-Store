using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clothing_Store.Models
{
    [Table("Warehouse")]
    public class Warehouse
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập kích thước sản phẩm")]
        [StringLength(10)]
        public string Size { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập màu sắc sản phẩm")]
        [Column(TypeName = "NVARCHAR(MAX)")]
        [StringLength(50)]
        public string Color { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập số lượng sản phẩm")]
        [Range(1, 10000, ErrorMessage = "Số lượng sản phẩm phải nằm trong khoảng từ 1 đến 10000")]
        public int Quantity { get; set; }

        public int Sold { get; set; } = 0;

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime LastUpdate { get; set; }

        public Product product { get; set; }
    }
}
