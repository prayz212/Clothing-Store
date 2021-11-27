using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clothing_Store.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập tên sản phẩm")]
        [Column(TypeName = "NVARCHAR(MAX)")]
        [StringLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập mô tả")]
        [Column(TypeName = "NVARCHAR(MAX)")]
        [StringLength(255)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập giá")]
        [Range(1, 10000000, ErrorMessage = "Giá sản phẩm phải nằm trong khoảng từ 1 đến 10000000")]
        public int Price { get; set; }

        public ICollection<Rating> ratings { get; set; }

        public ICollection<Image> images { get; set; }

        public ICollection<Warehouse> warehouses { get; set; }

        public bool Visible { get; set; } = true;

        public bool IsDelete { get; set; } = false;
    }
}
