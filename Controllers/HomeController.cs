using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Clothing_Store.Models;
using Clothing_Store.Utils;
using Microsoft.EntityFrameworkCore;

namespace Clothing_Store.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDBContext _context;

        public HomeController(ApplicationDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            try
            {
                var topSale = _context.productTags
                    .Where(pt => pt.tag.Name == "San Pham Ban Chay")
                    .Where(pt => pt.product.IsDelete == false)
                    .Where(pt => pt.product.Visible == true)
                    .Include(pt => pt.product)
                    .ThenInclude(p => p.ratings)
                    .Include(pt => pt.product)
                    .ThenInclude(p => p.images)
                    .Select(pt => new ProductViewModel()
                    {
                        ID = pt.product.ID,
                        Name = pt.product.Name,
                        Price = (pt.product.promotion != null || !pt.product.promotion.IsDelete) && (pt.product.promotion.To > DateTime.Now)
                            ? (int)Math.Round((pt.product.Price - (pt.product.Price * (double)pt.product.promotion.Discount / 100)) / 1000) * 1000
                            : pt.product.Price,
                        ratings = (int)Math.Round(pt.product.ratings.Where(r => r.IsDelete == false).Average(r => r.Star)),
                        image = pt.product.images.Where(i => i.IsDelete == false).FirstOrDefault()
                    }).Take(8);

                var newProducts = _context.productTags
                    .Where(pt => pt.tag.Name == "San Pham Moi")
                    .Where(pt => pt.product.IsDelete == false)
                    .Where(pt => pt.product.Visible == true)
                    .Include(pt => pt.product)
                    .ThenInclude(p => p.ratings)
                    .Include(pt => pt.product)
                    .ThenInclude(p => p.images)
                    .Select(pt => new ProductViewModel()
                    {
                        ID = pt.product.ID,
                        Name = pt.product.Name,
                        Price = (pt.product.promotion != null || !pt.product.promotion.IsDelete) && (pt.product.promotion.To > DateTime.Now)
                            ? (int)Math.Round((pt.product.Price - (pt.product.Price * (double)pt.product.promotion.Discount / 100)) / 1000) * 1000
                            : pt.product.Price,
                        ratings = (int)Math.Round(pt.product.ratings.Where(r => r.IsDelete == false).Average(r => r.Star)),
                        image = pt.product.images.Where(i => i.IsDelete == false).FirstOrDefault()
                    }).Take(8);

                HomeViewModel hvM = new HomeViewModel();
                hvM.NewProducts = newProducts.ToList();
                hvM.TopSaleProducts = topSale.ToList();

                return View(hvM);
            }
            catch
            {
                return Error();
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
