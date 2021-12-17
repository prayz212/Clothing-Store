using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Clothing_Store.Models
{

    [Table("Admin")]
    public class Admin
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
        public int AccountID { get; set; }

        public Account account { get; set; }
    }
}
