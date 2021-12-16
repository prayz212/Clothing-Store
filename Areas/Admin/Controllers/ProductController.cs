using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Clothing_Store.Areas.Admin.Models;
using Clothing_Store.Models;
using Clothing_Store.Utils;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Clothing_Store.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly ApplicationDBContext _context;
        private readonly IWebHostEnvironment _environment;

        public ProductController(ApplicationDBContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            try
            {
                List<AdminProductModel> products = _context.Products
                    .Where(p => p.IsDelete == false)
                    .Include(p => p.promotion)
                    .Include(p => p.ratings)
                    .Select(p => new AdminProductModel()
                    {
                        ID = p.ID,
                        Name = p.Name,
                        ProductType = p.ProductType,
                        Price = p.Price,
                        Discount = p.promotion != null && p.promotion.From <= DateTime.Now && p.promotion.To >= DateTime.Now
                            ? p.promotion.Discount
                            : 0,
                        Ratings = (int)Math.Round(p.ratings.Where(r => r.IsDelete == false).Average(r => r.Star)),
                        Visible = p.Visible ? "Có" : "Không"
                    })
                    .ToList();

                return View(new AdminProductViewModel() { products = products });
            }
            catch (Exception e)
            {
                return Ok(e);
            }
        }

        //GET: /Admin/Product/Details/5
        public IActionResult Details(int id) 
        {
            try
            {
                AdminProductDetailViewModel vm = _context.Products
                    .Where(p => p.ID == id)
                    .Where(p => p.IsDelete == false)
                    .Include(p => p.ratings)
                    .Include(p => p.images)
                    .Include(p => p.warehouses)
                    .Include(p => p.promotion)
                    .Select(p => new AdminProductDetailViewModel()
                    {
                        ID = p.ID,
                        Name = p.Name,
                        Description = p.Description,
                        ProductType = p.ProductType,
                        Price = p.Price,
                        Visible = p.Visible ? "Có" : "Không",
                        InPromotion = p.promotion != null && p.promotion.From <= DateTime.Now && p.promotion.To >= DateTime.Now
                            ? "Có"
                            : "Không",
                        Discount = p.promotion != null && p.promotion.From <= DateTime.Now && p.promotion.To >= DateTime.Now
                            ? p.promotion.Discount
                            : 0,
                        TotalSold = p.warehouses.Sum(w => w.Sold),
                        Ratings = (int)Math.Round(p.ratings.Average(r => r.Star)),
                        images = p.images.Where(i => i.IsDelete == false).ToList(),
                        warehouses = p.warehouses.ToList()
                    })
                    .FirstOrDefault();

                if (vm == null)
                {
                    return RedirectToAction("Index");
                }

                return View(vm);
            }
            catch (Exception e)
            {
                return Ok(e);
            }
        }

        //GET: /Admin/Product/Create
        public IActionResult Create()
        {
            try
            {
                var productTypes = _context.Products.Select(p => p.ProductType).Distinct().ToList();
                AdminCreateProductViewModel vm = new AdminCreateProductViewModel();

                var productTags = _context.tags.ToList();

                vm.types = productTypes;
                vm.tags = productTags;

                return View(vm);
            }
            catch (Exception e)
            {
                return Ok(e);
            }
        }

        //POST: /Admin/Product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AdminCreateProductViewModel vm)
        {
            try
            {
                Product product = new Product()
                {
                    Name = vm.model.Name,
                    ProductType = vm.model.ProductType,
                    Price = vm.model.Price,
                    Visible = bool.Parse(vm.model.Visible),
                    Description = vm.model.Description
                };

                _context.Products.Add(product);
                _context.SaveChanges();

                string baseName = product.Name;
                List<Image> images = new List<Image>();

                var files = HttpContext.Request.Form.Files;
                var count = 0;
                foreach (var image in files)
                {
                    if (image != null && image.Length > 0)
                    {
                        var file = image;
                        var uploads = Path.Combine(_environment.WebRootPath, "uploads/product");
                        if (file.Length > 0)
                        {
                            var fileName = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(file.FileName);
                            using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                            {
                                await file.CopyToAsync(fileStream);
                                Image img = new Image()
                                {
                                    Name = baseName + " " + count,
                                    URL = fileName,
                                    product = product
                                };
                                images.Add(img);
                                count++;
                            }

                        }
                    }
                }

                await _context.images.AddRangeAsync(images);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", new { id = product.ID });
            }
            catch (Exception e)
            {
                return Ok(e);
            }
        }

        //GET: /Admin/Product/Add
        public IActionResult Edit(int id)
        {
            try
            {
                return Ok("edit page");
            }
            catch (Exception e)
            {
                return Ok(e);
            }
        }

        //GET: /Admin/Product/Delete/5
        public IActionResult Delete(int id)
        {
            try
            {
                var product = _context.Products.Where(p => p.ID == id).FirstOrDefault();
                if (product != null) {
                    product.IsDelete = true;
                    _context.Products.Update(product);
                    _context.SaveChanges();

                    return RedirectToAction("Index");
                }
                else
                {
                    return Ok("loi roi");
                }
            }
            catch (Exception e)
            {
                return Ok(e);
            }
            
        }

        public IActionResult StockIn(int id)
        {
            try
            {
                List<Warehouse> wareHouses = _context.warehouses
                    .Where(wh => wh.product.ID == id).ToList();

                AdminStockInViewModel stockInView = new AdminStockInViewModel
                {
                    productID = id,
                    warehouses = wareHouses
                };

                ViewBag.stockInError = TempData["stockInError"];
                return View(stockInView);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult StockIn(AdminStockInViewModel productInfo, int id)
        {
            try
            {
                var stockIn = productInfo.validate;

                if (stockIn.Quantity <= 0)
                {
                    TempData["stockInError"] = "Số lượng sản phẩm phải lớn hơn 0";
                    return RedirectToAction("StockIn", "Product");

                }

                var warehouse = _context.warehouses
                    .Where(wh => wh.product.ID == id)
                    .Where(wh => wh.Color == stockIn.Color)
                    .Where(wh => wh.Size == stockIn.Size)
                    .FirstOrDefault();

                if (warehouse == null)
                {
                    Product _product = _context.Products
                        .Where(p => p.ID == id)
                        .FirstOrDefault();

                    Warehouse newWarehouse = new Warehouse
                    {
                        Size = stockIn.Size,
                        Color = stockIn.Color,
                        Quantity = stockIn.Quantity,
                        Sold = 0,
                        LastUpdate = DateTime.Now,
                        product = _product
                    };

                    _context.warehouses.Add(newWarehouse);
                } else
                {
                    warehouse.Quantity = warehouse.Quantity + stockIn.Quantity;
                }
                _context.SaveChanges();

                TempData["stockInError"] = "";
                return RedirectToAction("Details", "Product", new { id = id });
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}
