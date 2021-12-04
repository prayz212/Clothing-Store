using System;
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
}
