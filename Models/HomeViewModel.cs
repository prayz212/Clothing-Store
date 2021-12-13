using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clothing_Store.Models
{
    public class HomeViewModel
    {
        public ICollection<ProductViewModel> NewProducts { get; set; }

        public ICollection<ProductViewModel> TopSaleProducts { get; set; }

    }
}
