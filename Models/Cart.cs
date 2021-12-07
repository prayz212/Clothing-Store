using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clothing_Store.Models
{
    [Table("Cart")]
    public class Cart
    {
        public int ID { get; set; }

        public Account account { get; set; }
    }
}
