using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Clothing_Store.Models
{
    public class PaymentViewModel
    {
        public PaymentInfoModel info { get; set; }
        public ICollection<CartPaymentModel> carts { get; set; }
    }

    public class CartPaymentModel
    {
        public Product product { get; set; }
        public Promotion promotion { get; set; }
        public int quantity { get; set; }
    }

    public class PaymentInfoModel
    {
        [Required(ErrorMessage = "Yêu cầu nhập họ và tên")]
        public string Fullname { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập email")]
        [StringLength(255)]
        [EmailAddress(ErrorMessage = "Địa chỉ email không hợp lệ")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập số điện thoại")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Số điện thoại không hợp lệ")]
        [MaxLength(10, ErrorMessage = "Số điện thoại có tối đa 10 số")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập địa chỉ")]
        public string Address { get; set; }

        [MaxLength(255, ErrorMessage = "Ghi chú có tối đa 255 ký tự")]
        public string? Note { get; set; }

        [Required(ErrorMessage = "Yêu cầu chọn phương thức vận chuyển")]
        public string Method { get; set; } = "COD";

        [StringLength(12, MinimumLength = 12, ErrorMessage = "Số thẻ phải bao gồm 12 số")]
        [MaxLength(12, ErrorMessage = "Số thẻ phải có tối đa 12 số")]
        public string? CardNumber { get; set; }

        public DateTime? ValidDate { get; set; }

        [StringLength(12, MinimumLength = 7, ErrorMessage = "Mã số bí mật phải bao gồm 7 số")]
        [MaxLength(7, ErrorMessage = "Mã số bí mật có tối đa 7 số")]
        public string? SecretNumber { get; set; }
    }
}
