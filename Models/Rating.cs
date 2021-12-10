using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clothing_Store.Models
{
    [Table("Rating")]
    public class Rating
    {
        [Key]
        public int ID { get; set; }

        [Range(1, 5, ErrorMessage = "Số sao phải nằm trong khoảng từ 1 đến 5")]
        public int Star { get; set; }

        public Product product { get; set; }

        public Account account { get; set; }

        public bool IsDelete { get; set; } = false;
    }
}
