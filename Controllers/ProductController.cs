using Clothing_Store.Models;
using Clothing_Store.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Clothing_Store.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDBContext _context;

        public ProductController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        // GET: Product/Details/5
        public IActionResult Details(int id)
        {
            try
            {
                ProductDetailViewModel vm = _context.Products
                    .Where(p => p.ID == id)
                    .Where(p => p.IsDelete == false)
                    .Where(p => p.Visible == true)
                    .Include(p => p.ratings)
                    .Include(p => p.images)
                    .Include(p => p.warehouses)
                    .Include(p => p.promotion)
                    .Select(p => new ProductDetailViewModel()
                    {
                        ID = p.ID,
                        Name = p.Name,
                        Price = p.Price,
                        Description = p.Description,
                        Ratings = (int)Math.Round(p.ratings.Average(r => r.Star)),
                        Sold = p.warehouses.Sum(w => w.Sold),
                        Discount = p.promotion.Discount,
                        Colors = p.warehouses.Select(w => w.Color).ToList(),
                        Sizes = p.warehouses.Select(w => w.Size).ToList(),
                        Images = p.images.ToList()
                    }).ToList().FirstOrDefault();
                return View(vm);
            }
            catch
            {
                return Error();
            }
            
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
