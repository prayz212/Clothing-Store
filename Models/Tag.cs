using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clothing_Store.Models
{
    [Table("Tag")]
    public class Tag
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập tên thẻ")]
        [StringLength(100)]
        public string Name { get; set; }

        public bool IsDelete { get; set; } = false;
    }
}
