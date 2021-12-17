using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clothing_Store.Areas.Admin.Models;
using Clothing_Store.Models;
using Clothing_Store.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Clothing_Store.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : BaseController
    {
        private readonly ApplicationDBContext _context;

        public ProductController(ApplicationDBContext context)
        {
            _context = context;
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
                
                return View(new AdminProductViewModel() { products = products, currentUsername = GetCurrentUserName() });
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

                vm.currentUsername = GetCurrentUserName();
                return View(vm);
            }
            catch (Exception e)
            {
                return Ok(e);
            }
        }

        //GET: /Admin/Product/Add
        public IActionResult Add()
        {
            return Ok("add new");
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
                    warehouses = wareHouses,
                    currentUsername = GetCurrentUserName()
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
