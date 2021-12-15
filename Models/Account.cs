using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clothing_Store.Models
{
    [Table("Account")]
    public class Account
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập tên tài khoản")]
        [StringLength(100)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập mật khẩu")]
        [StringLength(255)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập email")]
        [StringLength(255)]
        public string Email { get; set; }
        public bool IsDelete { get; set; } = false;

        public Customer customer { get; set; }
        public ICollection<Receipt> receipts { get; set; }
    }
}
