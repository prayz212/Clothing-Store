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
        private readonly int PAGE_SIZE = 12;

        public ProductController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: Product
        public async Task<IActionResult> Index(string sortBy, string searchByName, string currentSearch, string filter, int? page)
        {
            try
            {
                ViewBag.sortBy = sortBy;
                ViewBag.searchByName = searchByName;
                ViewBag.filter = filter;

                if (searchByName != null || page == null)
                {
                    page = 1;
                }
                else
                {
                    searchByName = currentSearch;
                }

                if (String.IsNullOrEmpty(searchByName)) { searchByName = ""; }

                if (String.IsNullOrEmpty(filter)) { filter = ""; }

                ViewBag.currentSearch = searchByName;

                searchByName = searchByName.ToUpper();
                filter = filter.ToUpper();
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
                    Price = (p.promotion != null || !p.promotion.IsDelete) && (p.promotion.To > DateTime.Now)
                                ? (int)Math.Round((p.Price - (p.Price * (double)p.promotion.Discount / 100)) / 1000) * 1000
                                : p.Price,
                    ratings = (int)Math.Round(p.ratings.Where(r => r.IsDelete == false).Average(r => r.Star)),
                    image = p.images.Where(i => i.IsDelete == false).FirstOrDefault()
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

                
                return View(await PaginatedList<ProductViewModel>.CreateAsync(products.AsNoTracking(), page ?? 1, PAGE_SIZE));
            } catch (Exception e)
            {
                return RedirectToAction("Error", "Exception");
            }
        }

        // GET: Product/TopSales
        public async Task<IActionResult> TopSales(int? page)
        {
            try
            {
                ViewBag.Title = "Sản phẩm bán chạy";
                ViewBag.Action = "TopSales";

                var tag = _context.tags
                    .Where(t => t.Name == "San Pham Ban Chay")
                    .FirstOrDefault();

                var products = _context.productTags
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
                    });

                return View("Specials", await PaginatedList<ProductViewModel>.CreateAsync(products.AsNoTracking(), page ?? 1, PAGE_SIZE));
            }
            catch (Exception e)
            {
                return RedirectToAction("Error", "Exception");
            }
            
        }

        // GET: Product/NewProducts
        public async Task<IActionResult> NewProducts(int? page)
        {
            try
            {
                ViewBag.Title = "Sản phẩm mới";
                ViewBag.Action = "NewProducts";

                var products = _context.productTags
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
                    });

                return View("Specials", await PaginatedList<ProductViewModel>.CreateAsync(products.AsNoTracking(), page ?? 1, PAGE_SIZE));
            }
            catch (Exception e)
            {
                return RedirectToAction("Error", "Exception");
            }

        }

        // GET: Product/Promotion
        public async Task<IActionResult> FlashSale(int? page)
        {
            try
            {
                ViewBag.Title = "Flash Sale";
                ViewBag.Action = "FlashSale";

                var products = _context.Products
                    .Where(p => p.IsDelete == false)
                    .Where(p => p.Visible == true)
                    .Where(p => p.promotion.To >= DateTime.Now)
                    .Where(p => p.promotion.IsDelete == false)
                    .Where(p => p.promotion.Visible == true)
                    .Include(p => p.ratings)
                    .Include(p => p.images)
                    .Select(p => new ProductViewModel()
                    {
                        ID = p.ID,
                        Name = p.Name,
                        Price = (p.promotion != null || !p.promotion.IsDelete)
                            ? (int)Math.Round((p.Price - (p.Price * (double)p.promotion.Discount / 100)) / 1000) * 1000
                            : p.Price,
                        ratings = (int)Math.Round(p.ratings.Where(r => r.IsDelete == false).Average(r => r.Star)),
                        image = p.images.Where(i => i.IsDelete == false).FirstOrDefault()
                    });

                return View("Specials", await PaginatedList<ProductViewModel>.CreateAsync(products.AsNoTracking(), page ?? 1, PAGE_SIZE));
            }
            catch (Exception e)
            {
                return RedirectToAction("Error", "Exception");
            }

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
                        promotion = (p.promotion == null || p.promotion.IsDelete || p.promotion.To < DateTime.Now)
                            ? null
                            : p.promotion,
                        images = p.images.Where(i => i.IsDelete == false).ToList()
                    }).ToList().FirstOrDefault();

                if (detail == null)
                {
                    return RedirectToAction("Index", "Product");
                }

                var tags = _context.productTags
                    .Where(pt => pt.ProductID == id)
                    .Select(pt => pt.TagID)
                    .ToList();

                var relative = _context.productTags
                    .Include(pt => pt.product)
                    .ThenInclude(p => p.ratings)
                    .Include(pt => pt.product)
                    .ThenInclude(p => p.images)
                    .Where(p => p.product.IsDelete == false && p.product.Visible == true)
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
                return RedirectToAction("Error", "Exception");
            }
            
        }

        // POST: Product/Rating
        [HttpPost]
        public JsonResult Rating(IFormCollection form)
        {
            try
            {
                if (form.Count == 0)
                {
                    return Json(new { status = "fail" });
                }

                int productId = Int32.Parse(form["ProductId"][0]);
                int receiptId = Int32.Parse(form["ReceiptId"][0]);
                int rating = Int32.Parse(form["rating"][0]);

                var receipt = _context.receipts
                    .Where(r => r.ID == receiptId)
                    .FirstOrDefault();

                var product = _context.Products
                    .Where(p => p.ID == productId)
                    .FirstOrDefault();

                Rating isExist = _context.ratings
                    .Where(r => r.receipt.ID == receipt.ID)
                    .Where(r => r.product.ID == product.ID)
                    .FirstOrDefault();

                if (isExist != null)
                {
                    isExist.Star = rating;
                }
                else
                {
                    _context.ratings.Add(new Models.Rating
                    {
                        receipt = receipt,
                        product = product,
                        Star = rating
                    });
                }

                _context.SaveChanges();

                return Json(new { status = "success" });
            }
            catch (Exception e)
            {
                return Json(new { status = "fail" });
            }
        }
    }
}
