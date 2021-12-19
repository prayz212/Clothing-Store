using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Clothing_Store.Areas.Admin.Models;
using Clothing_Store.Models;
using Clothing_Store.Utils;
using Microsoft.AspNetCore.Hosting;
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
                
                return View(new AdminProductViewModel() { products = products, currentUsername = GetCurrentUserName() });
            }
            catch (Exception e)
            {
                return RedirectToAction("Error", "Exception");
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
                vm.currentUsername = GetCurrentUserName();

                return View(vm);
            }
            catch (Exception e)
            {
                return RedirectToAction("Error", "Exception");
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
                vm.currentUsername = GetCurrentUserName();

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
        public async Task<IActionResult> Create(IFormCollection vm)
        {
            try
            {
                int price = 0;
                Int32.TryParse(vm["model.Price"], out price);

                Product product = new Product()
                {
                    Name = vm["model.Name"],
                    ProductType = vm["model.ProductType"],
                    Price = price,
                    Visible = bool.Parse(vm["model.Visible"]),
                    Description = vm["model.Description"]
                };

                _context.Products.Add(product);
                _context.SaveChanges();

                int _id = product.ID;
                ProductTag productTag = new ProductTag();
                int intTagID = 1;
                foreach (string tagID in vm["tags[]"])
                {
                    Int32.TryParse(tagID, out intTagID);
                    productTag = new ProductTag
                    {
                        TagID = intTagID,
                        ProductID = _id
                    };
                    _context.productTags.Add(productTag);
                };
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
                return RedirectToAction("Details", new { id = _id });
            }
            catch (Exception e)
            {
                return Ok(e);
            }
        }

        //GET: /Admin/Product/Update
        public IActionResult Update(int id)
        {
            try
            {
                var productTypes = _context.Products.Select(p => p.ProductType).Distinct().ToList();
                AdminEditProductViewModel vm = new AdminEditProductViewModel();

                Product product = _context.Products
                    .Where(p => p.ID == id)
                    .FirstOrDefault();

                PromotionViewModel promotion = _context.promotions
                    .Where(p => p.ProductID == id)
                    .Where(p => p.Visible == true && p.IsDelete == false)
                    .Select(p => new PromotionViewModel
                    {
                        Discount = p.Discount,
                        From = p.From,
                        To = p.To
                    })
                    .FirstOrDefault();

                vm.promotion = promotion;
                vm.product = product; 
                vm.types = productTypes;
                vm.model = new AdminCreateProductModel();
                vm.model.Name = product.Name;
                vm.model.Price = product.Price;
                vm.model.ProductType = product.ProductType;
                vm.model.Description = product.Description;
                vm.model.Visible = product.Visible.ToString();

                List<Image> image = _context.images
                    .Where(i => i.product.ID == id)
                    .Where(i => i.IsDelete == false)
                    .ToList();

                vm.model.image1 = image.ElementAtOrDefault(0) != null ? image[0].URL : vm.model.image1;
                vm.model.image2 = image.ElementAtOrDefault(1) != null ? image[1].URL : vm.model.image2;
                vm.model.image3 = image.ElementAtOrDefault(2) != null ? image[2].URL : vm.model.image3;
                vm.model.image4 = image.ElementAtOrDefault(3) != null ? image[3].URL : vm.model.image4;

                var tagsTemp = _context.productTags
                    .Where(pt => pt.ProductID == id)
                    .Where(pt => pt.tag.IsDelete == false)
                    .Select(pt => new Tag
                    {
                        ID = pt.tag.ID,
                        Name = pt.tag.Name
                    });

                var Tags = _context.tags
                    .Select(t => new Tag
                    {
                        ID = t.ID,
                        Name = t.Name,
                    }).Except(tagsTemp)
                    .ToList();

                var tags = tagsTemp.ToList();

                vm.productTags = tags;
                vm.tags = Tags;
                vm.currentUsername = GetCurrentUserName();

                ViewBag.productEditError = TempData["productEditError"];

                return View(vm);
            }
            catch (Exception e)
            {
                return Ok(e);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(IFormCollection vm, int id)
        {
            try
            {
                var _vm = vm;
                if (vm["discountFrom"] != "" || vm["discount"] != "" || vm["discountTo"] != "")
                {
                    if (vm["discount"] == "")
                    {
                        TempData["productEditError"] = "Cần nhập đầy đủ thông tin cho chiết khấu";
                        return RedirectToAction("Update");
                    }
                    if (vm["discountTo"] == "")
                    {
                        TempData["productEditError"] = "Cần nhập đầy đủ thông tin cho chiết khấu";
                        return RedirectToAction("Update");
                    }
                    if (vm["discount"] == "")
                    {
                        TempData["productEditError"] = "Cần nhập đầy đủ thông tin cho chiết khấu";
                        return RedirectToAction("Update");
                    }
                }

                if (vm["discountFrom"] != "" && vm["discountTo"] != "" && vm["discount"] != "")
                {
                    DateTime from = DateTime.Parse(vm["discountFrom"]);
                    DateTime to = DateTime.Parse(vm["discountTo"]);
                    int discount = -1;
                    Int32.TryParse(vm["discount"], out discount);

                    if (discount < 0 || discount > 100)
                    {
                        TempData["productEditError"] = "Chiết khấu phải là số lớn hơn 0";
                        return RedirectToAction("Update");
                    }

                    if (to < from)
                    {
                        TempData["productEditError"] = "Thời gian chiết khấu không hợp lệ";
                        return RedirectToAction("Update");
                    }

                    Promotion promotion = _context.promotions
                        .Where(p => p.ProductID == id)
                        .FirstOrDefault();

                    if (promotion != null)
                    {
                        promotion.Discount = discount;
                        promotion.To = to;
                        promotion.From = from;
                    } else
                    {
                        Promotion newPromotion = new Promotion
                        {
                            Discount = discount,
                            From = from,
                            To = to,
                            ProductID = id
                        };
                        _context.promotions.Add(newPromotion);
                    }
                    _context.SaveChanges();
                }

                int price = 0;
                Int32.TryParse(vm["model.Price"], out price);

                string imgRemove = vm["removeImg"];
                string[] imgs = imgRemove.Split("|");
                Image deleteIMG = null;

                foreach (string imgURL in imgs)
                {
                    if (imgURL != "")
                    {
                        deleteIMG = _context.images
                            .Where(img => img.URL == imgURL)
                            .FirstOrDefault();

                        if (deleteIMG != null)
                        {
                            deleteIMG.IsDelete = true;

                            _context.SaveChanges();
                        }
                    }
                }

                var oldProductTag = _context.productTags
                                    .Where(pt => pt.ProductID == id)
                                    .ToList();

                _context.productTags.RemoveRange(oldProductTag);
                _context.SaveChanges();

                Product product = _context.Products
                    .Where(p => p.ID == id)
                    .FirstOrDefault();

                product.Name = vm["model.Name"];
                product.ProductType = vm["model.ProductType"];
                product.Price = price;
                product.Visible = bool.Parse(vm["model.Visible"]);
                product.Description = vm["model.Description"];

                _context.SaveChanges();

                ProductTag productTag = new ProductTag();
                int intTagID = 1;
                foreach (string tagID in vm["tags[]"])
                {
                    Int32.TryParse(tagID, out intTagID);
                    productTag = new ProductTag
                    {
                        TagID = intTagID,
                        ProductID = id
                    };
                    _context.productTags.Add(productTag);
                };
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

                TempData["productEditError"] = "";
                await _context.images.AddRangeAsync(images);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", new { id = id});
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
                    return RedirectToAction("Error", "Exception");
                }
            }
            catch (Exception e)
            {
                return RedirectToAction("Error", "Exception");
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
                return RedirectToAction("Error", "Exception");
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
                return RedirectToAction("Error", "Exception");
            }
        }
    }
}
