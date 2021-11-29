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
                Product detail = _context.Products
                    .Where(p => p.ID == id)
                    .Where(p => p.IsDelete == false)
                    .Where(p => p.Visible == true)
                    .Include(p => p.ratings)
                    .Include(p => p.images)
                    .Include(p => p.warehouses)
                    .Include(p => p.promotion)
                    .Select(p => new Product
                    {
                        ID = p.ID,
                        Name = p.Name,
                        Price = p.Price,
                        Description = p.Description,
                        ratings = p.ratings.Where(r => r.IsDelete == false).ToList(),
                        warehouses = p.warehouses,
                        promotion = (p.promotion == null || p.promotion.IsDelete)
                            ? null
                            : p.promotion,
                        images = p.images.Where(i => i.IsDelete == false).ToList()
                    }).ToList().FirstOrDefault();

                var tags = _context.productTags
                    .Where(pt => pt.ProductID == id)
                    .Select(pt => pt.TagID)
                    .ToList();

                var relative = _context.productTags
                    .Include(pt => pt.product)
                    .ThenInclude(p => p.ratings)
                    .Include(pt => pt.product)
                    .ThenInclude(p => p.images)
                    .Where(pt => tags.Contains(pt.TagID))
                    .Where(pt => pt.ProductID != detail.ID)
                    .Select(pt => new ProductViewModel()
                    {
                        ID = pt.product.ID,
                        Name = pt.product.Name,
                        Price = (pt.product.promotion != null || !pt.product.promotion.IsDelete)
                            ? (int)Math.Round((pt.product.Price - (pt.product.Price * (double)pt.product.promotion.Discount / 100)) / 1000) * 1000
                            : pt.product.Price,
                        ratings = (int)Math.Round(pt.product.ratings.Where(r => r.IsDelete == false).Average(r => r.Star)),
                        image = pt.product.images.Where(i => i.IsDelete == false).FirstOrDefault()
                    }).ToList();

                ProductDetailViewModel vm = new ProductDetailViewModel();
                vm.detail = detail;
                vm.ralativeProducts = relative;

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
