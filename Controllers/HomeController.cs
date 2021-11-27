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
            var products = _context.Products
                .Where(p => p.IsDelete == false)
                .Where(p => p.Visible == true)
                .Include(p => p.ratings)
                .Include(p => p.images)
                .Select(p => new ProductViewModel()
                 {
                     ID = p.ID,
                     Name = p.Name,
                     Price = p.Price,
                     ratings = (int)Math.Round(p.ratings.Average(r => r.Star)),
                     image = p.images.FirstOrDefault()
                 });

            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult NotFound()
        {
            return Ok("This is the message to announce you this page is not found, will adjust to the template not found later");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
