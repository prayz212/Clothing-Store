using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clothing_Store.Models
{
    [Table("Image")]
    public class Image
    {
        [Key]
        public int ID { get; set; }

        [StringLength(100)]
        [Column(TypeName = "NVARCHAR(MAX)")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập đường dẫn hình ảnh")]
        [StringLength(1000)]
        public string URL { get; set; }

        public Product product { get; set; }
        public int ProductId { get; set; }

        public bool IsDelete { get; set; } = false;
    }
}
