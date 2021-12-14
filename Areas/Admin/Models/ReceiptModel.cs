using Clothing_Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clothing_Store.Areas.Admin.Models
{
    public class AdminReceiptHistoryViewModel
    {
        public int ID { get; set; }
        public string Fullname { get; set; }
        public string Phone { get; set; }
        public DateTime OrderAt { get; set; }
        public DateTime DeliveryAt { get; set; }
        public string Method { get; set; }
        public int TotalPay { get; set; }
        public string Status { get; set; }
    }

    public class AdminReceiptHistoryModel
    {
        public int ID { get; set; }
        public string Fullname { get; set; }
        public string Address { get; set; }
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

    public class AdminReceiptDetailViewModel
    {
        public AdminReceiptHistoryModel receipt { get; set; }
        public ICollection<ReceiptDetail> details { get; set; }
    }
}
