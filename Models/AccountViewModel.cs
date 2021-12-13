using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Clothing_Store.Models
{
    public class AccountViewModel
    {
        public RegisterModel register { get; set; }
        public LoginModel login { get; set; }

        public bool isError { get; set; }
    }

    public class RegisterModel
    {
        [Required(ErrorMessage = "Yêu cầu nhập tên tài khoản")]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "Tên tài khoản phải có tối thiểu 4 ký tự")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập mật khẩu")]
        [StringLength(255, MinimumLength = 8, ErrorMessage = "Mật khẩu phải có tối thiểu 8 ký tự")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập email")]
        [StringLength(255)]
        [EmailAddress(ErrorMessage = "Địa chỉ email không hợp lệ")]
        public string Email { get; set; }
    }

    public class LoginModel
    {
        [Required(ErrorMessage = "Yêu cầu nhập tên tài khoản")]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "Tên tài khoản phải có tối thiểu 4 ký tự")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập mật khẩu")]
        [StringLength(255, MinimumLength = 8, ErrorMessage = "Mật khẩu phải có tối thiểu 8 ký tự")]
        public string Password { get; set; }
    }

    public class ForgotPasswordModel
    {
        [Required(ErrorMessage = "Yêu cầu nhập email")]
        [StringLength(255, ErrorMessage = "Email tối đa 255 ký tự")]
        [EmailAddress(ErrorMessage = "Địa chỉ email không hợp lệ")]
        public string Email { get; set; }
    }

    public class ResetPasswordModel
    {

        [Required(ErrorMessage = "Thông tin không hợp lệ")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập mật khẩu")]
        [StringLength(255, MinimumLength = 8, ErrorMessage = "Mật khẩu phải có tối thiểu 8 ký tự")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập mật khẩu xác nhận")]
        [StringLength(255, MinimumLength = 8, ErrorMessage = "Mật khẩu xác nhận phải có tối thiểu 8 ký tự")]
        [Compare(nameof(Password), ErrorMessage = "Mật khẩu xác nhận không khớp")]
        public string ConfirmPassword { get; set; }
    }


    public class AccountInfoModel
    {
        public string Username { get; set; }

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

    public class ReceiptHistoryViewModel
    {
        public List<ReceiptHistoryModel> receipts { get; set; }
    }

    public class ReceiptHistoryModel {
        public int ID { get; set; }
        public DateTime OrderAt { get; set; }
        public string Method { get; set; }
        public string CardNumber { get; set; }
        public int TotalPay { get; set; }
        public string Status { get; set; }
        public string Notes { get; set; }
        public int TotalPrice { get; set; }
        public int TotalDiscount { get; set; }
        public int ShippingCost { get; set; }
        public DateTime DeliveryAt { get; set; }
    }

    public class ReceiptDetailViewModel {
        public ReceiptHistoryModel receipt { get; set; }
        public ICollection<ReceiptDetail> details { get; set; }
    }

    public class OrderStatus {
        public static readonly string SUCCESS = "Đã giao hàng";
        public static readonly string CANCEL = "Đã huỷ";
        public static readonly string IN_PROCESS = "Đang xử lý";
    }
}