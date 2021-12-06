using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clothing_Store.Models
{
    public class CartProducts
    {
       public int ID { get; set; }
       public string Name { get; set; }
       public string Type { get; set; }
       public string Color { get; set; }
       public string Size { get; set; }
       public int Quantity { get; set; }
       public Image image { get; set; }
       public int Price { get; set; }
       public int Promotion { get; set; }
       public int WarehoustID { get; set; }
    }
}
