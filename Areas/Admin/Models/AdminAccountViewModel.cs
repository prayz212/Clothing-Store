using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clothing_Store.Areas.Admin.Models
{
    public class AdminAccountViewModel : BaseModel
    {
        public List<AdminAccountModel> accounts { get; set; }
    }

    public class AdminAccountModel
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string CardNumber { get; set; }
        public DateTime ValiDate { get; set; }
        public int TotalOrder { get; set; }
        public int TotalPayment { get; set; }
    }

    public class AdminAccountDetailsViewModel : BaseModel
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string CardNumber { get; set; }
        public DateTime ValiDate { get; set; }
        public string SecretNumber { get; set; }
        public int TotalOrder { get; set; }
        public int TotalPayment { get; set; }
        public List<AdminReceiptHistoryModel> Recepits { get; set; }
    }

    public class AdminUpdateAcccountViewModel : BaseModel
    {
        public AdminAccountDetailsViewModel details { get; set; }
        public UpdateModel updateModel { get; set; }
    }

    public class UpdateModel
    {
        [Required(ErrorMessage = "Yêu cầu nhập họ và tên")]
        public string Fullname { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập email")]
        [StringLength(255)]
        [EmailAddress(ErrorMessage = "Địa chỉ email không hợp lệ")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập số điện thoại")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Số điện thoại không hợp lệ")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập địa chỉ")]
        public string Address { get; set; }

        [StringLength(12, MinimumLength = 12, ErrorMessage = "Số thẻ phải bao gồm 12 số")]
        [MaxLength(12, ErrorMessage = "Số thẻ phải có tối đa 12 số")]
        public string? CardNumber { get; set; }

        public DateTime? ValidDate { get; set; }

        [StringLength(12, MinimumLength = 7, ErrorMessage = "Mã số bí mật phải bao gồm 7 số")]
        [MaxLength(7, ErrorMessage = "Mã số bí mật có tối đa 7 số")]
        public string? SecretNumber { get; set; }
    }

    public class CreateModel : BaseModel
    {
        [Required(ErrorMessage = "Yêu cầu nhập tên tài khoản")]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "Tên tài khoản phải có tối thiểu 4 ký tự")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập mật khẩu")]
        [StringLength(255, MinimumLength = 8, ErrorMessage = "Mật khẩu phải có tối thiểu 8 ký tự")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Yêu cầu nhập họ và tên")]
        public string Fullname { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập email")]
        [StringLength(255)]
        [EmailAddress(ErrorMessage = "Địa chỉ email không hợp lệ")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập số điện thoại")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Số điện thoại không hợp lệ")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập địa chỉ")]
        public string Address { get; set; }

        [StringLength(12, MinimumLength = 12, ErrorMessage = "Số thẻ phải bao gồm 12 số")]
        [MaxLength(12, ErrorMessage = "Số thẻ phải có tối đa 12 số")]
        public string CardNumber { get; set; }

        public DateTime? ValidDate { get; set; }

        [StringLength(12, MinimumLength = 7, ErrorMessage = "Mã số bí mật phải bao gồm 7 số")]
        [MaxLength(7, ErrorMessage = "Mã số bí mật có tối đa 7 số")]
        public string SecretNumber { get; set; }
    }
}
