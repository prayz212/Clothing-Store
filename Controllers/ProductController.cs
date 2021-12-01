using Clothing_Store.Models;
using Clothing_Store.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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
        public async Task<IActionResult> Index(string sortBy, string searchByName, string currentSearch, string filter, int? page)
        {
            ViewBag.sortBy = sortBy;
            ViewBag.searchByName = searchByName;
            ViewBag.filter = filter;

            if (searchByName != null || page == null)
            {
                page = 1;
            } else
            {
                searchByName = currentSearch;
            }

            if (String.IsNullOrEmpty(searchByName)) { searchByName = ""; }

            if (String.IsNullOrEmpty(filter)) { filter = ""; }

            ViewBag.currentSearch = searchByName;

            var products = _context.Products
                .Where(p => p.IsDelete == false)
                .Where(p => p.Visible == true)
                .Where(p => p.Name.ToUpper().Contains(searchByName.ToUpper()))
                .Where(p => p.ProductType.ToUpper().Contains(filter.ToUpper()))
                .Include(p => p.ratings)
                .Include(p => p.images)
                .Select(p => new ProductViewModel()
                {
                    ID = p.ID,
                    Name = p.Name,
                    Price = p.Price,
                    ratings = (int)Math.Round(p.ratings.Average(r => r.Star)),
                    image = p.images.FirstOrDefault(),
                });


            switch (sortBy)
            {
                case "name_desc":
                    products = products.OrderByDescending(p => p.Name);
                    break;
                case "price_asc":
                    products = products.OrderBy(p => p.Price);
                    break;
                case "price_desc":
                    products = products.OrderByDescending(p => p.Price);
                    break;
                case "rating_asc":
                    products = products.OrderBy(p => p.ratings);
                    break;
                case "rating_desc":
                    products = products.OrderByDescending(p => p.ratings);
                    break;
                default:
                    products = products.OrderBy(p => p.Name);
                    break;
            }

            int pageSize = 12;

            return View(await PaginatedList<ProductViewModel>.CreateAsync(products.AsNoTracking(), page ?? 1, pageSize));
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View();
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
    }
}
